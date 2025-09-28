Public Class returningarraycode
    ' Function to get 4 names from user
    Private Function GetNames() As String()
        Const intMAX_SUBSCRIPT As Integer = 3 ' 0 to 3 = 4 names
        Dim strNames(intMAX_SUBSCRIPT) As String

        For intCount As Integer = 0 To intMAX_SUBSCRIPT
            strNames(intCount) = InputBox("Enter name " & (intCount + 1).ToString(), "Input Name")
        Next

        Return strNames
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call GetNames() function to collect names
        Dim strCustomers() As String = GetNames()

        ' Display all names in TextBox1
        TextBox1.Clear()
        For Each name As String In strCustomers
            TextBox1.AppendText(name & Environment.NewLine)
        Next
    End Sub

    Private Sub returningarraycode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
