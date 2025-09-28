Public Class Week7Topic

    Private Sub Week2Topic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the event handler address here
        AddHandler Week7_components1.showgifclicked, AddressOf showgif
    End Sub

    Public Sub showgif(userControlToLoad As UserControl)
        MainContentPanel.Controls.Clear()
        userControlToLoad.Dock = DockStyle.Fill
        MainContentPanel.Controls.Add(userControlToLoad)
    End Sub


End Class