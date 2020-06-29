''' <summary>
''' テスト対象のクラス
''' </summary>
Public Class TargetClass
    ''' <summary>
    ''' 足し算
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Function add(a As Integer, b As Integer) As Integer
        Return a + b
    End Function
    ''' <summary>
    ''' 文字列の連結
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Function add(a As String, b As String) As String
        Return a + b
    End Function

    Public Function CreatePointer(x As Integer, y As Integer) As XY
        If x < 0 And y < 0 Then
            Return Nothing
        Else
            Return New XY() With {.X = x, .Y = y}
        End If
    End Function

    Public Sub FireException()
        Throw New Exception("例外発生")
    End Sub
End Class

Public Class XY
    Public Property X As Integer
    Public Property Y As Integer
End Class
