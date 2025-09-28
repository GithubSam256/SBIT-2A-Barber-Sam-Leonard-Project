Public Class dscode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weather As String = TextBox1.Text.Trim().ToLower()
        Dim advice As String = ""

        If weather = "very cold" Then
            advice = "Wear a heavy jacket."
        ElseIf weather = "chilly" Then
            advice = "Wear a light jacket."
        ElseIf weather = "windy" Then
            advice = "Wear a windbreaker."
        ElseIf weather = "hot" Then
            advice = "Wear no jacket."
        Else
            advice = "Please enter a valid weather condition (very cold, chilly, windy, hot)."
        End If

        ' Show the advice in a message box
        MessageBox.Show(advice, "Weather Advice")
    End Sub

End Class
