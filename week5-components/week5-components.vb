Public Class week5_components

    Public Event showgifclicked(control As UserControl)
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent showgifclicked(New datahandle())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RaiseEvent showgifclicked(New tod())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RaiseEvent showgifclicked(New nrvc())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RaiseEvent showgifclicked(New dv())
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RaiseEvent showgifclicked(New dc())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RaiseEvent showgifclicked(New svc)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RaiseEvent showgifclicked(New cdt)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New startp)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent showgifclicked(New ao)
        Panel2.Visible = Not Panel2.Visible
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New ad2)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New framee)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New properties)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New fp2)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        RaiseEvent showgifclicked(New bpictures)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RaiseEvent showgifclicked(New calculator)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        RaiseEvent showgifclicked(New op)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        RaiseEvent showgifclicked(New aof)
    End Sub
End Class
