Class MainWindow
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded,
            Sub(s, e)
                Me.DataContext = New ViewModel()
            End Sub
    End Sub
End Class
