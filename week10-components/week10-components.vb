Public Class week10_components

    Public Event showgifclicked(control As UserControl)


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent showgifclicked(New cls)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent showgifclicked(New cls1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RaiseEvent showgifclicked(New cls2)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RaiseEvent showgifclicked(New cls3)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RaiseEvent showgifclicked(New codeexample)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RaiseEvent showgifclicked(New invsystem)
    End Sub
End Class
