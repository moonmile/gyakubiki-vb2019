Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim s = ""
        If rb1.IsChecked.Value Then s = "国語"
        If rb2.IsChecked.Value Then s = "算数"
        If rb3.IsChecked.Value Then s = "理科"
        If rb4.IsChecked.Value Then s = "社会"
        If rb5.IsChecked.Value Then s = "プログラミング"
        text.Text = s
    End Sub
End Class
