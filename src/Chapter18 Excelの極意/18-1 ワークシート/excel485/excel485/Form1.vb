Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\Book1.xlsx")
        label1.Text = wb.Name
        xapp.Quit()
    End Sub
End Class
