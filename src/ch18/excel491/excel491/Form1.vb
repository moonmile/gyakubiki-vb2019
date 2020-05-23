Imports Microsoft.Office.Interop

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        label1.Text = DateTime.Now
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\BookTodo.xlsx")
        Dim sh = DirectCast(wb.ActiveSheet, Excel.Worksheet)
        ' 最終行を取得(1000行までに制限する)
        For r = 2 To 1000
            If sh.Cells(r, 1).Text = "" Or sh.Cells(r, 2).Text = textBox1.Text Then
                sh.Cells(r, 1).Value = label1.Text
                sh.Cells(r, 2).Value = textBox1.Text
                sh.Cells(r, 3).Value = If(checkBox1.Checked, "完了", "未完了")
                Exit For
            End If
        Next
        ' 保存する
        wb.Save()
        xapp.Quit()
    End Sub
End Class
