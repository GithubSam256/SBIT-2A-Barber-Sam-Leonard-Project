<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game1
    Inherits System.Windows.Forms.UserControl

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game1))
        Panel1 = New Panel()
        PriestButtonRight1 = New Button()
        PriestButtonRight2 = New Button()
        PriestButtonRight3 = New Button()
        DevilButtonRight1 = New Button()
        DevilButtonRight2 = New Button()
        DevilButtonRight3 = New Button()
        Panel2 = New Panel()
        PriestButtonLeft1 = New Button()
        PriestButtonLeft2 = New Button()
        PriestButtonLeft3 = New Button()
        DevilButtonLeft1 = New Button()
        DevilButtonLeft2 = New Button()
        DevilButtonLeft3 = New Button()
        Boat2Left = New Button()
        Label1 = New Label()
        GoButton = New Button()
        BoatPanelLeft = New Panel()
        Boat1Left = New Button()
        BoatPanelRight = New Panel()
        Boat1Right = New Button()
        Boat2Right = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        BoatPanelLeft.SuspendLayout()
        BoatPanelRight.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(PriestButtonRight1)
        Panel1.Controls.Add(PriestButtonRight2)
        Panel1.Controls.Add(PriestButtonRight3)
        Panel1.Controls.Add(DevilButtonRight1)
        Panel1.Controls.Add(DevilButtonRight2)
        Panel1.Controls.Add(DevilButtonRight3)
        Panel1.Location = New Point(648, 131)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(296, 327)
        Panel1.TabIndex = 0
        ' 
        ' PriestButtonRight1
        ' 
        PriestButtonRight1.BackColor = Color.LightBlue
        PriestButtonRight1.BackgroundImage = CType(resources.GetObject("PriestButtonRight1.BackgroundImage"), Image)
        PriestButtonRight1.Font = New Font("Segoe UI", 9.75F)
        PriestButtonRight1.ForeColor = Color.White
        PriestButtonRight1.Location = New Point(70, 22)
        PriestButtonRight1.Margin = New Padding(3, 2, 3, 2)
        PriestButtonRight1.Name = "PriestButtonRight1"
        PriestButtonRight1.Size = New Size(70, 60)
        PriestButtonRight1.TabIndex = 0
        PriestButtonRight1.Text = "Priest 1"
        PriestButtonRight1.UseVisualStyleBackColor = False
        PriestButtonRight1.Visible = False
        ' 
        ' PriestButtonRight2
        ' 
        PriestButtonRight2.BackColor = Color.LightBlue
        PriestButtonRight2.BackgroundImage = CType(resources.GetObject("PriestButtonRight2.BackgroundImage"), Image)
        PriestButtonRight2.Font = New Font("Segoe UI", 9.75F)
        PriestButtonRight2.ForeColor = Color.White
        PriestButtonRight2.Location = New Point(70, 125)
        PriestButtonRight2.Margin = New Padding(3, 2, 3, 2)
        PriestButtonRight2.Name = "PriestButtonRight2"
        PriestButtonRight2.Size = New Size(70, 60)
        PriestButtonRight2.TabIndex = 1
        PriestButtonRight2.Text = "Priest 2"
        PriestButtonRight2.UseVisualStyleBackColor = False
        PriestButtonRight2.Visible = False
        ' 
        ' PriestButtonRight3
        ' 
        PriestButtonRight3.BackColor = Color.LightBlue
        PriestButtonRight3.BackgroundImage = CType(resources.GetObject("PriestButtonRight3.BackgroundImage"), Image)
        PriestButtonRight3.Font = New Font("Segoe UI", 9.75F)
        PriestButtonRight3.ForeColor = Color.White
        PriestButtonRight3.Location = New Point(70, 259)
        PriestButtonRight3.Margin = New Padding(3, 2, 3, 2)
        PriestButtonRight3.Name = "PriestButtonRight3"
        PriestButtonRight3.Size = New Size(70, 60)
        PriestButtonRight3.TabIndex = 2
        PriestButtonRight3.Text = "Priest 3"
        PriestButtonRight3.UseVisualStyleBackColor = False
        PriestButtonRight3.Visible = False
        ' 
        ' DevilButtonRight1
        ' 
        DevilButtonRight1.BackColor = Color.LightCoral
        DevilButtonRight1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DevilButtonRight1.Image = CType(resources.GetObject("DevilButtonRight1.Image"), Image)
        DevilButtonRight1.Location = New Point(175, 22)
        DevilButtonRight1.Margin = New Padding(3, 2, 3, 2)
        DevilButtonRight1.Name = "DevilButtonRight1"
        DevilButtonRight1.Size = New Size(70, 60)
        DevilButtonRight1.TabIndex = 3
        DevilButtonRight1.Text = "Devil 1"
        DevilButtonRight1.UseVisualStyleBackColor = False
        DevilButtonRight1.Visible = False
        ' 
        ' DevilButtonRight2
        ' 
        DevilButtonRight2.BackColor = Color.LightCoral
        DevilButtonRight2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DevilButtonRight2.Image = CType(resources.GetObject("DevilButtonRight2.Image"), Image)
        DevilButtonRight2.Location = New Point(175, 125)
        DevilButtonRight2.Margin = New Padding(3, 2, 3, 2)
        DevilButtonRight2.Name = "DevilButtonRight2"
        DevilButtonRight2.Size = New Size(70, 60)
        DevilButtonRight2.TabIndex = 4
        DevilButtonRight2.Text = "Devil 2"
        DevilButtonRight2.UseVisualStyleBackColor = False
        DevilButtonRight2.Visible = False
        ' 
        ' DevilButtonRight3
        ' 
        DevilButtonRight3.BackColor = Color.LightCoral
        DevilButtonRight3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DevilButtonRight3.Image = CType(resources.GetObject("DevilButtonRight3.Image"), Image)
        DevilButtonRight3.Location = New Point(175, 259)
        DevilButtonRight3.Margin = New Padding(3, 2, 3, 2)
        DevilButtonRight3.Name = "DevilButtonRight3"
        DevilButtonRight3.Size = New Size(70, 60)
        DevilButtonRight3.TabIndex = 5
        DevilButtonRight3.Text = "Devil 3"
        DevilButtonRight3.UseVisualStyleBackColor = False
        DevilButtonRight3.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(PriestButtonLeft1)
        Panel2.Controls.Add(PriestButtonLeft2)
        Panel2.Controls.Add(PriestButtonLeft3)
        Panel2.Controls.Add(DevilButtonLeft1)
        Panel2.Controls.Add(DevilButtonLeft2)
        Panel2.Controls.Add(DevilButtonLeft3)
        Panel2.Location = New Point(14, 131)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(296, 327)
        Panel2.TabIndex = 0
        ' 
        ' PriestButtonLeft1
        ' 
        PriestButtonLeft1.BackColor = Color.LightBlue
        PriestButtonLeft1.BackgroundImage = CType(resources.GetObject("PriestButtonLeft1.BackgroundImage"), Image)
        PriestButtonLeft1.Font = New Font("Segoe UI", 9.75F)
        PriestButtonLeft1.ForeColor = Color.White
        PriestButtonLeft1.Location = New Point(50, 26)
        PriestButtonLeft1.Margin = New Padding(3, 2, 3, 2)
        PriestButtonLeft1.Name = "PriestButtonLeft1"
        PriestButtonLeft1.Size = New Size(70, 60)
        PriestButtonLeft1.TabIndex = 0
        PriestButtonLeft1.Text = "Priest 1"
        PriestButtonLeft1.UseVisualStyleBackColor = False
        ' 
        ' PriestButtonLeft2
        ' 
        PriestButtonLeft2.BackColor = Color.LightBlue
        PriestButtonLeft2.BackgroundImage = CType(resources.GetObject("PriestButtonLeft2.BackgroundImage"), Image)
        PriestButtonLeft2.Font = New Font("Segoe UI", 9.75F)
        PriestButtonLeft2.ForeColor = Color.White
        PriestButtonLeft2.Location = New Point(47, 125)
        PriestButtonLeft2.Margin = New Padding(3, 2, 3, 2)
        PriestButtonLeft2.Name = "PriestButtonLeft2"
        PriestButtonLeft2.Size = New Size(70, 60)
        PriestButtonLeft2.TabIndex = 1
        PriestButtonLeft2.Text = "Priest 2"
        PriestButtonLeft2.UseVisualStyleBackColor = False
        ' 
        ' PriestButtonLeft3
        ' 
        PriestButtonLeft3.BackColor = Color.LightBlue
        PriestButtonLeft3.BackgroundImage = CType(resources.GetObject("PriestButtonLeft3.BackgroundImage"), Image)
        PriestButtonLeft3.Font = New Font("Segoe UI", 9.75F)
        PriestButtonLeft3.ForeColor = Color.White
        PriestButtonLeft3.Location = New Point(47, 259)
        PriestButtonLeft3.Margin = New Padding(3, 2, 3, 2)
        PriestButtonLeft3.Name = "PriestButtonLeft3"
        PriestButtonLeft3.Size = New Size(70, 60)
        PriestButtonLeft3.TabIndex = 2
        PriestButtonLeft3.Text = "Priest 3"
        PriestButtonLeft3.UseVisualStyleBackColor = False
        ' 
        ' DevilButtonLeft1
        ' 
        DevilButtonLeft1.BackColor = Color.LightCoral
        DevilButtonLeft1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DevilButtonLeft1.Image = CType(resources.GetObject("DevilButtonLeft1.Image"), Image)
        DevilButtonLeft1.Location = New Point(152, 22)
        DevilButtonLeft1.Margin = New Padding(3, 2, 3, 2)
        DevilButtonLeft1.Name = "DevilButtonLeft1"
        DevilButtonLeft1.Size = New Size(70, 60)
        DevilButtonLeft1.TabIndex = 4
        DevilButtonLeft1.Text = "Devil 1"
        DevilButtonLeft1.UseVisualStyleBackColor = False
        ' 
        ' DevilButtonLeft2
        ' 
        DevilButtonLeft2.BackColor = Color.LightCoral
        DevilButtonLeft2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DevilButtonLeft2.Image = CType(resources.GetObject("DevilButtonLeft2.Image"), Image)
        DevilButtonLeft2.Location = New Point(152, 125)
        DevilButtonLeft2.Margin = New Padding(3, 2, 3, 2)
        DevilButtonLeft2.Name = "DevilButtonLeft2"
        DevilButtonLeft2.Size = New Size(70, 60)
        DevilButtonLeft2.TabIndex = 4
        DevilButtonLeft2.Text = "Devil 2"
        DevilButtonLeft2.UseVisualStyleBackColor = False
        ' 
        ' DevilButtonLeft3
        ' 
        DevilButtonLeft3.BackColor = Color.LightCoral
        DevilButtonLeft3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DevilButtonLeft3.Image = CType(resources.GetObject("DevilButtonLeft3.Image"), Image)
        DevilButtonLeft3.Location = New Point(152, 259)
        DevilButtonLeft3.Margin = New Padding(3, 2, 3, 2)
        DevilButtonLeft3.Name = "DevilButtonLeft3"
        DevilButtonLeft3.Size = New Size(70, 60)
        DevilButtonLeft3.TabIndex = 5
        DevilButtonLeft3.Text = "Devil 3"
        DevilButtonLeft3.UseVisualStyleBackColor = False
        ' 
        ' Boat2Left
        ' 
        Boat2Left.BackColor = Color.Transparent
        Boat2Left.Location = New Point(67, 10)
        Boat2Left.Margin = New Padding(3, 2, 3, 2)
        Boat2Left.Name = "Boat2Left"
        Boat2Left.Size = New Size(57, 26)
        Boat2Left.TabIndex = 3
        Boat2Left.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 547)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 60)
        Label1.TabIndex = 1
        Label1.Text = "Instructions:" & vbCrLf & "At any time (on either riverbank or in the boat)," & vbCrLf & "if the number of Devils exceeds the number of Priests," & vbCrLf & "the Devils will eat the Priests (i.e., that situation is forbidden)."
        ' 
        ' GoButton
        ' 
        GoButton.Location = New Point(432, 75)
        GoButton.Margin = New Padding(3, 2, 3, 2)
        GoButton.Name = "GoButton"
        GoButton.Size = New Size(82, 47)
        GoButton.TabIndex = 2
        GoButton.Text = "GO"
        GoButton.UseVisualStyleBackColor = True
        ' 
        ' BoatPanelLeft
        ' 
        BoatPanelLeft.BackColor = Color.SaddleBrown
        BoatPanelLeft.Controls.Add(Boat1Left)
        BoatPanelLeft.Controls.Add(Boat2Left)
        BoatPanelLeft.Location = New Point(342, 225)
        BoatPanelLeft.Margin = New Padding(3, 2, 3, 2)
        BoatPanelLeft.Name = "BoatPanelLeft"
        BoatPanelLeft.Size = New Size(127, 45)
        BoatPanelLeft.TabIndex = 0
        ' 
        ' Boat1Left
        ' 
        Boat1Left.BackColor = Color.Transparent
        Boat1Left.Location = New Point(5, 10)
        Boat1Left.Margin = New Padding(3, 2, 3, 2)
        Boat1Left.Name = "Boat1Left"
        Boat1Left.Size = New Size(59, 26)
        Boat1Left.TabIndex = 0
        Boat1Left.UseVisualStyleBackColor = False
        ' 
        ' BoatPanelRight
        ' 
        BoatPanelRight.BackColor = Color.SaddleBrown
        BoatPanelRight.BackgroundImageLayout = ImageLayout.Zoom
        BoatPanelRight.Controls.Add(Boat1Right)
        BoatPanelRight.Controls.Add(Boat2Right)
        BoatPanelRight.Location = New Point(509, 225)
        BoatPanelRight.Margin = New Padding(3, 2, 3, 2)
        BoatPanelRight.Name = "BoatPanelRight"
        BoatPanelRight.Size = New Size(129, 45)
        BoatPanelRight.TabIndex = 1
        BoatPanelRight.Visible = False
        ' 
        ' Boat1Right
        ' 
        Boat1Right.BackColor = Color.Transparent
        Boat1Right.Location = New Point(4, 10)
        Boat1Right.Margin = New Padding(3, 2, 3, 2)
        Boat1Right.Name = "Boat1Right"
        Boat1Right.Size = New Size(59, 26)
        Boat1Right.TabIndex = 0
        Boat1Right.UseVisualStyleBackColor = False
        ' 
        ' Boat2Right
        ' 
        Boat2Right.BackColor = Color.Transparent
        Boat2Right.Location = New Point(66, 10)
        Boat2Right.Margin = New Padding(3, 2, 3, 2)
        Boat2Right.Name = "Boat2Right"
        Boat2Right.Size = New Size(56, 26)
        Boat2Right.TabIndex = 3
        Boat2Right.UseVisualStyleBackColor = False
        ' 
        ' Game1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        Controls.Add(BoatPanelLeft)
        Controls.Add(BoatPanelRight)
        Controls.Add(GoButton)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Game1"
        Size = New Size(950, 735)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        BoatPanelLeft.ResumeLayout(False)
        BoatPanelRight.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GoButton As Button
    Friend WithEvents PriestButtonRight1 As Button
    Friend WithEvents PriestButtonRight2 As Button
    Friend WithEvents PriestButtonRight3 As Button
    Friend WithEvents DevilButtonRight1 As Button
    Friend WithEvents DevilButtonRight2 As Button
    Friend WithEvents DevilButtonRight3 As Button
    Friend WithEvents BoatPanelLeft As Panel
    Friend WithEvents BoatPanelRight As Panel
    Friend WithEvents PriestButtonLeft1 As Button
    Friend WithEvents PriestButtonLeft2 As Button
    Friend WithEvents PriestButtonLeft3 As Button
    Friend WithEvents Boat2Left As Button
    Friend WithEvents DevilButtonLeft2 As Button
    Friend WithEvents DevilButtonLeft3 As Button
    Friend WithEvents Boat1Left As Button
    Friend WithEvents DevilButtonLeft1 As Button
    Friend WithEvents Boat1Right As Button
    Friend WithEvents Boat2Right As Button
End Class
