﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Index2() As ActionResult
        Dim items = New List(Of MyModel)({
            New MyModel With {.ID = 1, .Title = "逆引き大全VB", .Price = 1000},
            New MyModel With {.ID = 2, .Title = "逆引き大全C#", .Price = 2000},
            New MyModel With {.ID = 3, .Title = "逆引き大全F#", .Price = 3000},
            New MyModel With {.ID = 3, .Title = ".NETリファレンス", .Price = 5000}
            })
        Return View(items)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
