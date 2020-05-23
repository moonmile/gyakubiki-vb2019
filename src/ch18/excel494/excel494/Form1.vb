Imports Microsoft.Office.Interop

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\Book1.xlsx")
        Dim sh = DirectCast(wb.ActiveSheet, Excel.Worksheet)
        sh.ExportAsFixedFormat(
            Excel.XlFixedFormatType.xlTypePDF, "C:\VB2019\data\Book1.pdf")
        xapp.Quit()
        MessageBox.Show("PDFファイルに保存しました")
    End Sub
End Class
