Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class FinalContainer

    Private Sub FinalContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDesign()
        AssignForms()
    End Sub

    Private Sub LoadDesign()
        Card7.UpdateInfo("OOP",
                 "Working with collections, arrays, and lists in OOP programs.",
                 "Midterm",
                 "Week 7",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card8.UpdateInfo("00P",
                 "Creating small OOP projects to combine learned concepts and prepare for assessments.",
                 "Midterm",
                 "Week 8",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        ' Final Term starts
        Card9.UpdateInfo("OOP",
                 "Advanced error handling and exception management in VB.NET OOP projects.",
                 "Final Term",
                 "Week 9",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card10.UpdateInfo("OOP",
                 "Exploring file handling techniques and integrating them with OOP concepts.",
                 "Final Term",
                 "Week 10",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card11.UpdateInfo("OOP",
                 "Building graphical user interfaces using forms and controls in OOP style.",
                 "Final Term",
                 "Week 11",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card12.UpdateInfo("OOP",
                 "Implementing database connections and CRUD operations with OOP practices.",
                 "Final Term",
                 "Week 12",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

    End Sub


    Private Sub AssignForms()
        Card7.AssignTopic(GetType(Week7Topic))
        Card8.AssignTopic(GetType(Week8Topic))
    End Sub


End Class
