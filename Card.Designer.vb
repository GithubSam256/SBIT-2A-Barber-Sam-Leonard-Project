<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Card
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
        ImageContainer = New Panel()
        ImageLabel = New Label()
        WeekLabel = New Label()
        DescriptionLabel = New Label()
        StatusLabel = New Label()
        ImageContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageContainer
        ' 
        ImageContainer.BackColor = Color.White
        ImageContainer.Controls.Add(ImageLabel)
        ImageContainer.Location = New Point(8, 8)
        ImageContainer.Name = "ImageContainer"
        ImageContainer.Size = New Size(363, 157)
        ImageContainer.TabIndex = 0
        ' 
        ' ImageLabel
        ' 
        ImageLabel.AutoSize = True
        ImageLabel.Font = New Font("Visitor TT1 BRK", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ImageLabel.ForeColor = Color.FromArgb(CByte(255), CByte(120), CByte(191))
        ImageLabel.Location = New Point(122, 59)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Padding = New Padding(0, 5, 0, 0)
        ImageLabel.Size = New Size(130, 38)
        ImageLabel.TabIndex = 2
        ImageLabel.Text = "Image"
        ' 
        ' WeekLabel
        ' 
        WeekLabel.AutoSize = True
        WeekLabel.Font = New Font("Visitor TT1 BRK", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WeekLabel.ForeColor = Color.FromArgb(CByte(255), CByte(120), CByte(191))
        WeekLabel.Location = New Point(8, 168)
        WeekLabel.Name = "WeekLabel"
        WeekLabel.Padding = New Padding(0, 5, 0, 0)
        WeekLabel.Size = New Size(119, 38)
        WeekLabel.TabIndex = 1
        WeekLabel.Text = "Week1"
        ' 
        ' DescriptionLabel
        ' 
        DescriptionLabel.Font = New Font("Visitor TT1 BRK", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DescriptionLabel.ForeColor = Color.White
        DescriptionLabel.Location = New Point(8, 206)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Padding = New Padding(0, 5, 0, 5)
        DescriptionLabel.Size = New Size(366, 130)
        DescriptionLabel.TabIndex = 2
        DescriptionLabel.Text = "Object-Oriented Programming (OOP) in VB.NET is a programming paradigm that organizes software design around ""objects"" rather than functions and logic."
        ' 
        ' StatusLabel
        ' 
        StatusLabel.BackColor = Color.White
        StatusLabel.Font = New Font("Visitor TT1 BRK", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusLabel.ForeColor = Color.FromArgb(CByte(255), CByte(169), CByte(231))
        StatusLabel.Location = New Point(254, 177)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Padding = New Padding(0, 5, 0, 0)
        StatusLabel.Size = New Size(117, 29)
        StatusLabel.TabIndex = 3
        StatusLabel.Text = "Done (✓)"
        StatusLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Card
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        Controls.Add(StatusLabel)
        Controls.Add(DescriptionLabel)
        Controls.Add(WeekLabel)
        Controls.Add(ImageContainer)
        Name = "Card"
        Padding = New Padding(5)
        Size = New Size(382, 341)
        ImageContainer.ResumeLayout(False)
        ImageContainer.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageContainer As Panel
    Friend WithEvents WeekLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents ImageLabel As Label

End Class
