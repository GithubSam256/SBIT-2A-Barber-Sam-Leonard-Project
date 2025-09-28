<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class week5_components
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button1 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button16 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(Button1)
        FlowLayoutPanel1.Controls.Add(Button4)
        FlowLayoutPanel1.Controls.Add(Button3)
        FlowLayoutPanel1.Controls.Add(Button5)
        FlowLayoutPanel1.Controls.Add(Button6)
        FlowLayoutPanel1.Controls.Add(Button7)
        FlowLayoutPanel1.Controls.Add(Button16)
        FlowLayoutPanel1.Controls.Add(Button2)
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Controls.Add(Button9)
        FlowLayoutPanel1.Controls.Add(Button10)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(335, 693)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(329, 47)
        Button1.TabIndex = 0
        Button1.Text = "Handling Data"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(3, 56)
        Button4.Name = "Button4"
        Button4.Size = New Size(329, 47)
        Button4.TabIndex = 2
        Button4.Text = "Types of Data"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(3, 109)
        Button3.Name = "Button3"
        Button3.Size = New Size(329, 47)
        Button3.TabIndex = 4
        Button3.Text = "Naming Rules for Variables and Constants" & vbLf
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(3, 162)
        Button5.Name = "Button5"
        Button5.Size = New Size(329, 47)
        Button5.TabIndex = 6
        Button5.Text = "Declaring Variables"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(3, 215)
        Button6.Name = "Button6"
        Button6.Size = New Size(329, 47)
        Button6.TabIndex = 8
        Button6.Text = "Declaring Constants"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(3, 268)
        Button7.Name = "Button7"
        Button7.Size = New Size(329, 47)
        Button7.TabIndex = 10
        Button7.Text = "Scope of Variables and Constants" & vbLf
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Location = New Point(3, 321)
        Button16.Name = "Button16"
        Button16.Size = New Size(329, 47)
        Button16.TabIndex = 12
        Button16.Text = "Converting Output Data Types"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(3, 374)
        Button2.Name = "Button2"
        Button2.Size = New Size(329, 47)
        Button2.TabIndex = 14
        Button2.Text = "Arithmetic Operators" & vbLf
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button8)
        Panel2.Location = New Point(3, 427)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(329, 52)
        Panel2.TabIndex = 14
        Panel2.Visible = False
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(81, 0)
        Button8.Name = "Button8"
        Button8.Size = New Size(245, 43)
        Button8.TabIndex = 3
        Button8.Text = "Calculator"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(3, 485)
        Button9.Name = "Button9"
        Button9.Size = New Size(329, 47)
        Button9.TabIndex = 15
        Button9.Text = "Order of Precedence"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(3, 538)
        Button10.Name = "Button10"
        Button10.Size = New Size(329, 47)
        Button10.TabIndex = 16
        Button10.Text = "Assignment Operators and Formulas"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' week5_components
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(FlowLayoutPanel1)
        Name = "week5_components"
        Size = New Size(335, 693)
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button

End Class
