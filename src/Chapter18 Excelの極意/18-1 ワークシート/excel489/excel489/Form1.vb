Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\Book1.xlsx")
        Dim sh = DirectCast(wb.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)
        Dim rg = sh.Range("A1", "C1")
        rg.Interior.Color = System.Drawing.Color.FromArgb(100, 255, 100).ToArgb()
        wb.SaveAs("C:\VB2019\data\BookSave.xlsx")
        MessageBox.Show("保存しました")
        xapp.Quit()
    End Sub
End Class
