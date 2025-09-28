Public Class threedcode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 3D Array: Student, Subject, Grade
        Dim students(,,) As String = {
            {{"Sam", "Math", "95"}, {"Sam", "Science", "90"}},
            {{"Steph", "Math", "92"}, {"Steph", "Science", "88"}},
            {{"Kevin", "Math", "85"}, {"Kevin", "Science", "80"}},
            {{"James", "Math", "78"}, {"James", "Science", "82"}}
        }

        Dim inputName As String = TextBox1.Text.Trim()
        Dim result As String = ""
        Dim found As Boolean = False

        ' Loop through the 3D array
        For i As Integer = 0 To students.GetLength(0) - 1
            For j As Integer = 0 To students.GetLength(1) - 1
                If String.Equals(students(i, j, 0), inputName, StringComparison.OrdinalIgnoreCase) Then
                    result &= students(i, j, 0) & " - " & students(i, j, 1) & ": " & students(i, j, 2) & Environment.NewLine
                    found = True
                End If
            Next
        Next

        ' Show result
        If found Then
            TextBox2.Text = result.Trim()
        Else
            TextBox2.Text = "Name not found. Please enter Sam, Steph, Kevin, or James."
        End If
    End Sub
End Class
