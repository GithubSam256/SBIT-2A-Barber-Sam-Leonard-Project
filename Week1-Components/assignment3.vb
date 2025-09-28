Public Class assignment3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get input values from TextBox1 and TextBox2
        Dim num1 As Integer
        Dim num2 As Integer

        ' Try to parse the inputs safely
        If Integer.TryParse(TextBox1.Text, num1) AndAlso Integer.TryParse(TextBox2.Text, num2) Then

            ' Perform calculations
            Dim sum = num1 + num2
            Dim difference = num1 - num2
            Dim product = num1 * num2

            Dim quotient As String
            If num2 <> 0 Then
                quotient = (num1 / num2).ToString
            Else
                quotient = "Undefined (Divide by 0)"
            End If

            ' Display results in labels
            Label3.Text = "Sum: " & sum.ToString
            Label4.Text = "Difference: " & difference.ToString
            Label5.Text = "Product: " & product.ToString
            Label6.Text = "Quotient: " & quotient

        Else
            MessageBox.Show("Please enter valid integers in both textboxes.")
        End If
    End Sub

    ' Second program: Employee Salary Calculator
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hoursWorked As Integer
        Dim hourlyRate As Integer = 128
        Dim total, afterTax As Double

        ' Validate input from TextBox3
        If Integer.TryParse(TextBox3.Text, hoursWorked) Then
            total = hoursWorked * hourlyRate
            afterTax = total * 0.9 ' Apply 10% tax

            ' Show result in Label10
            Label10.Text = "Taxed Salary: " & afterTax.ToString("N2") & " PHP"
        Else
            MessageBox.Show("Please enter a valid number of hours worked.")
        End If
    End Sub

    ' Third program: Circle Calculator
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim radius As Double

        ' Validate input from TextBox4
        If Double.TryParse(TextBox4.Text, radius) Then
            Dim diameter As Double = 2 * radius
            Dim circumference As Double = 2 * Math.PI * radius
            Dim area As Double = Math.PI * radius * radius

            ' Show results in labels
            Label12.Text = "Diameter: " & diameter.ToString("F2")
            Label13.Text = "Circumference: " & circumference.ToString("F2")
            Label14.Text = "Area: " & area.ToString("F2")
        Else
            MessageBox.Show("Please enter a valid radius.")
        End If
    End Sub

    Private Sub assignment3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
