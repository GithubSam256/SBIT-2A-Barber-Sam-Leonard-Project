Public Class declaringcode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare an array of 7 elements (0 to 6)
        Dim intHours(6) As Integer

        ' Clear the ListBox before adding items
        ListBox1.Items.Clear()

        ' Loop through the array and show index/value
        For i As Integer = 0 To intHours.Length - 1
            ListBox1.Items.Add("intHours(" & i & ") = " & intHours(i))
        Next
    End Sub
End Class

