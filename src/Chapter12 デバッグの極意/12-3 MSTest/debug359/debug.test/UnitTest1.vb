Imports System.Text
Imports debug359
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim t As New TargetClass()
        Dim ans = t.add("マスダ", "トモアキ")
        Assert.AreEqual("マスダトモアキ", ans)
    End Sub

End Class