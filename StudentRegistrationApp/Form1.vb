Public Class Form1
    Inherits System.Windows.Forms.Form

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SavedStudent As StudentRecord

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboProgramme.SelectedIndex = -1
        dtpBirthDate.MaxDate = Date.Today
        lblStatusLabel.Text = "Ready"
        txtFullName.Focus()
    End Sub

    ' Full Name Validation
    Private Sub txtFullName_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtFullName.Validating
        e.Cancel = Not ValidationRules.HasText(txtFullName.Text)
        Errors.SetError(txtFullName, If(e.Cancel, "Enter the student's full name.", String.Empty))
    End Sub

    ' Programme Selection Validation
    Private Sub cboProgramme_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles cboProgramme.Validating
        If cboProgramme.SelectedIndex = -1 Then
            Errors.SetError(cboProgramme, "Select a programme.")
            e.Cancel = True
        Else
            Errors.SetError(cboProgramme, String.Empty)
        End If
    End Sub

    ' Email Format Validation
    Private Sub txtEmail_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        e.Cancel = Not ValidationRules.IsEmailValid(txtEmail.Text)
        Errors.SetError(txtEmail, If(e.Cancel, "Enter an email such as ama@example.com.", String.Empty))
    End Sub

    Private Sub txtPhone_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtPhone.Validating
        e.Cancel = Not ValidationRules.IsPhoneValid(txtPhone.Text)
        Errors.SetError(txtPhone, If(e.Cancel, "Enter a phone number with exactly 10 digits.", String.Empty))
    End Sub

    ' Birth Date Validation
    Private Sub dtpBirthDate_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles dtpBirthDate.Validating
        If dtpBirthDate.Value.Date > Date.Today Then
            Errors.SetError(dtpBirthDate, "Date of birth cannot be in the future.")
            e.Cancel = True
        Else
            Errors.SetError(dtpBirthDate, String.Empty)
        End If
    End Sub

    ' Address Validation
    Private Sub txtAddress_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            Errors.SetError(txtAddress, "Enter student address.")
            e.Cancel = True
        Else
            Errors.SetError(txtAddress, String.Empty)
        End If
    End Sub

    ' Save Button Logic
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateChildren() Then
            lblStatusLabel.Text = "Please fix validation errors before saving."
            Return
        End If

        SavedStudent = New StudentRecord With {
            .FullName = txtFullName.Text.Trim(),
            .Programme = cboProgramme.Text,
            .Email = txtEmail.Text.Trim(),
            .Phone = txtPhone.Text.Trim(),
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
        txtPhone.Clear()
        dtpBirthDate.Value = Date.Today
        txtAddress.Clear()
        Errors.Clear()
        lblStatusLabel.Text = "Ready"
        txtFullName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearForm()
    End Sub

End Class