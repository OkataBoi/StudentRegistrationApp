Imports System.ComponentModel

Public Class frmDashboard
    Private ReadOnly _students As New BindingList(Of StudentRecord)

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
            lblStatusMessage.Text = "Student added successfully."
        End If
    End Sub

    Private Sub dgvStudents_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStudents.SelectionChanged
        UpdateStudentSummary()
    End Sub

    Private Sub UpdateStudentSummary()
        If dgvStudents.CurrentRow Is Nothing Then
            studentSummary.DisplayStudent(Nothing)
            Return
        End If

        studentSummary.DisplayStudent(TryCast(dgvStudents.CurrentRow.DataBoundItem, StudentRecord))
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

    Private Sub lblStatusMessage_Click(sender As Object, e As EventArgs) Handles lblStatusMessage.Click

    End Sub

    Private Sub studentSummary_Load(sender As Object, e As EventArgs) Handles studentSummary.Load

    End Sub
End Class