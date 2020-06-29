Imports System.Text
Imports debug358
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim t As New TargetClass()
        Dim ans = t.add(10, 20)
        Assert.AreEqual(30, ans)
    End Sub

    <TestMethod()> Public Sub NULLチェック()

    End Sub
    <TestMethod()> Public Sub 数値の加算()

    End Sub
    <TestMethod()> Public Sub 文字列の結合()

    End Sub
End Class