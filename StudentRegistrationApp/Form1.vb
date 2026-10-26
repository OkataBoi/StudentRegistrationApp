Public Class Form1
    Inherits System.Windows.Forms.Form

    ' From Slide 22: Property to hold the student data
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SavedStudent As StudentRecord

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboProgramme.SelectedIndex = -1
        dtpBirthDate.MaxDate = Date.Today
        lblStatus.Text = "Ready"
        txtFullName.Focus()
    End Sub

    Private Sub txtFullName_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtFullName.Validating
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            Errors.SetError(txtFullName, "Enter the student's full name.")
            e.Cancel = True
        Else
            Errors.SetError(txtFullName, String.Empty)
        End If
    End Sub

    Private Sub cboProgramme_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles cboProgramme.Validating
        If cboProgramme.SelectedIndex = -1 Then
            Errors.SetError(cboProgramme, "Select a programme.")
            e.Cancel = True
        Else
            Errors.SetError(cboProgramme, String.Empty)
        End If
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim email = txtEmail.Text.Trim()
        Dim valid = email.Contains("@") AndAlso email.Contains(".")
        Errors.SetError(txtEmail, If(valid, "", "Enter a valid email."))
        e.Cancel = Not valid
    End Sub

    ' From Slide 22: Save Button logic
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateChildren() Then Return

        SavedStudent = New StudentRecord With {
            .FullName = txtFullName.Text.Trim(),
            .Programme = cboProgramme.Text,
            .Email = txtEmail.Text.Trim(),
            .BirthDate = dtpBirthDate.Value.Date,
            .Address = txtAddress.Text.Trim()
        }
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub ClearForm()
        txtFullName.Clear()
        cboProgramme.SelectedIndex = -1
        txtEmail.Clear()
        dtpBirthDate.Value = Date.Today
        txtAddress.Clear()
        Errors.Clear()
        lblStatus.Text = "Ready"
        txtFullName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("Can't be undo ")
        ClearForm()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If dtpBirthDate.Value.Date > Date.Today Then
            Errors.SetError(dtpBirthDate, "Date of birth cannot be in the future.")
            Return
        End If
    End Sub
End Class