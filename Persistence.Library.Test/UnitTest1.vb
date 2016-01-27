Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Persistence.Library

<TestClass()> Public Class UnitTest1

    <TestInitialize()> Public Sub Setup()
        Config.SetConnectionString("Data Source=Test.db;Version=3;New=False;Compress=True;")
    End Sub

    <TestMethod()> Public Sub SimpleObjectSaveAndRetrive()
        Dim simpleObject As Child
        Dim simpleObjectGet As Child

        Dim firstNameTest As String = "Tommy"
        Dim lastNameTest As String = "Smith"
        Dim ageTest As Integer = 12

        simpleObject = New Child(firstNameTest, lastNameTest)
        simpleObject.Age = ageTest
        Assert.IsTrue(simpleObject.SaveData(), "Unable to save the object")

        simpleObjectGet = New Child(firstNameTest, lastNameTest)
        Assert.IsTrue(simpleObjectGet.FillData(), "Unable to fetch data for the object")

        Assert.AreEqual(simpleObject.FirstName, simpleObjectGet.FirstName, "FirstName value doesn't match")
        Assert.AreEqual(simpleObject.LastName, simpleObjectGet.LastName, "LastName value doesn't match")
        Assert.AreEqual(simpleObject.Age, simpleObjectGet.Age, "Age value doesn't match")
    End Sub

End Class