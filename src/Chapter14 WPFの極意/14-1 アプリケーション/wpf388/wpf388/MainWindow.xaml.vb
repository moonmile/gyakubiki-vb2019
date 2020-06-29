Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim s = ""
        If chk1.IsChecked.Value Then s += "国語, "
        If chk2.IsChecked.Value Then s += "算数, "
        If chk3.IsChecked.Value Then s += "理科, "
        If chk4.IsChecked.Value Then s += "社会, "
        If chk5.IsChecked.Value Then s += "プログラミング, "
        text.Text = s

    End Sub
End Class
