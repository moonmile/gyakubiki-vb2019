Imports System.Text
Imports debug361
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim t As New TargetClass()
        Try
            ' 例外を発生させる
            t.FireException()
        Catch ex As Exception
            ' 例外が発生したためテストは成功
            Assert.AreEqual("例外発生", ex.Message)
            Return
        End Try
        ' 例外が発生しない場合はテストは失敗
        Assert.Fail()
    End Sub

End Class