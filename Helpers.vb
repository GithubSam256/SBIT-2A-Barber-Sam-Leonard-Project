Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class Helpers

End Class


Module HelpersFunctions
    Public Sub SetRoundedCorners(ctrl As Control, borderRoundness As Integer)
        Dim path As GraphicsPath = GetRoundedPath(ctrl.ClientRectangle, borderRoundness)
        ctrl.Region = New Region(path)
    End Sub

    Private Function GetRoundedPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        ' ✅ Clamp radius so it fits evenly on all sides
        Dim maxRadius As Integer = Math.Min(rect.Width, rect.Height) \ 2
        Dim r As Integer = Math.Min(radius, maxRadius)
        Dim d As Integer = r * 2

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)                       ' Top-left
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)               ' Top-right
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)        ' Bottom-right
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)               ' Bottom-left
        path.CloseFigure()

        Return path
    End Function


    Public Sub DrawRoundedBorder(ctrl As Control, borderRoundness As Integer, borderColor As Color, borderSize As Integer)
        AddHandler ctrl.Paint,
            Sub(sender As Object, e As PaintEventArgs)
                Dim g As Graphics = e.Graphics
                g.SmoothingMode = SmoothingMode.AntiAlias

                Dim path As GraphicsPath = GetRoundedPath(ctrl.ClientRectangle, borderRoundness)
                Using pen As New Pen(borderColor, borderSize)
                    g.DrawPath(pen, path)
                End Using
            End Sub
    End Sub

    Private scrollTimer As Timer
    Private scrollTargetY As Integer
    Private scrollStep As Integer
    Private scrollContainer As ScrollableControl

    Public Sub ScrollToSection(container As ScrollableControl, target As Control, Optional stepSize As Integer = 20)
        ' Stop existing timer if running
        If scrollTimer IsNot Nothing Then
            scrollTimer.Stop()
            RemoveHandler scrollTimer.Tick, AddressOf ScrollTick
        End If

        scrollContainer = container
        scrollTargetY = target.Top - scrollContainer.DisplayRectangle.Top - 60
        scrollStep = stepSize

        scrollTimer = New Timer() With {.Interval = 10}
        AddHandler scrollTimer.Tick, AddressOf ScrollTick
        scrollTimer.Start()
    End Sub

    Private Sub ScrollTick(sender As Object, e As EventArgs)
        Dim currentY As Integer = scrollContainer.VerticalScroll.Value
        Dim diff As Integer = scrollTargetY - currentY

        If Math.Abs(diff) < scrollStep Then
            scrollContainer.VerticalScroll.Value = Math.Max(scrollContainer.VerticalScroll.Minimum,
                                                        Math.Min(scrollTargetY, scrollContainer.VerticalScroll.Maximum))
            scrollTimer.Stop()
        Else
            Dim newValue As Integer = currentY + Math.Sign(diff) * scrollStep
            ' Clamp between min and max
            newValue = Math.Max(scrollContainer.VerticalScroll.Minimum,
                            Math.Min(newValue, scrollContainer.VerticalScroll.Maximum))
            scrollContainer.VerticalScroll.Value = newValue
        End If
    End Sub

End Module