Imports Microsoft.Office.Interop

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\Book3.xlsx")
        Dim sh = DirectCast(wb.Sheets.Add(After:=wb.Sheets(wb.Sheets.Count)), Excel.Worksheet)
        sh.Name = textBox1.Text
        ' 保存する
        wb.Save()
        MessageBox.Show("追加しました")
        xapp.Quit()
    End Sub
End Class
