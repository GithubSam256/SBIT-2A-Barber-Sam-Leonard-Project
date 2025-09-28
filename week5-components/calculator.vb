Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class calculator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim exp As Double
        Dim result As Double = 0
        Dim explanation As String = ""
        ' Check first number
        If Not Double.TryParse(TextBox1.Text, num1) Then
            MessageBox.Show("Please enter a valid number in the first textbox.")
            Exit Sub
        End If
        ' Square Root only needs one number
        If RadioButton8.Checked = False Then
            If Not Double.TryParse(TextBox2.Text, num2) Then
                MessageBox.Show("Please enter a valid number in the second textbox.")
                Exit Sub
            End If
        End If
        ' Exponentiation
        If RadioButton5.Checked Then
            exp = num2 ' Here, TextBox2 is used for Power instead of a separate textbox
            result = Math.Pow(num1, exp)
            explanation = $"Base number is {num1} raised to the power of {exp}, therefore the answer is {result}."
        ElseIf RadioButton1.Checked Then ' Addition
            result = num1 + num2
            explanation = $"First number is {num1} added to second number {num2}, therefore the answer is {result}."
        ElseIf RadioButton2.Checked Then ' Subtraction
            result = num1 - num2
            explanation = $"First number is {num1} minus second number {num2}, therefore the answer is {result}."
        ElseIf RadioButton3.Checked Then ' Multiplication
            result = num1 * num2
            explanation = $"First number is {num1} multiplied by second number {num2}, therefore the answer is {result}."
        ElseIf RadioButton4.Checked Then ' Division
            If num2 = 0 Then
                MessageBox.Show("Division by zero is not allowed.")
                Exit Sub
            End If
            result = num1 / num2
            explanation = $"First number is {num1} divided by second number {num2}, therefore the answer is {result}."
        ElseIf RadioButton6.Checked Then ' Integer Division
            If num2 = 0 Then
                MessageBox.Show("Division by zero is not allowed.")
                Exit Sub
            End If
            result = num1 \ num2
            explanation = $"First number is {num1} integer-divided by second number {num2}, therefore the answer is {result}."
        ElseIf RadioButton7.Checked Then ' Modulus Division
            If num2 = 0 Then
                MessageBox.Show("Division by zero is not allowed.")
                Exit Sub
            End If
            result = num1 Mod num2
            explanation = $"First number is {num1} modulus-divided by second number {num2}, therefore the remainder is {result}."
        ElseIf RadioButton8.Checked Then ' Square Root
            If num1 < 0 Then
                MessageBox.Show("Square root of negative number is not allowed.")
                Exit Sub
            End If
            result = Math.Sqrt(num1)
            explanation = $"The square root of first number {num1} is {result}."
        Else
            MessageBox.Show("Please select an operator.")
            Exit Sub
        End If
        ' Show result in Result textbox (TextBox3)
        TextBox3.Text = result.ToString()
        ' Show explanation in TextBox5
        TextBox5.Text = explanation
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default labels
        Label1.Text = "First Number"
        Label2.Text = "Second Number"
    End Sub
    ' When Exponentiation is selected
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            ' Update labels for clarity
            Label1.Text = "Base"
            Label2.Text = "Power"
        End If
    End Sub
    ' For other operators (Addition, Subtraction, etc.)
    Private Sub Operators_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged,
                RadioButton3.CheckedChanged, RadioButton4.CheckedChanged,
                RadioButton6.CheckedChanged, RadioButton7.CheckedChanged,
                RadioButton8.CheckedChanged
        ' Reset labels back to default when switching away from exponentiation
        If Not RadioButton5.Checked Then
            Label1.Text = "First Number"
            Label2.Text = "Second Number"
        End If
    End Sub
End Class
