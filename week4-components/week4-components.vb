Public Class week4_components

    Public Event showgifclicked(control As UserControl)
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent showgifclicked(New handlingdata())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RaiseEvent showgifclicked(New cp())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RaiseEvent showgifclicked(New cm())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RaiseEvent showgifclicked(New ce())
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RaiseEvent showgifclicked(New bc())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RaiseEvent showgifclicked(New af)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RaiseEvent showgifclicked(New fp)
        Panel1.Visible = Not Panel1.Visible
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New startp)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent showgifclicked(New hd)
        Panel2.Visible = Not Panel2.Visible
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RaiseEvent showgifclicked(New ad2)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New sew)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New properties)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New fp2)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button22.Click
        RaiseEvent showgifclicked(New bpictures)
        Panel3.Visible = Not Panel3.Visible
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RaiseEvent showgifclicked(New stip)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        RaiseEvent showgifclicked(New ad)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        RaiseEvent showgifclicked(New ad1)
    End Sub
End Class
