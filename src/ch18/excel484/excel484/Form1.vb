Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        xapp.Quit()
    End Sub
End Class
