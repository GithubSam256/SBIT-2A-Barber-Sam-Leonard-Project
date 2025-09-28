<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MidContainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MidContainer))
        PictureBox1 = New PictureBox()
        Card1 = New Card()
        Card2 = New Card()
        Card3 = New Card()
        Card6 = New Card()
        Card5 = New Card()
        Card4 = New Card()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1366, 768)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Card1
        ' 
        Card1.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card1.Location = New Point(55, 48)
        Card1.Name = "Card1"
        Card1.Padding = New Padding(5)
        Card1.Size = New Size(382, 341)
        Card1.TabIndex = 1
        ' 
        ' Card2
        ' 
        Card2.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card2.Location = New Point(492, 48)
        Card2.Name = "Card2"
        Card2.Padding = New Padding(5)
        Card2.Size = New Size(382, 341)
        Card2.TabIndex = 2
        ' 
        ' Card3
        ' 
        Card3.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card3.Location = New Point(929, 48)
        Card3.Name = "Card3"
        Card3.Padding = New Padding(5)
        Card3.Size = New Size(382, 341)
        Card3.TabIndex = 3
        ' 
        ' Card6
        ' 
        Card6.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card6.Location = New Point(929, 417)
        Card6.Name = "Card6"
        Card6.Padding = New Padding(5)
        Card6.Size = New Size(382, 341)
        Card6.TabIndex = 6
        ' 
        ' Card5
        ' 
        Card5.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card5.Location = New Point(492, 417)
        Card5.Name = "Card5"
        Card5.Padding = New Padding(5)
        Card5.Size = New Size(382, 341)
        Card5.TabIndex = 5
        ' 
        ' Card4
        ' 
        Card4.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card4.Location = New Point(55, 417)
        Card4.Name = "Card4"
        Card4.Padding = New Padding(5)
        Card4.Size = New Size(382, 341)
        Card4.TabIndex = 4
        ' 
        ' MidContainer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Card6)
        Controls.Add(Card5)
        Controls.Add(Card4)
        Controls.Add(Card3)
        Controls.Add(Card2)
        Controls.Add(Card1)
        Controls.Add(PictureBox1)
        Name = "MidContainer"
        Size = New Size(1366, 768)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Card1 As Card
    Friend WithEvents Card2 As Card
    Friend WithEvents Card3 As Card
    Friend WithEvents Card6 As Card
    Friend WithEvents Card5 As Card
    Friend WithEvents Card4 As Card

End Class
