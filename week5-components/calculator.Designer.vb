<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calculator))
        GroupBox1 = New GroupBox()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        TextBox5 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(RadioButton8)
        GroupBox1.Controls.Add(RadioButton7)
        GroupBox1.Controls.Add(RadioButton6)
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Harlow Solid Italic", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        GroupBox1.ForeColor = SystemColors.ActiveCaption
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(315, 406)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Choose One Among Options"
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(3, 362)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(149, 30)
        RadioButton8.TabIndex = 7
        RadioButton8.TabStop = True
        RadioButton8.Text = "Sqaure Root"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(3, 320)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(196, 30)
        RadioButton7.TabIndex = 6
        RadioButton7.TabStop = True
        RadioButton7.Text = "Modulus Division"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(3, 273)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(185, 30)
        RadioButton6.TabIndex = 5
        RadioButton6.TabStop = True
        RadioButton6.Text = "Integer Division"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(3, 224)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(162, 30)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "Exponentation"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(3, 176)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(109, 30)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "Division"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(3, 130)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(165, 30)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Multiplication"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(3, 80)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(139, 30)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Subtraction"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(3, 35)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(118, 30)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Addition"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(187), CByte(220), CByte(229))
        Label1.Font = New Font("Poor Richard", 14.25F)
        Label1.Location = New Point(349, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 22)
        Label1.TabIndex = 1
        Label1.Text = "First Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(187), CByte(220), CByte(229))
        Label2.Font = New Font("Poor Richard", 14.25F)
        Label2.Location = New Point(349, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 22)
        Label2.TabIndex = 2
        Label2.Text = "Second Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(486, 199)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(202, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(486, 245)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(202, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(486, 306)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(202, 48)
        TextBox3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(187), CByte(220), CByte(229))
        Label3.Font = New Font("Poor Richard", 14.25F)
        Label3.Location = New Point(405, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 22)
        Label3.TabIndex = 6
        Label3.Text = "Result"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(187), CByte(220), CByte(229))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Ravie", 12F)
        Button1.Location = New Point(711, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 93)
        Button1.TabIndex = 7
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(486, 384)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(351, 86)
        TextBox5.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(187), CByte(220), CByte(229))
        Label4.Font = New Font("Poor Richard", 14.25F)
        Label4.Location = New Point(363, 387)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 22)
        Label4.TabIndex = 10
        Label4.Text = "Explanation"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(187), CByte(220), CByte(229))
        Label5.Font = New Font("Harlow Solid Italic", 24F, FontStyle.Bold Or FontStyle.Italic)
        Label5.Location = New Point(356, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(543, 40)
        Label5.TabIndex = 11
        Label5.Text = "Barber's Basic Arithmetic Calculator"
        ' 
        ' calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox5)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "calculator"
        Size = New Size(950, 735)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
