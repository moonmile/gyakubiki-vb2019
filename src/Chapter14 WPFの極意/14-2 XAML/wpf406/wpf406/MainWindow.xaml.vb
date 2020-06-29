Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim Rnd As New Random()
        For i = 0 To 100
            Dim rc As New Rectangle() With {
                .Stroke = New SolidColorBrush(Colors.Blue),
                .StrokeThickness = 2,
                .Width = 50,
                .Height = 50
            }
            Dim x = Rnd.Next(0, 300)
            Dim y = Rnd.Next(0, 300)

            Canvas.SetLeft(rc, x)
            Canvas.SetTop(rc, y)
            canv.Children.Add(rc)
        Next
    End Sub
End Class
