Public Class classandobjectcode
    Public Class Person
        Public Name As String
        Public Age As Integer
    End Class

    Dim people As New List(Of Person)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New Person()
        p.Name = TextBox1.Text
        p.Age = TextBox2.Text

        people.Add(p)

        ListBox1.Items.Add(" Hello, I'm " & p.Name & " and I'm " & p.Age & " years old ")
    End Sub

End Class
