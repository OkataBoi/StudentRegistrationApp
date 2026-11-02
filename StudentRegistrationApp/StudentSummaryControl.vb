Public Class StudentSummaryControl
    Private _student As StudentRecord

    Public ReadOnly Property Student As StudentRecord
        Get
            Return _student
        End Get
    End Property

    Public Event ViewRequested(sender As Object, e As EventArgs)

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property ShowViewButton As Boolean
        Get
            Return True
        End Get
        Set(value As Boolean)
            ' Deprecated: button is no longer part of this control
        End Set
    End Property

    Public Sub DisplayStudent(student As StudentRecord)
        _student = student

        If student Is Nothing Then
            lblName.Text = "No student selected"
            lblProgramme.Text = "Programme"
            lblEmail.Text = "Email"
            lblPhone.Text = "Phone"
            Return
        End If

        lblName.Text = student.FullName
        lblProgramme.Text = student.Programme
        lblEmail.Text = student.Email
        lblPhone.Text = student.Phone
    End Sub
End Class
