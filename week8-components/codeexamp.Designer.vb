<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class codeexamp
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(codeexamp))
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(17, 57)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(291, 592)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(537, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 40)
        Label1.TabIndex = 1
        Label1.Text = "Dialogs"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(327, 390)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(329, 259)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(346, 313)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 25)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(346, 95)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 100)
        Panel1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(718, 129)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 36)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(718, 302)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 36)
        Button2.TabIndex = 5
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(718, 493)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 36)
        Button3.TabIndex = 6
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' codeexamp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Name = "codeexamp"
        Size = New Size(950, 735)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
