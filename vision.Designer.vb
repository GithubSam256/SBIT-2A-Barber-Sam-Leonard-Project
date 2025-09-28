<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class visionf1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(visionf1))
        vision1 = New PictureBox()
        CType(vision1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' vision1
        ' 
        vision1.Dock = DockStyle.Fill
        vision1.Image = CType(resources.GetObject("vision1.Image"), Image)
        vision1.Location = New Point(0, 0)
        vision1.Name = "vision1"
        vision1.Size = New Size(850, 500)
        vision1.TabIndex = 0
        vision1.TabStop = False
        ' 
        ' visionf1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(850, 500)
        Controls.Add(vision1)
        FormBorderStyle = FormBorderStyle.None
        Name = "visionf1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "vision"
        CType(vision1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents vision1 As PictureBox
End Class
