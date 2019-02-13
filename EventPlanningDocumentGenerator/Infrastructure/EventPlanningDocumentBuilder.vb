Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Style

Public Class EventPlanningDocumentBuilder
    Public Sub BuildAndSaveFile(ProgramName As String, Developer As String, ObjectName As String, Events As List(Of EventPlan))
        Using package As New ExcelPackage
            Dim sheet = package.Workbook.Worksheets.Add("EPD")
            ' Add title
            sheet.Cells().Item(1, 1).Value = "EVENT PLANNING DOCUMENT"
            sheet.Cells().Item(1, 1).Style.Font.Bold = True
            sheet.Cells().Item(1, 1, 1, 2).Merge = True
            ' Add description table
            sheet.Cells().Item(2, 1).Value = "Program Name:"
            sheet.Cells().Item(2, 2).Value = "Developer:"
            sheet.Cells().Item(2, 3).Value = "Object:"
            sheet.Cells().Item(2, 4).Value = "Date:"
            sheet.Cells().Item(2, 1, 2, 4).Style.Font.Bold = True
            sheet.Cells().Item(3, 1).Value = ProgramName
            sheet.Cells().Item(3, 2).Value = Developer
            sheet.Cells().Item(3, 3).Value = ObjectName
            sheet.Cells().Item(3, 4).Style.Numberformat.Format = "mmmm d, yyyy"
            sheet.Cells().Item(3, 4).Value = Date.Today
            sheet.Cells().Item(2, 1, 3, 4).Style.Border.Top.Style = ExcelBorderStyle.Thin
            sheet.Cells().Item(2, 1, 3, 4).Style.Border.Bottom.Style = ExcelBorderStyle.Thin
            sheet.Cells().Item(2, 1, 3, 4).Style.Border.Left.Style = ExcelBorderStyle.Thin
            sheet.Cells().Item(2, 1, 3, 4).Style.Border.Right.Style = ExcelBorderStyle.Thin
            ' Add events table
            sheet.Cells().Item(4, 1).Value = "Object"
            sheet.Cells().Item(4, 2).Value = "Event Trigger"
            sheet.Cells().Item(4, 3).Value = "Event Processing"
            sheet.Cells().Item(4, 1, 4, 4).Style.Font.Bold = True
            sheet.Cells().Item(4, 3, 4, 4).Merge = True
            For i As Integer = 0 To Events.Count - 1
                sheet.Cells().Item(5 + i, 1).Value = Events.Item(i).ObjectName
                sheet.Cells().Item(5 + i, 2).Value = Events.Item(i).EventTrigger
                sheet.Cells().Item(5 + i, 3).Value = Events.Item(i).EventProcessing
                sheet.Cells().Item(5 + i, 3).Style.WrapText = True
                sheet.Cells().Item(5 + i, 3, 5 + i, 4).Merge = True
            Next
            sheet.Cells().Item(4, 1, 4 + Events.Count, 4).Style.Border.Top.Style = ExcelBorderStyle.Thin
            sheet.Cells().Item(4, 1, 4 + Events.Count, 4).Style.Border.Bottom.Style = ExcelBorderStyle.Thin
            sheet.Cells().Item(4, 1, 4 + Events.Count, 4).Style.Border.Left.Style = ExcelBorderStyle.Thin
            sheet.Cells().Item(4, 1, 4 + Events.Count, 4).Style.Border.Right.Style = ExcelBorderStyle.Thin
            sheet.Cells().Item(1, 1, 4 + Events.Count, 4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            sheet.Cells().Item(1, 1, 4 + Events.Count, 4).Style.VerticalAlignment = ExcelVerticalAlignment.Top
            sheet.Cells(sheet.Dimension.Address).AutoFitColumns()
            package.SaveAs(New FileInfo(String.Format("{0}\output\{1}.xlsx", Environment.CurrentDirectory, ProgramName)))
        End Using
    End Sub
End Class
