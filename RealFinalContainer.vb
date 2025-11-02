Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class RealFinalContainer
    Private Sub MidContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDesign()
    End Sub

    Private Sub LoadDesign()

        Card7.UpdateInfo("OOP",
                 "Using events and delegates to handle dynamic user interactions in OOP programs.",
                 "Final Term",
                 "Week 14",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card8.UpdateInfo("OOP",
                 "Applying design patterns like Singleton and Factory in VB.NET projects.",
                 "Final Term",
                 "Week 15",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card9.UpdateInfo("OOP",
                 "Integrating external libraries and APIs to enhance object-oriented applications.",
                 "Final Term",
                 "Week 16",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card10.UpdateInfo("OOP",
                 "Final project showcase: Combining all OOP concepts into a functional VB.NET application.",
                 "Final Term",
                 "Week 17",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card11.UpdateInfo("OOP",
                 "Reviewing all key OOP concepts and preparing for final evaluations with practice exercises.",
                 "Final Term",
                 "Week 18",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

        Card12.UpdateInfo("OOP",
                 "Submission and presentation of final projects demonstrating mastery of VB.NET OOP principles.",
                 "Final Term",
                 "Week ",
                 "C:\Users\Administrator\Downloads\images\week-image.jpg")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
