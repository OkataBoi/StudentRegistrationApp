Imports System.ComponentModel

Public Class frmDashboard
    Private ReadOnly _students As New BindingList(Of StudentRecord)

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStudents.DataSource = _students
        lblStudentCount.Text = "Students registered: 0"
        lblStatusMessage.Text = ""
        btnViewStudent.Enabled = False
    End Sub

    Private Sub btnNewRegistration_Click(sender As Object, e As EventArgs) Handles btnNewRegistration.Click
        Using form As New Form1()
            If form.ShowDialog(Me) = DialogResult.OK Then
                _students.Add(form.SavedStudent)
                RefreshDashboard()
            End If
        End Using
    End Sub

    Private Sub RefreshDashboard()
        lblStudentCount.Text = $"Students registered: {_students.Count}"
        If _students.Count > 0 Then
            dgvStudents.ClearSelection()
            dgvStudents.Rows(_students.Count - 1).Selected = True
            dgvStudents.CurrentCell = dgvStudents.Rows(_students.Count - 1).Cells(0)
            btnViewStudent.Enabled = True
            lblStatusMessage.Text = "Student added successfully."
        End If
    End Sub

    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs) Handles btnViewStudent.Click
        If dgvStudents.CurrentRow Is Nothing Then Return

        Dim student = TryCast(dgvStudents.CurrentRow.DataBoundItem, StudentRecord)
        If student Is Nothing Then Return

        Using form As New frmStudentDetails(student)
            form.ShowDialog(Me)
        End Using
    End Sub

    Private Sub lblStatusMessage_Click(sender As Object, e As EventArgs) Handles lblStatusMessage.Click

    End Sub
End Class