Imports System.Text
Imports debug362
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub 数値の加算()
        Dim t As New TargetClass()
        Dim ans = t.add(10, 20)
        Assert.AreEqual(30, ans)
    End Sub

    <TestMethod()> Public Sub 文字列の結合()
        Dim t As New TargetClass()
        Dim ans = t.add("マスダ", "トモアキ")
        Assert.AreEqual("マスダトモアキ", ans)
    End Sub

    <TestMethod()> Public Sub NULLチェック()
        Dim t As New TargetClass()
        Dim obj = t.CreatePointer(10, 20)
        Assert.IsNotNull(obj)
        Assert.AreEqual(10, obj.X)
        Assert.AreEqual(20, obj.Y)
    End Sub

End Class