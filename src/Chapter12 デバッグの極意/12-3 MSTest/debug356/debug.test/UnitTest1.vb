Imports System.Text
Imports debug356
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim t = New TargetClass()
        Assert.AreEqual(30, t.add(10, 20))
    End Sub

End Class