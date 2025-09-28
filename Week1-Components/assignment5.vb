Public Class assignment5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare variables
        Dim fn, ln As String

        ' Get input values from textboxes
        fn = TextBox1.Text
        ln = TextBox2.Text

        ' Display full name in Label3
        Label3.Text = "Full Name: [ " & fn & " " & ln & " ]"
    End Sub

    ' Second program: no variables
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Directly use TextBox3 and TextBox4 without variables
        Label6.Text = "Welcome " & TextBox4.Text & " " & TextBox3.Text
    End Sub

    Private Sub assignment5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
