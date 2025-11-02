<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class codeexample
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(codeexample))
        RichTextBox1 = New RichTextBox()
        ListBox1 = New ListBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.Location = New Point(17, 77)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(361, 554)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Consolas", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 19
        ListBox1.Location = New Point(396, 173)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(509, 251)
        ListBox1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(396, 489)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(284, 39)
        TextBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(396, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 25)
        Label1.TabIndex = 3
        Label1.Text = "Output:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(396, 455)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 4
        Label2.Text = "Input"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(396, 543)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 50)
        Button1.TabIndex = 5
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe Script", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(400, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 46)
        Label3.TabIndex = 7
        Label3.Text = "Try Catch"
        ' 
        ' codeexample
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(199))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(RichTextBox1)
        Name = "codeexample"
        Size = New Size(950, 735)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label

End Class
