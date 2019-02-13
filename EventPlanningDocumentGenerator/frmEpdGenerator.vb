Imports System.IO

Public Class frmEpdGenerator
    Private Property _edpBuilder As EventPlanningDocumentBuilder

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _edpBuilder = New EventPlanningDocumentBuilder()
    End Sub

    Private Sub frmEpdGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgdEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    ' Checks to see if all textboxes have content and at least one row is present, returns True if conditions are met
    Private Function ShouldEnableGeneration()
        If Not String.IsNullOrWhiteSpace(txtProgramName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtObject.Text) AndAlso Not String.IsNullOrWhiteSpace(txtDeveloper.Text) AndAlso dgdEvents.Rows.Count > 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtProgramName.TextChanged, txtObject.TextChanged, txtDeveloper.TextChanged
        btnGenerate.Enabled = ShouldEnableGeneration()
    End Sub

    Private Sub dgdEvents_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgdEvents.RowsAdded
        btnGenerate.Enabled = ShouldEnableGeneration()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim events As New List(Of EventPlan)
        For i As Integer = 0 To dgdEvents.Rows().Count - 2
            Dim row = dgdEvents.Rows().Item(i)
            events.Add(New EventPlan(If(row.Cells().Item(0)?.Value, ""), If(row.Cells().Item(1)?.Value, ""), If(row.Cells().Item(2)?.Value, "")))
        Next
        _edpBuilder.BuildAndSaveFile(txtProgramName.Text, txtDeveloper.Text, txtObject.Text, events)
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        frmImport.Show()
    End Sub
End Class