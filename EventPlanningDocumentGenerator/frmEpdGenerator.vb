Public Class frmEpdGenerator
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

    End Sub
End Class