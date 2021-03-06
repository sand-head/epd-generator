﻿Public Class frmImport
    Private Property _slnReader As SolutionReader

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLoadSolution_Click(sender As Object, e As EventArgs) Handles btnLoadSolution.Click
        dlgOpenFile.ShowDialog()
        If Not dlgOpenFile.CheckFileExists Then
            Return
        End If
        txtSolutionPath.Text = dlgOpenFile.FileName
        _slnReader = New SolutionReader(dlgOpenFile.FileName)
        Dim projects = _slnReader.ReadProjects()
        cboProject.Items.AddRange(projects.ToArray())
        cboProject.Enabled = True
    End Sub

    Private Sub cboProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProject.SelectedIndexChanged
        If cboProject.SelectedIndex = 0 Then
            cboClass.Enabled = False
            Return
        End If

        cboClass.Enabled = True
    End Sub
End Class