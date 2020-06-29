Class MainWindow
    Private Sub clickLogin(sender As Object, e As RoutedEventArgs)
        Dim loginName = login.Text
        Dim passwd = pass.Password
        MessageBox.Show($"{loginName}" + vbCrLf + $"{passwd}")
    End Sub
End Class
