Imports db304.db304

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        Dim SQL = "
select 
b.ID,
b.Title,
au.Name as 'Author'
from Book b
left outer join Author au on b.AuthorId = au.ID
"
        Dim items = ent.Database.SqlQuery(Of Result)(SQL).ToList()
        dg.ItemsSource = items

    End Sub

    Public Class Result
        Public Property ID As Integer
        Public Property Title As String
        Public Property Author As String
    End Class
End Class


