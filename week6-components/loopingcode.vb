Public Class loopingcode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear previous items
        ListBox1.Items.Clear()

        Dim intCount As Integer = 0
        Do While intCount < 10
            ListBox1.Items.Add("Hello")
            intCount += 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear previous items
        ListBox2.Items.Clear()

        For intCount As Integer = 1 To 10
            ListBox2.Items.Add("Hello")
        Next
    End Sub

End Class
