Public Class logicalcode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input1 As String = TextBox1.Text.Trim().ToUpper()
        Dim input2 As String = TextBox2.Text.Trim().ToUpper()
        Dim result As Boolean
        ' Validate inputs: must be T or F
        If (input1 <> "T" And input1 <> "F") OrElse
           ((Not RadioButton4.Checked) AndAlso (input2 <> "T" And input2 <> "F")) Then
            MessageBox.Show("Please enter only T or F in the input boxes.")
            Exit Sub
        End If
        ' Convert inputs to Boolean
        Dim val1 As Boolean = (input1 = "T")
        Dim val2 As Boolean = (input2 = "T")

        ' Check which operator is selected
        If RadioButton1.Checked Then
            ' AND
            result = val1 And val2
        ElseIf RadioButton2.Checked Then
            ' OR
            result = val1 Or val2
        ElseIf RadioButton3.Checked Then
            ' XOR
            result = val1 Xor val2
        ElseIf RadioButton4.Checked Then
            ' NOT (only uses input1)
            result = Not val1
        Else
            MessageBox.Show("Please select an operator.")
            Exit Sub
        End If
        ' Show result in TextBox3 as T or F
        TextBox3.Text = If(result, "T", "F")
    End Sub
End Class
