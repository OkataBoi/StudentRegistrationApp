Public Class StudentRecord
    Public Property FullName As String
    Public Property Programme As String
    Public Property Email As String
    Public Property BirthDate As Date
    Public Property Address As String

    Public Overrides Function ToString() As String
        Return FullName & " - " & Programme
    End Function

End Class
