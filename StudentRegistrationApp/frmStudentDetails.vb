Public Class frmStudentDetails
    Private ReadOnly _student As StudentRecord

    Public Sub New(student As StudentRecord)
        InitializeComponent()
        _student = student
    End Sub

    Private Sub frmStudentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFullName.Text = _student.FullName
        lblProgramme.Text = _student.Programme
        lblEmail.Text = _student.Email
        lblBirthDate.Text = _student.BirthDate.ToShortDateString()
        lblAddress.Text = _student.Address
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub lblProgramme_Click(sender As Object, e As EventArgs) Handles lblProgramme.Click

    End Sub
End Class