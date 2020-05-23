Class MainWindow
    Private Sub clickLarge(sender As Object, e As RoutedEventArgs)
        text.FontSize = 20
    End Sub

    Private Sub clickMiddle(sender As Object, e As RoutedEventArgs)
        text.FontSize = 12
    End Sub

    Private Sub clickSmall(sender As Object, e As RoutedEventArgs)
        text.FontSize = 9
    End Sub
End Class
