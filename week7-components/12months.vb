Public Class _12months
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Array of months
        Dim months() As String = {"January", "February", "March", "April", "May", "June",
                                  "July", "August", "September", "October", "November", "December"}

        ' Get user input
        Dim inputNumber As Integer

        ' Validate input
        If Integer.TryParse(TextBox1.Text, inputNumber) Then
            If inputNumber >= 1 AndAlso inputNumber <= 12 Then
                TextBox2.Text = "Month " & inputNumber & " is " & months(inputNumber - 1)
            Else
                TextBox2.Text = "Please enter a number between 1 and 12"
            End If
        Else
            TextBox2.Text = "Invalid input. Enter a number."
        End If
    End Sub
End Class
