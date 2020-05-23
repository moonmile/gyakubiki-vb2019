Imports System.Text
Imports debug364
Imports Microsoft.VisualStudio.TestTools.UnitTesting


<TestClass()> Public Class UnitTest1
    Private _a = 0
    Private _b = 0
    <TestInitialize()> Public Sub init()
        ' テストを実行する前処理を記述する
        Me._a = 10
        Me._b = 10
    End Sub
    <TestMethod()> Public Sub 数値の加算()
        Dim t As New TargetClass()
        Dim ans = t.add(10, 20)
        Assert.AreEqual(30, ans)
    End Sub
End Class