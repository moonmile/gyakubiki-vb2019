Imports System.Text
Imports debug365
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    Private _path = "c:\VB2019\test.txt"

    <TestInitialize()> Public Sub init()
        ' テストを実行する前処理を記述する
        Dim sw = System.IO.File.CreateText(_path)
        sw.Write("10,20")
        sw.Close()
    End Sub
    <TestInitialize()> Public Sub post()
        ' テスト終了時の処理
        System.IO.File.Delete(_path)
    End Sub

    <TestMethod()> Public Sub 数値の加算()
        Dim Text = System.IO.File.ReadAllText(_path)
        Dim lst = Text.Split(",")
        Dim a = Integer.Parse(lst(0))
        Dim b = Integer.Parse(lst(1))
        Assert.AreEqual(10, a)
        Assert.AreEqual(20, b)
    End Sub
End Class
