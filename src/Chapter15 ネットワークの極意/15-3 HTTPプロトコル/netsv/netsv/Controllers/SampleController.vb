Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class SampleController
        Inherits ApiController
        Public Function GetValue(ByVal id As Integer) As String
            Return $"GET ID is {id}"
        End Function

        <HttpPost>
        Public Function PostValue(<FromBody> ByVal name As String) As String
            Return $"POST name is {name}"
        End Function
    End Class

    Public Class Sample2Controller
        Inherits ApiController
        Public Function PostValue(
            <FromBody()> ByVal name As String,
            <FromBody()> ByVal age As Integer) As String
            name = name.ToUpper()
            age = age + 1
            Return <person>
                       <name>{name}</name>
                       <age>{age}</age>
                   </person>
        End Function
    End Class
End Namespace