Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\Book1.xlsx")
        Dim sh = DirectCast(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
        sh.Range("B2").Value = textBox1.Text
        wb.SaveAs("C:\VB2019\data\BookSave.xlsx")
        MessageBox.Show("保存しました")
        xapp.Quit()
    End Sub
End Class
