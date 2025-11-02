Public Class Game1
    Public leftPriests As Integer = 3
    Public leftDevils As Integer = 3
    Public rightPriests As Integer = 0
    Public rightDevils As Integer = 0
    Public boatOnLeft As Boolean = True
    Public boatCapacity As Integer = 2

    'Lagay ko lang dito yung win condition
    Private Sub CheckWinCon()
        If rightPriests = 3 And rightDevils = 3 Then
            MessageBox.Show("You Win!")
            Application.Restart()
        End If
        If leftPriests < leftDevils And leftPriests > 0 Then 'when there are too many devils on one side
            MessageBox.Show("You Lose!")
            Application.Restart()
        End If
        If rightPriests < rightDevils And rightPriests > 0 Then 'same
            MessageBox.Show("You Lose!")
            Application.Restart()
        End If
    End Sub

    ' New: Check win/lose condition, counting boat passengers as still on the current side
    Private Sub CheckWinConWithBoatOnCurrentSide()
        Dim lPriests As Integer = leftPriests
        Dim lDevils As Integer = leftDevils
        Dim rPriests As Integer = rightPriests
        Dim rDevils As Integer = rightDevils

        ' Add boat passengers to the current side for lose check
        If boatOnLeft Then
            If Boat1Left.Text.Contains("Priest") Then lPriests += 1
            If Boat2Left.Text.Contains("Priest") Then lPriests += 1
            If Boat1Left.Text.Contains("Devil") Then lDevils += 1
            If Boat2Left.Text.Contains("Devil") Then lDevils += 1
        Else
            If Boat1Right.Text.Contains("Priest") Then rPriests += 1
            If Boat2Right.Text.Contains("Priest") Then rPriests += 1
            If Boat1Right.Text.Contains("Devil") Then rDevils += 1
            If Boat2Right.Text.Contains("Devil") Then rDevils += 1
        End If

        ' Win check: all priests and devils are on the right side or in the boat (regardless of boat position)
        Dim totalRightPriests As Integer = rightPriests
        Dim totalRightDevils As Integer = rightDevils
        If Boat1Left.Text.Contains("Priest") Then totalRightPriests += 1
        If Boat2Left.Text.Contains("Priest") Then totalRightPriests += 1
        If Boat1Right.Text.Contains("Priest") Then totalRightPriests += 1
        If Boat2Right.Text.Contains("Priest") Then totalRightPriests += 1
        If Boat1Left.Text.Contains("Devil") Then totalRightDevils += 1
        If Boat2Left.Text.Contains("Devil") Then totalRightDevils += 1
        If Boat1Right.Text.Contains("Devil") Then totalRightDevils += 1
        If Boat2Right.Text.Contains("Devil") Then totalRightDevils += 1
        If totalRightPriests = 3 And totalRightDevils = 3 Then
            MessageBox.Show("You Win!")
            Application.Restart()
        End If

        If lPriests < lDevils And lPriests > 0 Then
            MessageBox.Show("You Lose!")
            Application.Restart()
        End If
        If rPriests < rDevils And rPriests > 0 Then
            MessageBox.Show("You Lose!")
            Application.Restart()
        End If
    End Sub

    ' Call this after every move to check if all are on the right side
    Private Sub CheckWinByButtons()
        If PriestButtonRight1.Visible And PriestButtonRight2.Visible And PriestButtonRight3.Visible And
            DevilButtonRight1.Visible And DevilButtonRight2.Visible And DevilButtonRight3.Visible Then
            MessageBox.Show("You Win!")
            Application.Restart()
        End If
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        CheckWinConWithBoatOnCurrentSide()
        CheckWinByButtons()
        ' Move the boat to the other side
        If boatOnLeft Then
            ' Only move if there is at least one passenger
            If Boat1Left.Text = "" And Boat2Left.Text = "" Then
                MessageBox.Show("The boat is empty!")
                Return
            End If
            ' Move passengers from left boat to right boat
            BoatPanelLeft.Visible = False
            BoatPanelRight.Visible = True
            Boat1Right.Text = Boat1Left.Text
            Boat1Right.BackColor = Boat1Left.BackColor
            Boat2Right.Text = Boat2Left.Text
            Boat2Right.BackColor = Boat2Left.BackColor
            Boat1Left.Text = ""
            Boat1Left.BackColor = SystemColors.Control
            Boat2Left.Text = ""
            Boat2Left.BackColor = SystemColors.Control

        Else
            If Boat1Right.Text = "" And Boat2Right.Text = "" Then
                MessageBox.Show("The boat is empty!")
                Return
            End If
            ' Move passengers from right boat to left boat
            BoatPanelLeft.Visible = True
            BoatPanelRight.Visible = False
            Boat1Left.Text = Boat1Right.Text
            Boat1Left.BackColor = Boat1Right.BackColor
            Boat2Left.Text = Boat2Right.Text
            Boat2Left.BackColor = Boat2Right.BackColor
            Boat1Right.Text = ""
            Boat1Right.BackColor = SystemColors.Control
            Boat2Right.Text = ""
            Boat2Right.BackColor = SystemColors.Control
        End If
        boatOnLeft = Not boatOnLeft
        ' Check win/lose condition before moving the boat, counting boat passengers as still on the current side
        CheckWinConWithBoatOnCurrentSide()
    End Sub
    Private Sub ClickPriest(name As String)
        If boatOnLeft Then
            If Boat1Left.Text = "" Or Boat2Left.Text = "" Then
                If Boat1Left.Text = "" Then
                    Boat1Left.Text = name
                    leftPriests -= 1
                    Boat1Left.BackColor = Color.LightBlue
                Else
                    Boat2Left.Text = name
                    leftPriests -= 1
                    Boat2Left.BackColor = Color.LightBlue
                End If
            End If
        Else
            If Boat1Right.Text = "" Or Boat2Right.Text = "" Then
                If Boat1Right.Text = "" Then
                    Boat1Right.Text = name
                    rightPriests += 1
                    Boat1Right.BackColor = Color.LightBlue
                Else
                    Boat2Right.Text = name
                    rightPriests += 1
                    Boat2Right.BackColor = Color.LightBlue
                End If
            End If
        End If
    End Sub
    Private Sub ClickDevil(name As String)
        If boatOnLeft Then
            If Boat1Left.Text = "" Or Boat2Left.Text = "" Then
                If Boat1Left.Text = "" Then
                    Boat1Left.Text = name
                    leftDevils -= 1
                    Boat1Left.BackColor = Color.LightCoral
                Else
                    Boat2Left.Text = name
                    leftDevils -= 1
                    Boat2Left.BackColor = Color.LightCoral
                End If
            End If
        Else
            If Boat1Right.Text = "" Or Boat2Right.Text = "" Then
                If Boat1Right.Text = "" Then
                    Boat1Right.Text = name
                    rightDevils += 1
                    Boat1Right.BackColor = Color.LightCoral
                Else
                    Boat2Right.Text = name
                    rightDevils += 1
                    Boat2Right.BackColor = Color.LightCoral
                End If
            End If
        End If
    End Sub

    Private Sub IsBoatFull(button As Button)
        ' Only allow interaction on the correct side
        If (boatOnLeft AndAlso (button.Name.Contains("Left"))) Or (Not boatOnLeft AndAlso (button.Name.Contains("Right"))) Then
            If boatOnLeft Then
                If Boat1Left.Text <> "" And Boat2Left.Text <> "" Then
                    MessageBox.Show("The boat is full!")
                    button.Visible = True
                Else
                    If button.Text.Contains("Priest") Then
                        button.Visible = False
                        ClickPriest(button.Text)
                    ElseIf button.Text.Contains("Devil") Then
                        button.Visible = False
                        ClickDevil(button.Text)
                    End If
                End If
            Else
                If Boat1Right.Text <> "" And Boat2Right.Text <> "" Then
                    MessageBox.Show("The boat is full!")
                    button.Visible = True
                Else
                    If button.Text.Contains("Priest") Then
                        button.Visible = False
                        ClickPriest(button.Text)
                    ElseIf button.Text.Contains("Devil") Then
                        button.Visible = False
                        ClickDevil(button.Text)
                    End If
                End If
            End If
        Else
            MessageBox.Show("You can't move this character when the boat is not on this side.")
        End If
    End Sub

    Private Sub EntityReturn(button As Button)
        ' Only allow interaction on the correct side
        If (boatOnLeft AndAlso (button.Name.Contains("Left"))) Or (Not boatOnLeft AndAlso (button.Name.Contains("Right"))) Then
            If boatOnLeft Then
                If button.Text.Contains("Priest") Then
                    leftPriests += 1
                    Select Case button.Text
                        Case "Priest 1"
                            button.Text = ""
                            PriestButtonLeft1.Visible = True
                        Case "Priest 2"
                            button.Text = ""
                            PriestButtonLeft2.Visible = True
                        Case "Priest 3"
                            button.Text = ""
                            PriestButtonLeft3.Visible = True
                    End Select
                    button.BackColor = SystemColors.Control
                ElseIf button.Text.Contains("Devil") Then
                    leftDevils += 1
                    Select Case button.Text
                        Case "Devil 1"
                            button.Text = ""
                            DevilButtonLeft1.Visible = True
                        Case "Devil 2"
                            button.Text = ""
                            DevilButtonLeft2.Visible = True
                        Case "Devil 3"
                            button.Text = ""
                            DevilButtonLeft3.Visible = True
                    End Select
                    button.BackColor = SystemColors.Control
                End If
            Else
                If button.Text.Contains("Priest") Then
                    rightPriests -= 1
                    Select Case button.Text
                        Case "Priest 1"
                            button.Text = ""
                            PriestButtonRight1.Visible = True
                        Case "Priest 2"
                            button.Text = ""
                            PriestButtonRight2.Visible = True
                        Case "Priest 3"
                            button.Text = ""
                            PriestButtonRight3.Visible = True
                    End Select
                    button.BackColor = SystemColors.Control
                ElseIf button.Text.Contains("Devil") Then
                    rightDevils -= 1
                    Select Case button.Text
                        Case "Devil 1"
                            button.Text = ""
                            DevilButtonRight1.Visible = True
                        Case "Devil 2"
                            button.Text = ""
                            DevilButtonRight2.Visible = True
                        Case "Devil 3"
                            button.Text = ""
                            DevilButtonRight3.Visible = True
                    End Select
                    button.BackColor = SystemColors.Control
                End If
            End If
        Else
            MessageBox.Show("You can't interact with the boat on this side.")
        End If
    End Sub

    Private Sub Boat1Left_Click(sender As Object, e As EventArgs) Handles Boat1Left.Click
        EntityReturn(Boat1Left)
    End Sub
    Private Sub Boat2Left_Click(sender As Object, e As EventArgs) Handles Boat2Left.Click
        EntityReturn(Boat2Left)
    End Sub
    Private Sub Boat1Right_Click(sender As Object, e As EventArgs) Handles Boat1Right.Click
        EntityReturn(Boat1Right)
    End Sub
    Private Sub Boat2Right_Click(sender As Object, e As EventArgs) Handles Boat2Right.Click
        EntityReturn(Boat2Right)
    End Sub

    Private Sub PriestButtonLeft1_Click(sender As Object, e As EventArgs) Handles PriestButtonLeft1.Click
        IsBoatFull(PriestButtonLeft1)
    End Sub
    Private Sub PriestButtonLeft2_Click(sender As Object, e As EventArgs) Handles PriestButtonLeft2.Click
        IsBoatFull(PriestButtonLeft2)
    End Sub
    Private Sub PriestButtonLeft3_Click(sender As Object, e As EventArgs) Handles PriestButtonLeft3.Click
        IsBoatFull(PriestButtonLeft3)
    End Sub
    Private Sub DevilButtonLeft1_Click(sender As Object, e As EventArgs) Handles DevilButtonLeft1.Click
        IsBoatFull(DevilButtonLeft1)
    End Sub
    Private Sub DevilButtonLeft2_Click(sender As Object, e As EventArgs) Handles DevilButtonLeft2.Click
        IsBoatFull(DevilButtonLeft2)
    End Sub
    Private Sub DevilButtonLeft3_Click(sender As Object, e As EventArgs) Handles DevilButtonLeft3.Click
        IsBoatFull(DevilButtonLeft3)
    End Sub
    Private Sub PriestButtonRight1_Click(sender As Object, e As EventArgs) Handles PriestButtonRight1.Click
        IsBoatFull(PriestButtonRight1)
    End Sub
    Private Sub PriestButtonRight2_Click(sender As Object, e As EventArgs) Handles PriestButtonRight2.Click
        IsBoatFull(PriestButtonRight2)
    End Sub
    Private Sub PriestButtonRight3_Click(sender As Object, e As EventArgs) Handles PriestButtonRight3.Click
        IsBoatFull(PriestButtonRight3)
    End Sub
    Private Sub DevilButtonRight1_Click(sender As Object, e As EventArgs) Handles DevilButtonRight1.Click
        IsBoatFull(DevilButtonRight1)
    End Sub
    Private Sub DevilButtonRight2_Click(sender As Object, e As EventArgs) Handles DevilButtonRight2.Click
        IsBoatFull(DevilButtonRight2)
    End Sub
    Private Sub DevilButtonRight3_Click(sender As Object, e As EventArgs) Handles DevilButtonRight3.Click
        IsBoatFull(DevilButtonRight3)
    End Sub

End Class