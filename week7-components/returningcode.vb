Public Class returningcode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare an array with 2 elements: index 0 for first name, index 1 for last name
        Dim names(1) As String

        ' Assign values from textboxes into the array
        names(0) = TextBox1.Text.Trim() ' First name
        names(1) = TextBox2.Text.Trim() ' Last name

        ' Use the array to display result
        TextBox3.Text = "My name is " & names(0) & " " & names(1)
    End Sub

    Private Sub returningcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
