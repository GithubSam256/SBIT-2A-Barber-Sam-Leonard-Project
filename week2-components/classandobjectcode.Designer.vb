<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class classandobjectcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(classandobjectcode))
        RichTextBox1 = New RichTextBox()
        ListBox1 = New ListBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.White
        RichTextBox1.Font = New Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(14, 113)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(437, 423)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.White
        ListBox1.Font = New Font("Segoe UI", 14.25F)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(457, 188)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(372, 129)
        ListBox1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.25F)
        TextBox1.Location = New Point(457, 370)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(288, 33)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 14.25F)
        TextBox2.Location = New Point(457, 439)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(288, 33)
        TextBox2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F)
        Label1.Location = New Point(457, 340)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 4
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F)
        Label2.Location = New Point(457, 409)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 25)
        Label2.TabIndex = 5
        Label2.Text = "Age"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(457, 488)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 48)
        Button1.TabIndex = 6
        Button1.Text = "Execute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(485, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(292, 56)
        Label3.TabIndex = 7
        Label3.Text = "Class and Object"
        ' 
        ' classandobjectcode
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(199))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(RichTextBox1)
        Name = "classandobjectcode"
        Size = New Size(950, 735)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label

End Class
