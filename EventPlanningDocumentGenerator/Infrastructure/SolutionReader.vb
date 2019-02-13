Imports System.IO
Imports System.Text.RegularExpressions

Public Class SolutionReader
    Private Property _filePath As String
    Private Property _slnRegex As Regex

    Public Sub New(File As String)
        _filePath = File
        _slnRegex = New Regex("Project\(""{(?:[A-Z-0-9]+)}""\) = ""([A-Za-z0-9 ]+)"", ""([A-Za-z0-9\\. ]+)"", ""{([A-Z-0-9]+)}""")
    End Sub

    ' Reads projects off of the given solution
    Public Function ReadProjects() As List(Of VisualStudioProject)
        Dim file = ""
        Using reader As New StreamReader(_filePath)
            file = reader.ReadToEnd()
        End Using
        Dim matches = _slnRegex.Matches(file)
        Dim projects As New List(Of VisualStudioProject)
        For Each match As Match In matches
            projects.Add(New VisualStudioProject(Guid.Parse(match.Groups.Item(3).Value), match.Groups.Item(1).Value,
                String.Format("{0}\{1}", Path.GetDirectoryName(_filePath), match.Groups.Item(2).Value)))
        Next
        Return projects
    End Function
End Class
