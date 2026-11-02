Public Class frmStudentDetails
    Private ReadOnly _student As StudentRecord

    Public Sub New(student As StudentRecord)
        InitializeComponent()
        _student = student
    End Sub

    Private Sub frmStudentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNameValue.Text = _student.FullName
        lblProgrammeValue.Text = _student.Programme
        lblEmailValue.Text = _student.Email
        lblPhoneValue.Text = _student.Phone
        lblBirthDateValue.Text = _student.BirthDate.ToString("dd MMM yyyy")
        lblAddressValue.Text = _student.Address
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class