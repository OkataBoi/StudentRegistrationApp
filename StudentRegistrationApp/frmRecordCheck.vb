Imports System.Threading
Imports System.Threading.Tasks
Imports System.Collections.Generic

Public Class frmRecordCheck

    Private ReadOnly _records As List(Of StudentRecord)
    Private _cts As CancellationTokenSource

    ' Parameterless constructor supports Designer view
    Public Sub New()
        InitializeComponent()
        _records = New List(Of StudentRecord)()
    End Sub

    ' Receives a snapshot of the dashboard's student list
    Public Sub New(records As List(Of StudentRecord))
        Me.New()
        _records = records
        prgCheck.Maximum = Math.Max(1, _records.Count)
        lblProgress.Text = $"{_records.Count} records ready."
        btnStart.Enabled = (_records.Count > 0)
    End Sub

    ' Asynchronous check loop with cooperative cancellation
    Private Async Function CheckStudentsAsync(token As CancellationToken) As Task(Of Integer)
        Dim invalid As Integer = 0

        For i As Integer = 0 To _records.Count - 1
            token.ThrowIfCancellationRequested()
            Await Task.Delay(500, token)

            Dim s = _records(i)
            Dim valid = ValidationRules.HasText(s.FullName) AndAlso
                        ValidationRules.IsEmailValid(s.Email)

            If Not valid Then invalid += 1

            lstResults.Items.Add(s.FullName & If(valid, " - OK", " Needs review"))
            prgCheck.Value = i + 1
            Dim pct As Integer = (i + 1) * 100 \ _records.Count
            lblProgress.Text = $"{i + 1} of {_records.Count} checked ({pct}%)"
        Next

        Return invalid
    End Function

    ' Controls button availability during and after a run
    Private Sub SetBusy(busy As Boolean)
        btnStart.Enabled = Not busy AndAlso _records.Count > 0
        btnCancelCheck.Enabled = busy
        btnClose.Enabled = Not busy
    End Sub

    ' Starts the asynchronous record check
    Private Async Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If _cts IsNot Nothing Then Return

        _cts = New CancellationTokenSource()
        SetBusy(True)
        lstResults.Items.Clear()
        prgCheck.Value = 0

        Try
            Dim invalid = Await CheckStudentsAsync(_cts.Token)
            lblProgress.Text = $"Complete. {invalid} need review."
        Catch ex As OperationCanceledException
            lblProgress.Text = "Cancelled. Completed results remain."
        Catch ex As Exception
            lblProgress.Text = "Check failed."
            MessageBox.Show(Me, ex.Message, "Check failed")
        Finally
            _cts.Dispose()
            _cts = Nothing
            SetBusy(False)
        End Try
    End Sub

    ' Requests cancellation of the running task
    Private Sub btnCancelCheck_Click(sender As Object, e As EventArgs) Handles btnCancelCheck.Click
        If _cts IsNot Nothing Then _cts.Cancel()
    End Sub

    ' Closes the form once idle
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Prevents closing via the window X button while a check is still running
    Private Sub frmRecordCheck_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _cts IsNot Nothing Then
            e.Cancel = True
            _cts.Cancel()
            lblProgress.Text = "Cancelling... close when stopped."
        End If
    End Sub

End Class