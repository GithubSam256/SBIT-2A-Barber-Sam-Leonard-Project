Public Class implicitcode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare and initialize the array with values
        Dim intHours() As Integer = {2, 4, 6, 8, 10, 12}

        ' Clear ListBox before adding items
        ListBox1.Items.Clear()

        ' Loop through array and display index/value
        For i As Integer = 0 To intHours.Length - 1
            ListBox1.Items.Add("intHours(" & i & ") = " & intHours(i))
        Next
    End Sub
End Class
