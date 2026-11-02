Public Module ValidationRules
    Public Function HasText(value As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(value)
    End Function

    Public Function IsEmailValid(value As String) As Boolean
        If Not HasText(value) Then Return False

        Dim email As String = value.Trim()
        Try
            Dim address As New System.Net.Mail.MailAddress(email)
            Return address.Address = email
        Catch ex As FormatException
            Return False
        End Try
    End Function

    Public Function IsPhoneValid(value As String) As Boolean
        If value Is Nothing Then Return False

        Dim phone As String = value.Trim()
        If phone.Length <> 10 Then Return False

        For Each character As Char In phone
            If Not Char.IsDigit(character) Then Return False
        Next

        Return True
    End Function
End Module
