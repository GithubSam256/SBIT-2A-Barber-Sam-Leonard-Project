Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class MidContainer
    Private Sub MidContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDesign()
        AssignForms()
    End Sub

    Private Sub LoadDesign()

        Card1.UpdateInfo("OOP",
                 "Introduction to Object-Oriented Programming (OOP) concepts and understanding classes and objects.",
                 "Midterm",
                 "Assignments",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card2.UpdateInfo("OOP",
                 "Learning properties, methods, and fields in VB.NET with practical examples.",
                 "Midterm",
                 "Week 2",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card3.UpdateInfo("OOP",
                 "Understanding encapsulation and access modifiers to secure data in classes.",
                 "Midterm",
                 "Week 3",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card4.UpdateInfo("OOP",
                 "Exploring inheritance to create reusable and extendable class hierarchies.",
                 "Midterm",
                 "Week 4",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card5.UpdateInfo("OOP",
                 "Implementing polymorphism with method overriding and interfaces.",
                 "Midterm",
                 "Week 5",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card6.UpdateInfo("OOP",
                 "Learning about constructors, destructors, and object lifecycle management.",
                 "Midterm",
                 "Week 6",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

    End Sub

    Private Sub AssignForms()
        Card1.AssignTopic(GetType(Week1Topic))
        Card2.AssignTopic(GetType(Week2Topic))
        Card3.AssignTopic(GetType(Week3Topic))
        Card4.AssignTopic(GetType(Week4Topic))
        Card5.AssignTopic(GetType(Week5Topic))
        Card6.AssignTopic(GetType(Week6Topic))
    End Sub


End Class
