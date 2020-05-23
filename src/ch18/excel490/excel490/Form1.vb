Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\Book1.xlsx")
        Dim sh = DirectCast(wb.ActiveSheet, Excel.Worksheet)

        ' 終端を探す
        Dim rmax = 2
        While sh.Cells(rmax, 1).Text <> ""
            rmax = rmax + 1
        End While
        rmax = rmax - 1
        ' 罫線を書く
        Dim rg = DirectCast(sh.Range("A1", sh.Cells(rmax, 3)), Excel.Range)
        rg.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        rg.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        rg.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        rg.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        rg.Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
        rg.Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
        rg.Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThick
        rg.Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThick
        rg.Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThick
        rg.Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThick
        rg.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlThin
        rg.Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = Excel.XlBorderWeight.xlThin
        ' 保存する
        wb.SaveAs("C:\VB2019\data\BookSave.xlsx")
        MessageBox.Show("保存しました")
        xapp.Quit()
    End Sub
End Class
