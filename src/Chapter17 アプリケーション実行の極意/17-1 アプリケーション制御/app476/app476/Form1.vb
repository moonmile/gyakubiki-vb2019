Public Class Form1

    Private objMutex As System.Threading.Mutex

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 二重起動を防止する
        objMutex = New System.Threading.Mutex(False, "app463")
        If objMutex.WaitOne(0, False) = False Then
            MessageBox.Show("すでにアプリケーションが起動しています")
            Close()
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' フォームを閉じるときにミューテックスを解放する
        objMutex.Close()
    End Sub
End Class
