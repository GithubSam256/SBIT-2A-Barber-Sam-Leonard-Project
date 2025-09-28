Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub HomeContainer1_Load(sender As Object, e As EventArgs)

    End Sub
    Public Sub SetRoundedBorder(ctrl As Control, radius As Integer)
        Dim rect As New Rectangle(0, 0, ctrl.Width, ctrl.Height)
        Dim path As New GraphicsPath()

        ' Top-left arc
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        ' Top-right arc
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        ' Bottom-right arc
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        ' Bottom-left arc
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Apply the rounded region to the control
        ctrl.Region = New Region(path)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetRoundedBorder(Me, 20)
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub MidtermButton_Click(sender As Object, e As EventArgs) Handles MidtermButton.Click
        ScrollToSection(ScrollPanel, Section2, 80)
    End Sub

    Private Sub FinalTermButton_Click(sender As Object, e As EventArgs) Handles FinalTermButtom.Click
        ScrollToSection(ScrollPanel, Section3, 80)
    End Sub

    Private Sub BackHome_Click(sender As Object, e As EventArgs) Handles BackHome.Click
        ScrollToSection(ScrollPanel, Section1, 150)
    End Sub

    Private Sub aboutmebutton1_Click(sender As Object, e As EventArgs) Handles aboutmebutton1.Click
        Aboutme1.Show()
    End Sub

    Private Sub vision_Click(sender As Object, e As EventArgs) Handles vision.Click
        visionf1.Show()
    End Sub

    Private Sub mission_Click(sender As Object, e As EventArgs) Handles mission.Click
        missionf1.Show()
    End Sub

End Class
