<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class week8_components
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
        Button2 = New Button()
        Button1 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        Button9 = New Button()
        Button11 = New Button()
        Button13 = New Button()
        Button15 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        Button7 = New Button()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(Button2)
        FlowLayoutPanel1.Controls.Add(Button1)
        FlowLayoutPanel1.Controls.Add(Button4)
        FlowLayoutPanel1.Controls.Add(Button6)
        FlowLayoutPanel1.Controls.Add(Button9)
        FlowLayoutPanel1.Controls.Add(Button11)
        FlowLayoutPanel1.Controls.Add(Button13)
        FlowLayoutPanel1.Controls.Add(Button15)
        FlowLayoutPanel1.Controls.Add(Button3)
        FlowLayoutPanel1.Controls.Add(Button5)
        FlowLayoutPanel1.Controls.Add(Button7)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(335, 693)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(3, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(329, 47)
        Button2.TabIndex = 27
        Button2.Text = "VB.Net - Dialog Boxes" & vbLf
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 56)
        Button1.Name = "Button1"
        Button1.Size = New Size(329, 47)
        Button1.TabIndex = 15
        Button1.Text = "S.N. Control & Description" & vbLf
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(3, 109)
        Button4.Name = "Button4"
        Button4.Size = New Size(329, 47)
        Button4.TabIndex = 16
        Button4.Text = "VB.Net - ColorDialog Control" & vbLf
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(3, 162)
        Button6.Name = "Button6"
        Button6.Size = New Size(329, 47)
        Button6.TabIndex = 17
        Button6.Text = "Properties of the ColorDialog Control" & vbLf
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(3, 215)
        Button9.Name = "Button9"
        Button9.Size = New Size(329, 47)
        Button9.TabIndex = 18
        Button9.Text = "Methods of the ColorDialog Control" & vbLf
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(3, 268)
        Button11.Name = "Button11"
        Button11.Size = New Size(329, 47)
        Button11.TabIndex = 19
        Button11.Text = "Properties of the FontDialog Control" & vbLf
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button13.Location = New Point(3, 321)
        Button13.Name = "Button13"
        Button13.Size = New Size(329, 47)
        Button13.TabIndex = 20
        Button13.Text = "Methods of the FontDialog Control" & vbLf
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Location = New Point(3, 374)
        Button15.Name = "Button15"
        Button15.Size = New Size(329, 47)
        Button15.TabIndex = 24
        Button15.Text = "Following is the Open File dialog box:"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(3, 427)
        Button3.Name = "Button3"
        Button3.Size = New Size(329, 47)
        Button3.TabIndex = 25
        Button3.Text = "Properties of the OpenFileDialog Control" & vbLf
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(3, 480)
        Button5.Name = "Button5"
        Button5.Size = New Size(329, 47)
        Button5.TabIndex = 26
        Button5.Text = "Methods of the SaveFileDialog Control"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(3, 533)
        Button7.Name = "Button7"
        Button7.Size = New Size(329, 47)
        Button7.TabIndex = 28
        Button7.Text = "Example"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' week8_components
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(FlowLayoutPanel1)
        Name = "week8_components"
        Size = New Size(335, 693)
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button

End Class
