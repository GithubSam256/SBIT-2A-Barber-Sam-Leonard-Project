Public Class week3_components

    Public Event showgifclicked(control As UserControl)
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent showgifclicked(New computerprog())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RaiseEvent showgifclicked(New programmingl())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RaiseEvent showgifclicked(New poppl())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RaiseEvent showgifclicked(New wpm())
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RaiseEvent showgifclicked(New tpl())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RaiseEvent showgifclicked(New explore)
        Panel6.Visible = Not Panel6.Visible
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RaiseEvent showgifclicked(New building)
        Panel1.Visible = Not Panel1.Visible
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RaiseEvent showgifclicked(New startp)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent showgifclicked(New newproj)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RaiseEvent showgifclicked(New toolbox)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        RaiseEvent showgifclicked(New framee)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        RaiseEvent showgifclicked(New properties)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RaiseEvent showgifclicked(New fdw)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        RaiseEvent showgifclicked(New bpictures)
    End Sub
End Class
