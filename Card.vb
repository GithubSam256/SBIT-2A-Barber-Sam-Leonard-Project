Imports System.Drawing.Drawing2D

Public Class Card
    Public Sub UpdateInfo(weekText As String, descriptionText As String, statusText As String, imageLabels As String, imagePath As String)
        WeekLabel.Text = weekText
        DescriptionLabel.Text = descriptionText
        StatusLabel.Text = statusText
        ImageLabel.Text = imageLabels

        ' If ImageContainer is a Panel, set its background image
        If IO.File.Exists(imagePath) Then
            ImageContainer.BackgroundImage = Image.FromFile(imagePath)
            ImageContainer.BackgroundImageLayout = ImageLayout.Stretch
        Else
            ImageContainer.BackgroundImage = Nothing
        End If
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

    Private Sub Card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetRoundedBorder(Me, 20)
        SetRoundedBorder(ImageContainer, 10)
        SetRoundedBorder(StatusLabel, 8)
        AddClickEvent(Me)
    End Sub

    ' Store the type of form to open
    Private TopicFormType As Type

    ' Function to assign a topic/form to this card
    Public Sub AssignTopic(formType As Type)
        TopicFormType = formType
    End Sub

    Private Sub Card_Click(sender As Object, e As EventArgs) Handles Me.Click
        If TopicFormType IsNot Nothing Then
            ' Create and show the form dynamically
            Dim frm As Form = CType(Activator.CreateInstance(TopicFormType), Form)
            frm.Show()
        Else
            MessageBox.Show("No topic assigned to this card.")
        End If
    End Sub


    ' Assign click to all child controls recursively
    Private Sub AddClickEvent(ctrl As Control)
        AddHandler ctrl.Click, AddressOf Card_Click
        For Each c As Control In ctrl.Controls
            AddClickEvent(c)
        Next
    End Sub

End Class

