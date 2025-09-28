<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class polymorcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(polymorcode))
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(26, 140)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(336, 324)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(446, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 36)
        Label2.TabIndex = 10
        Label2.Text = "Polymorphism"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(368, 329)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(342, 54)
        TextBox1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(368, 400)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 44)
        Button1.TabIndex = 8
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(368, 287)
        Label1.Name = "Label1"
        Label1.Size = New Size(322, 29)
        Label1.TabIndex = 7
        Label1.Text = "Pick One: Animal, Bird, Lion, Pig"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(368, 205)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(342, 64)
        ListBox1.TabIndex = 6
        ' 
        ' polymorcode
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(199))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Controls.Add(RichTextBox1)
        Name = "polymorcode"
        Size = New Size(950, 735)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox

End Class
