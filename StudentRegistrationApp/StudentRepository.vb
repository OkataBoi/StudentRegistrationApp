Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Threading.Tasks

Public Class StudentRepository

    Private Const ConnectionString As String =
        "Server=(localdb)\MSSQLLocalDB;" &
        "Database=BIT326;Integrated Security=True;" &
        "Encrypt=False;"

    Private Async Function OpenConnectionAsync() As Task(Of SqlConnection)
        Dim connection As New SqlConnection(ConnectionString)
        Try
            Await connection.OpenAsync()
            Return connection
        Catch
            connection.Dispose()
            Throw
        End Try
    End Function

    Private Function ReadStudent(r As SqlDataReader) As StudentRecord
        Return New StudentRecord With {
            .Id = r.GetInt32(0),
            .FullName = r.GetString(1),
            .Programme = r.GetString(2),
            .Email = r.GetString(3),
            .BirthDate = r.GetDateTime(4),
            .Address = r.GetString(5)
        }
    End Function

    Public Async Function GetAllAsync() As Task(Of List(Of StudentRecord))
        Dim records As New List(Of StudentRecord)()
        Using c = Await OpenConnectionAsync()
            Using cmd As New SqlCommand(
                "SELECT Id, FullName, Programme, Email, BirthDate, Address FROM dbo.Students ORDER BY Id", c)
                Using r = Await cmd.ExecuteReaderAsync()
                    While Await r.ReadAsync()
                        records.Add(ReadStudent(r))
                    End While
                End Using
            End Using
        End Using
        Return records
    End Function

End Class