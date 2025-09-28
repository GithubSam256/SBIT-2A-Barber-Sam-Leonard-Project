Public Class week7_components

    Public Event showgifclicked(control As UserControl)
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent showgifclicked(New arraychar())

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent showgifclicked(New arrays)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RaiseEvent showgifclicked(New daa)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RaiseEvent showgifclicked(New di)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RaiseEvent showgifclicked(New iasi)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RaiseEvent showgifclicked(New oda)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RaiseEvent showgifclicked(New tda)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RaiseEvent showgifclicked(New trda)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RaiseEvent showgifclicked(New rnv)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RaiseEvent showgifclicked(New raa)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        RaiseEvent showgifclicked(New pa)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RaiseEvent showgifclicked(New declaringcode)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        RaiseEvent showgifclicked(New implicitcode)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RaiseEvent showgifclicked(New _12months)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RaiseEvent showgifclicked(New twodcode)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        RaiseEvent showgifclicked(New returningcode)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        RaiseEvent showgifclicked(New returningarraycode)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        RaiseEvent showgifclicked(New passingarraycode)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        RaiseEvent showgifclicked(New threedcode)
    End Sub
End Class
