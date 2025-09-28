<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Week2Topic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week2Topic))
        Panel1 = New Panel()
        Panel3 = New Panel()
        Week2_components1 = New week2_components()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        MainContentPanel = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.IndianRed
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(390, 846)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(Week2_components1)
        Panel3.Location = New Point(26, 116)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(335, 693)
        Panel3.TabIndex = 1
        ' 
        ' Week2_components1
        ' 
        Week2_components1.BackColor = Color.Transparent
        Week2_components1.Location = New Point(0, 0)
        Week2_components1.Name = "Week2_components1"
        Week2_components1.Size = New Size(335, 693)
        Week2_components1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(387, 111)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(MainContentPanel)
        Panel2.Location = New Point(383, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(978, 832)
        Panel2.TabIndex = 1
        ' 
        ' MainContentPanel
        ' 
        MainContentPanel.Location = New Point(15, 50)
        MainContentPanel.Name = "MainContentPanel"
        MainContentPanel.Size = New Size(950, 735)
        MainContentPanel.TabIndex = 0
        ' 
        ' Week2Topic
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1366, 830)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Week2Topic"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week2Topic"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Week2_components1 As week2_components
    Friend WithEvents MainContentPanel As Panel
End Class
