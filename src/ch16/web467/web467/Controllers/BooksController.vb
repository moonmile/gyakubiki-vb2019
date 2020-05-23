Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class BooksController
        Inherits ApiController

        Private _lst As List(Of Book)
        Public Sub New()
            _lst = New List(Of Book)({
            New Book With {.Title = "逆引き大全VB", .Price = 1000, .Pages = 300},
            New Book With {.Title = "逆引き大全C#", .Price = 2000, .Pages = 300},
            New Book With {.Title = "逆引き大全F#", .Price = 3000, .Pages = 300},
            New Book With {.Title = "リファレンス本", .Price = 5000, .Pages = 300}
        })
        End Sub

        ' GET: api/Books
        Public Function GetValues() As IEnumerable(Of Book)
            Return _lst
        End Function

        ' GET: api/Books/5
        Public Function GetValue(ByVal id As Integer) As Book
            Return _lst.FirstOrDefault(Function(x) x.ID = id)
        End Function

        ' POST: api/Books
        Public Function PostValue(<FromBody()> ByVal value As Book)
            Return String.Format("post Title:{0}", value.Title)
        End Function

        ' PUT: api/Books/5
        Public Function PutValue(ByVal id As Integer, <FromBody()> ByVal value As Book)
            Return String.Format("put Title:{0}", value.Title)
        End Function

        ' DELETE: api/Books/5
        Public Function DeleteValue(ByVal id As Integer)
            Return String.Format("delete ID:{0}", id)
        End Function
    End Class
End Namespace