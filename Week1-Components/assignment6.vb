Public Class assignment6
    ' 1. Display numbers 1 to 1000
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For x As Integer = 1 To 1000
            ListBox1.Items.Add(x.ToString())
        Next
    End Sub

    ' 2. Display numbers 1000 to 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        For x As Integer = 1000 To 0 Step -1
            ListBox1.Items.Add(x.ToString())
        Next
    End Sub

    ' 3. Display odd numbers from 1 to 1000
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        For x As Integer = 1 To 1000 Step 2
            ListBox1.Items.Add(x.ToString())
        Next
    End Sub

    ' 4. Display all even numbers from 1 to 1000
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        For x As Integer = 2 To 1000 Step 2
            ListBox1.Items.Add(x.ToString())
        Next
    End Sub

    ' 5. Display all numbers divisible by 6 from 1 to 1000
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        For x As Integer = 6 To 1000 Step 6
            ListBox1.Items.Add(x.ToString())
        Next
    End Sub

End Class
