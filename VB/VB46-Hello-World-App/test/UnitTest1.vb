Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VB46_Hello_World_App

<TestClass()> Public Class UnitTest1
    Private _calculate As Calculate = New Calculate

    <TestMethod()> Public Sub PassingTest()

        Assert.AreEqual(4, _calculate.Add(2, 2))
    End Sub

    <TestMethod()> Public Sub FailingTest()

        Assert.AreNotEqual(5, _calculate.Add(2, 2))
    End Sub

    <TestMethod()> Public Sub Test1()

    End Sub

End Class