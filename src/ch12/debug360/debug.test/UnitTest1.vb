Imports System.Text
Imports debug360
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim t As New TargetClass()
        Dim obj = t.CreatePointer(-1, -1)
        Assert.IsNull(obj)
        obj = t.CreatePointer(10, 20)
        Assert.IsNotNull(obj)
        Assert.AreEqual(10, obj.X)
        Assert.AreEqual(20, obj.Y)
    End Sub

End Class