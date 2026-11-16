Imports System.ComponentModel
Imports System.IO
Imports System.Text.Json
Imports System.Threading.Tasks

Public Class frmDashboard

    Private ReadOnly _students As New BindingList(Of StudentRecord)
    Private _fileBusy As Boolean

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStudents.AutoGenerateColumns = False
        dgvStudents.Columns.Clear()
        Dim nameColumn As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "FullName",
            .HeaderText = "Student Name",
            .Name = "FullNameColumn",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        }
        dgvStudents.Columns.Add(nameColumn)
        dgvStudents.DataSource = _students
        studentSummary.DisplayStudent(Nothing)
        lblStudentCount.Text = "Students registered: 0"
        lblStatusMessage.Text = ""
    End Sub

    Private Sub btnNewRegistration_Click(sender As Object, e As EventArgs) Handles btnNewRegistration.Click
        Using form As New Form1()
            If form.ShowDialog(Me) = DialogResult.OK AndAlso form.SavedStudent IsNot Nothing Then
                _students.Add(form.SavedStudent)
                RefreshDashboard()
                lblStatusMessage.Text = "Student added successfully."
            End If
        End Using
    End Sub

    Private Sub RefreshDashboard()
        lblStudentCount.Text = $"Students registered: {_students.Count}"
        If _students.Count > 0 Then
            dgvStudents.ClearSelection()
            dgvStudents.CurrentCell = dgvStudents.Rows(_students.Count - 1).Cells(0)
            dgvStudents.Rows(_students.Count - 1).Selected = True
            UpdateStudentSummary()
        Else
            UpdateStudentSummary()
        End If
    End Sub

    Private Sub dgvStudents_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStudents.SelectionChanged
        UpdateStudentSummary()
    End Sub

    Private Sub UpdateStudentSummary()
        If dgvStudents.CurrentRow Is Nothing Then
            studentSummary.DisplayStudent(Nothing)
            btnViewDetails.Enabled = False
            Return
        End If

        studentSummary.DisplayStudent(TryCast(dgvStudents.CurrentRow.DataBoundItem, StudentRecord))
        btnViewDetails.Enabled = Not _fileBusy
    End Sub

    Private Sub studentSummary_ViewRequested(sender As Object, e As EventArgs) Handles studentSummary.ViewRequested
        Dim selected As StudentRecord = studentSummary.Student
        If selected Is Nothing Then Return

        Using form As New frmStudentDetails(selected)
            form.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        Dim selected As StudentRecord = studentSummary.Student
        If selected Is Nothing Then Return

        Using form As New frmStudentDetails(selected)
            form.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnCheckRecords_Click(sender As Object, e As EventArgs) Handles btnCheckRecords.Click
        Using form As New frmRecordCheck(New List(Of StudentRecord)(_students))
            form.ShowDialog(Me)
        End Using
    End Sub

    ' --- Week 7: File Persistence & Configuration ---

    Private Sub SetFileBusy(busy As Boolean)
        _fileBusy = busy
        btnSaveFile.Enabled = Not busy
        btnLoadFile.Enabled = Not busy
        btnSaveSettings.Enabled = Not busy
        chkConfirmLoad.Enabled = Not busy
        btnNewRegistration.Enabled = Not busy
        btnCheckRecords.Enabled = Not busy
        btnViewDetails.Enabled = Not busy AndAlso dgvStudents.CurrentRow IsNot Nothing
        dgvStudents.Enabled = Not busy
        studentSummary.Enabled = Not busy
    End Sub

    Private Async Function RunFileActionAsync(action As Func(Of Task)) As Task
        If _fileBusy Then Return
        SetFileBusy(True)
        Try
            Await action()
        Catch ex As Exception When _
            TypeOf ex Is IOException OrElse
            TypeOf ex Is UnauthorizedAccessException OrElse
            TypeOf ex Is JsonException OrElse
            TypeOf ex Is InvalidDataException
            lblStatusMessage.Text = "File operation failed."
            MessageBox.Show(Me, ex.Message, "File error")
        Finally
            SetFileBusy(False)
        End Try
    End Function

    Private Async Function SaveStudentsAsync() As Task
        Dim snapshot As New List(Of StudentRecord)(_students)
        Await StudentFileStore.SaveAsync(snapshot)
        lblStatusMessage.Text = $"Saved {snapshot.Count} students."
    End Function

    Private Async Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        Await RunFileActionAsync(AddressOf SaveStudentsAsync)
    End Sub

    Private Async Function LoadStudentsAsync() As Task
        Dim loaded = Await StudentFileStore.LoadAsync()
        _students.Clear()
        For Each student In loaded
            _students.Add(student)
        Next
        RefreshDashboard()
        lblStatusMessage.Text = $"Loaded {loaded.Count} students."
    End Function

    Private Async Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        If _fileBusy Then Return
        If chkConfirmLoad.Checked Then
            Dim answer = MessageBox.Show(
                Me,
                "Replace the current list with the saved file?",
                "Load students",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            If answer <> DialogResult.Yes Then Return
        End If
        Await RunFileActionAsync(AddressOf LoadStudentsAsync)
    End Sub

    Private Sub frmDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _fileBusy Then
            e.Cancel = True
            lblStatusMessage.Text = "Wait for the file operation to finish."
        End If
    End Sub

    Private Async Function ApplyPreferencesAsync() As Task
        Dim settings = Await StudentFileStore.LoadPreferencesAsync()
        chkConfirmLoad.Checked = settings.ConfirmBeforeLoad
    End Function

    Private Async Sub frmDashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Await RunFileActionAsync(AddressOf ApplyPreferencesAsync)
    End Sub

    Private Async Function SaveSettingsAsync() As Task
        Dim settings As New AppPreferences With {
            .ConfirmBeforeLoad = chkConfirmLoad.Checked
        }
        Await StudentFileStore.SavePreferencesAsync(settings)
        lblStatusMessage.Text = "Settings saved."
    End Function

    Private Async Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Await RunFileActionAsync(AddressOf SaveSettingsAsync)
    End Sub

    Private Sub chkConfirmLoad_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirmLoad.CheckedChanged

    End Sub

    Private Sub btnDatabase_Click(sender As Object, e As EventArgs) Handles btnDatabase.Click
        Using form As New frmDatabaseBrowser()
            form.ShowDialog(Me)
        End Using
    End Sub
End Class