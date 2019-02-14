Public Class VisualStudioProject
    Public Sub New(ProjectId As Guid, Name As String, FilePath As String)
        Me.ProjectId = ProjectId
        Me.Name = Name
        Me.FilePath = FilePath
    End Sub

    Public Property ProjectId As Guid
    Public Property Name As String
    Public Property FilePath As String

    Public Function GetClasses() As List(Of ClassReference)

    End Function

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
