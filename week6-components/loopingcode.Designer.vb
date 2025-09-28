<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loopingcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loopingcode))
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        Button2 = New Button()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(16, 38)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(238, 576)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(339, 432)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 62)
        Button1.TabIndex = 1
        Button1.Text = "Run"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(732, 432)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 62)
        Button2.TabIndex = 2
        Button2.Text = "Run"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(273, 87)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(232, 304)
        ListBox1.TabIndex = 3
        ' 
        ' ListBox2
        ' 
        ListBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 25
        ListBox2.Location = New Point(652, 87)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(232, 304)
        ListBox2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(285, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 37)
        Label1.TabIndex = 5
        Label1.Text = "Do While Loop"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(704, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 37)
        Label2.TabIndex = 6
        Label2.Text = "For Loop"
        ' 
        ' loopingcode
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Name = "loopingcode"
        Size = New Size(950, 735)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
