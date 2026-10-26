Imports System.ComponentModel

Public Class frmDashboard
    ' From Slide 18: Keep the list in frmDashboard
    Private ReadOnly _students As New BindingList(Of StudentRecord)

    ' From Slide 18: Dashboard Load
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstStudents.DataSource = _students
        label2.Text = "0"
        btnViewStudent.Enabled = False
    End Sub

    ' From Slide 20: Open the registration dialog
    Private Sub btnNewRegistration_Click(sender As Object, e As EventArgs) Handles btnNewRegistration.Click
        Using form As New Form1()
            If form.ShowDialog(Me) = DialogResult.OK Then
                _students.Add(form.SavedStudent)
                RefreshDashboard()
            End If
        End Using
    End Sub

    ' From Slide 24: Refresh the dashboard
    Private Sub RefreshDashboard()
        label2.Text = _students.Count.ToString()
        If _students.Count > 0 Then
            lstStudents.SelectedIndex = _students.Count - 1
            btnViewStudent.Enabled = True
            label3.Text = "Student added successfully."
        End If
    End Sub

    ' From Slide 26: Open the selected student
    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs) Handles btnViewStudent.Click
        Dim student = TryCast(lstStudents.SelectedItem, StudentRecord)
        If student Is Nothing Then Return

        Using form As New frmStudentDetails(student)
            form.ShowDialog(Me)
        End Using
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles label3.Click

    End Sub
End Class