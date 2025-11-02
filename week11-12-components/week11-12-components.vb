Public Class week11_12_components

    Public Event showgifclicked(control As UserControl)


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent showgifclicked(New frw)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent showgifclicked(New frw1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RaiseEvent showgifclicked(New frw2)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RaiseEvent showgifclicked(New frw3)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RaiseEvent showgifclicked(New frw4)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RaiseEvent showgifclicked(New example)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        RaiseEvent showgifclicked(New example1)
    End Sub
End Class
