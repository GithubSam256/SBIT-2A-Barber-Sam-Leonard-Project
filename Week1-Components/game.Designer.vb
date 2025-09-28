<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(game))
        Game11 = New Game1()
        SuspendLayout()
        ' 
        ' Game11
        ' 
        Game11.BackColor = Color.LightSkyBlue
        Game11.Location = New Point(3, 65)
        Game11.Margin = New Padding(3, 2, 3, 2)
        Game11.Name = "Game11"
        Game11.Size = New Size(950, 532)
        Game11.TabIndex = 0
        ' 
        ' game
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Game11)
        Name = "game"
        Size = New Size(950, 735)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Game11 As Game1

End Class
