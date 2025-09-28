Public Class twodcode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 2D Array of names and grades
        Dim students(,) As String = {
            {"Sam", "95"},
            {"Steph", "90"},
            {"Kevin", "85"},
            {"James", "80"}
        }

        Dim inputName As String = TextBox1.Text.Trim()
        Dim found As Boolean = False

        ' Loop through array
        For i As Integer = 0 To students.GetLength(0) - 1
            If String.Equals(students(i, 0), inputName, StringComparison.OrdinalIgnoreCase) Then
                TextBox2.Text = students(i, 0) & " has grade of " & students(i, 1)
                found = True
                Exit For
            End If
        Next

        ' If no match found
        If Not found Then
            TextBox2.Text = "Name not found. Please enter Sam, Steph, Kevin, or James."
        End If
    End Sub

    Private Sub twodcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
