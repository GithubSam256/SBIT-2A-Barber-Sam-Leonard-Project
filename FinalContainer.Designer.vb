<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalContainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinalContainer))
        PictureBox1 = New PictureBox()
        Card12 = New Card()
        Card11 = New Card()
        Card10 = New Card()
        Card9 = New Card()
        Card8 = New Card()
        Card7 = New Card()
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
        ' Card12
        ' 
        Card12.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card12.Location = New Point(929, 417)
        Card12.Name = "Card12"
        Card12.Padding = New Padding(5)
        Card12.Size = New Size(382, 341)
        Card12.TabIndex = 12
        ' 
        ' Card11
        ' 
        Card11.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card11.Location = New Point(492, 417)
        Card11.Name = "Card11"
        Card11.Padding = New Padding(5)
        Card11.Size = New Size(382, 341)
        Card11.TabIndex = 11
        ' 
        ' Card10
        ' 
        Card10.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card10.Location = New Point(55, 417)
        Card10.Name = "Card10"
        Card10.Padding = New Padding(5)
        Card10.Size = New Size(382, 341)
        Card10.TabIndex = 10
        ' 
        ' Card9
        ' 
        Card9.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card9.Location = New Point(929, 48)
        Card9.Name = "Card9"
        Card9.Padding = New Padding(5)
        Card9.Size = New Size(382, 341)
        Card9.TabIndex = 9
        ' 
        ' Card8
        ' 
        Card8.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card8.Location = New Point(492, 48)
        Card8.Name = "Card8"
        Card8.Padding = New Padding(5)
        Card8.Size = New Size(382, 341)
        Card8.TabIndex = 8
        ' 
        ' Card7
        ' 
        Card7.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Card7.Location = New Point(55, 48)
        Card7.Name = "Card7"
        Card7.Padding = New Padding(5)
        Card7.Size = New Size(382, 341)
        Card7.TabIndex = 7
        ' 
        ' FinalContainer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Card12)
        Controls.Add(Card11)
        Controls.Add(Card10)
        Controls.Add(Card9)
        Controls.Add(Card8)
        Controls.Add(Card7)
        Controls.Add(PictureBox1)
        Name = "FinalContainer"
        Size = New Size(1366, 768)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Card12 As Card
    Friend WithEvents Card11 As Card
    Friend WithEvents Card10 As Card
    Friend WithEvents Card9 As Card
    Friend WithEvents Card8 As Card
    Friend WithEvents Card7 As Card

End Class
