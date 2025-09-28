Public Class rocode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sales As Double

        ' Check if user entered a valid number
        If Double.TryParse(TextBox1.Text, sales) Then
            ' Example rules (you can adjust as needed)
            If sales >= 50000 Then
                Label2.Text = "Commission Rate: 20%"
                Label3.Text = "Days Off: 5"
                MessageBox.Show("Congratulations! You've earned a bonus!", "Bonus Awarded")
            ElseIf sales >= 30000 Then
                Label2.Text = "Commission Rate: 10%"
                Label3.Text = "Days Off: 3"
                MessageBox.Show("No bonus, keep working hard!", "Keep Going")
            ElseIf sales >= 10000 Then
                Label2.Text = "Commission Rate: 5%"
                Label3.Text = "Days Off: 1"
                MessageBox.Show("No bonus, keep working hard!", "Keep Going")
            Else
                Label2.Text = "Commission Rate: 0%"
                Label3.Text = "Days Off: 0"
                MessageBox.Show("No bonus, keep working hard!", "Keep Going")
            End If
        Else
            ' If invalid input, reset labels
            Label2.Text = "Commission Rate: 0%"
            Label3.Text = "Days Off: 0"
            MessageBox.Show("Please enter a valid number for sales.", "Invalid Input")
        End If
    End Sub

End Class
