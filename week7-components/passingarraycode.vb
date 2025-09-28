Public Class passingarraycode

    ' Procedure to display the sum of elements in the array
    Private Sub DisplaySum(ByVal intArray() As Integer, ByVal outputBox As TextBox)
        Dim intTotal As Integer = 0 ' Accumulator

        ' Loop through array elements
        For intCount As Integer = 0 To intArray.Length - 1
            intTotal += intArray(intCount)
        Next

        ' Show result in the given textbox
        outputBox.Text = "The total is " & intTotal.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare and initialize array
        Dim intNumbers() As Integer = {2, 4, 7, 9, 8, 12, 10}

        ' Call the procedure and pass array + textbox1
        DisplaySum(intNumbers, TextBox1)
    End Sub

    Private Sub passingarraycode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
