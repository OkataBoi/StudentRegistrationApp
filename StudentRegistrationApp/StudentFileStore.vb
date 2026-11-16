Imports System.IO
Imports System.Text.Json
Imports System.Threading.Tasks

Public Module StudentFileStore

    Public ReadOnly DataFolder As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "BIT326_StudentRegistration")

    Public ReadOnly StudentsPath As String = Path.Combine(DataFolder, "students.json")

    Public Async Function SaveAsync(records As List(Of StudentRecord)) As Task
        Directory.CreateDirectory(DataFolder)
        Dim options As New JsonSerializerOptions With {.WriteIndented = True}
        Dim json = JsonSerializer.Serialize(records, options)

        Dim tempPath = StudentsPath & ".tmp"
        Await File.WriteAllTextAsync(tempPath, json)
        File.Move(tempPath, StudentsPath, True)
    End Function

    Private Function IsValidRecord(s As StudentRecord) As Boolean
        If s Is Nothing Then Return False
        Return ValidationRules.HasText(s.FullName) AndAlso
               ValidationRules.HasText(s.Programme) AndAlso
               ValidationRules.IsEmailValid(s.Email) AndAlso
               ValidationRules.HasText(s.Address) AndAlso
               s.BirthDate.Date >= New Date(1900, 1, 1) AndAlso
               s.BirthDate.Date <= Date.Today
    End Function

    Public Async Function LoadAsync() As Task(Of List(Of StudentRecord))
        If Not File.Exists(StudentsPath) Then
            Throw New FileNotFoundException("Save a file first.")
        End If

        Dim json = Await File.ReadAllTextAsync(StudentsPath)
        Dim records = JsonSerializer.Deserialize(Of List(Of StudentRecord))(json)

        If records Is Nothing Then
            Throw New InvalidDataException("Expected a student list.")
        End If

        For Each student In records
            If Not IsValidRecord(student) Then
                Throw New InvalidDataException("The file contains an invalid student.")
            End If
        Next

        Return records
    End Function

    Public Async Function SavePreferencesAsync(preferences As AppPreferences) As Task
        Directory.CreateDirectory(DataFolder)
        Dim json = JsonSerializer.Serialize(preferences)
        Await File.WriteAllTextAsync(Path.Combine(DataFolder, "settings.json"), json)
    End Function

    Public Async Function LoadPreferencesAsync() As Task(Of AppPreferences)
        Dim file = Path.Combine(DataFolder, "settings.json")
        If Not System.IO.File.Exists(file) Then
            Return New AppPreferences()
        End If

        Dim json = Await System.IO.File.ReadAllTextAsync(file)
        Return If(JsonSerializer.Deserialize(Of AppPreferences)(json), New AppPreferences())
    End Function

End Module
