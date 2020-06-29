Class MainWindow
    Private Sub clickAdd(sender As Object, e As RoutedEventArgs)
        Dim s = text.Text
        If Not String.IsNullOrEmpty(s) Then
            lst.Items.Add(s)
        End If
    End Sub
End Class
