<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class framework
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(framework))
        RichTextBox1 = New RichTextBox()
        ListBox1 = New ListBox()
        Label1 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(23, 89)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(359, 377)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(398, 153)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(425, 64)
        ListBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(398, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 29)
        Label1.TabIndex = 2
        Label1.Text = "Pick One: Animal, Cat, Dog, Sheep"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(398, 348)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 44)
        Button1.TabIndex = 3
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(398, 277)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(342, 54)
        TextBox1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(533, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 36)
        Label2.TabIndex = 5
        Label2.Text = "Inheritance"
        ' 
        ' inheritancecoe
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
        Name = "inheritancecoe"
        Size = New Size(950, 735)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label

End Class
