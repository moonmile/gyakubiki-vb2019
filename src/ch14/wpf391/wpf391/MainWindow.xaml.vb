Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If lst.SelectedIndex <> -1 Then
            Dim s = DirectCast(lst.SelectedItem, ListBoxItem)
            text1.Text = s.Content.ToString()
        End If
    End Sub
End Class
