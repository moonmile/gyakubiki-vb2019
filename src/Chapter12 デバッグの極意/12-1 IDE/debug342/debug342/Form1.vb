Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim pa As New Person With {
            .Name = "増田智明",
            .Age = 52,
            .City = "板橋区"
        }
        pa.xml = <person>
                     <Name>増田智明</Name>
                     <Age>52</Age>
                     <City>板橋区</City>
                 </person>
        textBox1.Text = pa.xml.ToString()
    End Sub
End Class

Public Class Person
    Public Property Name As String
    Public Property Age As Integer
    Public Property City As String
    Public Property xml As XElement
End Class

