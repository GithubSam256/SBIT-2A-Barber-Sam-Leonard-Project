Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class selectcode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dayNumber As Integer
        ' Validate input
        If Not Integer.TryParse(TextBox1.Text, dayNumber) Then
            Label2.Text = "Please enter a valid number."
            Exit Sub
        End If
        ' Select Case logic
        Select Case dayNumber
            Case 1
                Label2.Text = "Day 1 is Monday."
            Case 2
                Label2.Text = "Day 2 is Tuesday."
            Case 3
                Label2.Text = "Day 3 is Wednesday."
            Case 4
                Label2.Text = "Day 4 is Thursday."
            Case 5
                Label2.Text = "Day 5 is Friday."
            Case 6
                Label2.Text = "Day 6 is Saturday."
            Case 7
                Label2.Text = "Day 7 is Sunday."
            Case Else
                Label2.Text = "That value is invalid."
        End Select
    End Sub
End Class
