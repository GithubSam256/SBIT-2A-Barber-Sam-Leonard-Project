<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class invsystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(invsystem))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button1 = New Button()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        DataGridView4 = New DataGridView()
        DataGridView3 = New DataGridView()
        DataGridView2 = New DataGridView()
        Button2 = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        TabPage4 = New TabPage()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(3, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(944, 666)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Button1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(936, 638)
        TabPage1.TabIndex = 0
        TabPage1.Text = "DashBoard"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(936, 638)
        TabPage2.TabIndex = 1
        TabPage2.Text = "CreateProduct"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(DataGridView4)
        TabPage3.Controls.Add(DataGridView3)
        TabPage3.Controls.Add(DataGridView2)
        TabPage3.Controls.Add(Button2)
        TabPage3.Controls.Add(Label1)
        TabPage3.Controls.Add(DataGridView1)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(936, 638)
        TabPage3.TabIndex = 2
        TabPage3.Text = "View Inventory"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView4
        ' 
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Location = New Point(460, 330)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.Size = New Size(409, 289)
        DataGridView4.TabIndex = 5
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(30, 330)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(409, 289)
        DataGridView3.TabIndex = 4
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(460, 16)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(409, 289)
        DataGridView2.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(178, 82)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(64, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 16)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(378, 289)
        DataGridView1.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(936, 638)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' invsystem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(TabControl1)
        Name = "invsystem"
        Size = New Size(950, 735)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView

End Class
