Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2019\data\Book2.xlsx")
        Dim sh = DirectCast(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
        Dim r = 2
        Dim items = New List(Of Data)()
        While sh.Cells(r, 1).Text <> ""
            Dim Data As New Data() With {
                .ID = sh.Cells(r, 1).Value,
                .Title = sh.Cells(r, 2).Value,
                .Price = sh.Cells(r, 3).Value
            }
            items.Add(Data)
            r = r + 1
        End While
        dataGridView1.DataSource = items
        xapp.Quit()
    End Sub
End Class

Public Class Data
    Public Property ID As Integer
    Public Property Title As String
    Public Property Price As Integer
End Class