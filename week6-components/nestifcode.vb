Public Class nestifcode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblSalary As Double
        Dim intYearsOnJob As Integer

        ' Validate inputs
        If Not Double.TryParse(TextBox1.Text, dblSalary) Then
            MessageBox.Show("Please enter a valid number for Salary.", "Invalid Input")
            Exit Sub
        End If

        If Not Integer.TryParse(TextBox2.Text, intYearsOnJob) Then
            MessageBox.Show("Please enter a valid number for Years on Job.", "Invalid Input")
            Exit Sub
        End If

        ' Nested If logic
        If dblSalary > 30000 Then
            If intYearsOnJob > 2 Then
                Label3.Text = "Applicant qualifies."
            Else
                Label3.Text = "Applicant does not qualify."
            End If
        Else
            If intYearsOnJob > 5 Then
                Label3.Text = "Applicant qualifies."
            Else
                Label3.Text = "Applicant does not qualify."
            End If
        End If
    End Sub


End Class
