Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If cb1.SelectedIndex <> -1 Then
            Dim s = DirectCast(cb1.SelectedItem, ComboBoxItem)
            text1.Text = s.Content.ToString()
        End If
    End Sub
End Class
