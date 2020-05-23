Class MainWindow
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded,
            Sub(s, e)
                _vm = New ViewModel With {
                    .ID = 1,
                    .Name = "masuda",
                    .Age = 52,
                    .Address = "板橋区"
                }
                Me.DataContext = _vm
            End Sub
    End Sub
    Private _vm As ViewModel

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        _vm.Message = $"{_vm.Name} さん、登録をありがとうございます"
    End Sub
End Class
