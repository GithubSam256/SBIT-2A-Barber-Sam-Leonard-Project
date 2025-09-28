Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class testinginputcode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputValue As String = TextBox1.Text

        ' Check if empty
        If inputValue = String.Empty Then
            MessageBox.Show("Please enter a value", "Input Required")
            Exit Sub
        End If

        ' Check if input is numeric
        If IsNumeric(inputValue) Then
            TextBox2.Text = "Numeric"
        Else
            TextBox2.Text = "Not Numeric"
        End If

        ' Show uppercase
        TextBox3.Text = inputValue.ToUpper()

        ' Show lowercase
        TextBox4.Text = inputValue.ToLower()

        ' Show string length
        TextBox5.Text = inputValue.Length.ToString()

        ' Show TrimStart with quotes
        Label9.Text = """" & inputValue.TrimStart() & """"

        ' Show TrimEnd with quotes and force visible spaces
        Label10.Text = New String(" "c, 20) & """" & inputValue.TrimEnd() & """"

        ' Show Trim (both sides) with quotes
        Label11.Text = """" & inputValue.Trim() & """"
    End Sub

End Class
