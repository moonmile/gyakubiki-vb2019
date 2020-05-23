Imports Microsoft.Office.Interop

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\Book2.xlsx")
        listBox1.Items.Clear()
        For Each sh As Excel.Worksheet In wb.Sheets
            listBox1.Items.Add(sh.Name)
        Next
        xapp.Quit()
    End Sub
End Class
