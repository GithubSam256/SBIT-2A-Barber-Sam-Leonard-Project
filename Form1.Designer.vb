<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ScrollPanel = New Panel()
        Section1 = New Panel()
        FinalTermButtom = New Button()
        MidtermButton = New Button()
        Header2 = New Header()
        HomeContainer1 = New HomeContainer()
        Section2 = New Panel()
        MidContainer1 = New MidContainer()
        Section3 = New Panel()
        FinalContainer1 = New FinalContainer()
        Section4 = New Panel()
        RealFinalContainer1 = New RealFinalContainer()
        Header = New Panel()
        mission = New Label()
        vision = New Label()
        aboutmebutton1 = New Label()
        BackHome = New Label()
        Label1 = New Label()
        Header1 = New Header()
        ScrollPanel.SuspendLayout()
        Section1.SuspendLayout()
        Section2.SuspendLayout()
        Section3.SuspendLayout()
        Section4.SuspendLayout()
        Header.SuspendLayout()
        SuspendLayout()
        ' 
        ' ScrollPanel
        ' 
        ScrollPanel.AutoScroll = True
        ScrollPanel.Controls.Add(Section1)
        ScrollPanel.Controls.Add(Section2)
        ScrollPanel.Controls.Add(Section3)
        ScrollPanel.Controls.Add(Section4)
        ScrollPanel.Location = New Point(0, 0)
        ScrollPanel.Name = "ScrollPanel"
        ScrollPanel.Size = New Size(1383, 830)
        ScrollPanel.TabIndex = 0
        ' 
        ' Section1
        ' 
        Section1.BackColor = SystemColors.Highlight
        Section1.Controls.Add(FinalTermButtom)
        Section1.Controls.Add(MidtermButton)
        Section1.Controls.Add(Header2)
        Section1.Controls.Add(HomeContainer1)
        Section1.Location = New Point(0, 0)
        Section1.Name = "Section1"
        Section1.Size = New Size(1366, 768)
        Section1.TabIndex = 0
        ' 
        ' FinalTermButtom
        ' 
        FinalTermButtom.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(218))
        FinalTermButtom.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(193), CByte(218))
        FinalTermButtom.FlatAppearance.BorderSize = 0
        FinalTermButtom.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(193), CByte(218))
        FinalTermButtom.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(193), CByte(218))
        FinalTermButtom.FlatStyle = FlatStyle.Flat
        FinalTermButtom.Font = New Font("Visitor TT1 BRK", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FinalTermButtom.ForeColor = Color.White
        FinalTermButtom.Location = New Point(725, 589)
        FinalTermButtom.Name = "FinalTermButtom"
        FinalTermButtom.Size = New Size(301, 108)
        FinalTermButtom.TabIndex = 3
        FinalTermButtom.Text = "FinalTerm"
        FinalTermButtom.UseVisualStyleBackColor = False
        ' 
        ' MidtermButton
        ' 
        MidtermButton.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        MidtermButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        MidtermButton.FlatAppearance.BorderSize = 0
        MidtermButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        MidtermButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(202), CByte(234))
        MidtermButton.FlatStyle = FlatStyle.Flat
        MidtermButton.Font = New Font("Visitor TT1 BRK", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MidtermButton.ForeColor = Color.White
        MidtermButton.Location = New Point(345, 589)
        MidtermButton.Name = "MidtermButton"
        MidtermButton.Size = New Size(297, 108)
        MidtermButton.TabIndex = 2
        MidtermButton.Text = "Midterm"
        MidtermButton.UseVisualStyleBackColor = False
        ' 
        ' Header2
        ' 
        Header2.Location = New Point(0, 0)
        Header2.Name = "Header2"
        Header2.Size = New Size(1366, 96)
        Header2.TabIndex = 1
        ' 
        ' HomeContainer1
        ' 
        HomeContainer1.BackColor = Color.Maroon
        HomeContainer1.Location = New Point(0, 3)
        HomeContainer1.Name = "HomeContainer1"
        HomeContainer1.Size = New Size(1383, 768)
        HomeContainer1.TabIndex = 0
        ' 
        ' Section2
        ' 
        Section2.BackColor = Color.Transparent
        Section2.Controls.Add(MidContainer1)
        Section2.Location = New Point(0, 768)
        Section2.Name = "Section2"
        Section2.Size = New Size(1366, 768)
        Section2.TabIndex = 1
        ' 
        ' MidContainer1
        ' 
        MidContainer1.Location = New Point(0, 0)
        MidContainer1.Name = "MidContainer1"
        MidContainer1.Size = New Size(1366, 768)
        MidContainer1.TabIndex = 0
        ' 
        ' Section3
        ' 
        Section3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Section3.Controls.Add(FinalContainer1)
        Section3.Location = New Point(0, 1536)
        Section3.Name = "Section3"
        Section3.Size = New Size(1366, 768)
        Section3.TabIndex = 2
        ' 
        ' FinalContainer1
        ' 
        FinalContainer1.Location = New Point(0, 0)
        FinalContainer1.Name = "FinalContainer1"
        FinalContainer1.Size = New Size(1366, 768)
        FinalContainer1.TabIndex = 0
        ' 
        ' Section4
        ' 
        Section4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Section4.Controls.Add(RealFinalContainer1)
        Section4.Location = New Point(0, 2304)
        Section4.Name = "Section4"
        Section4.Size = New Size(1366, 768)
        Section4.TabIndex = 3
        ' 
        ' RealFinalContainer1
        ' 
        RealFinalContainer1.Location = New Point(0, 0)
        RealFinalContainer1.Name = "RealFinalContainer1"
        RealFinalContainer1.Size = New Size(1366, 768)
        RealFinalContainer1.TabIndex = 0
        ' 
        ' Header
        ' 
        Header.BackgroundImage = CType(resources.GetObject("Header.BackgroundImage"), Image)
        Header.Controls.Add(mission)
        Header.Controls.Add(vision)
        Header.Controls.Add(aboutmebutton1)
        Header.Controls.Add(BackHome)
        Header.Controls.Add(Label1)
        Header.Controls.Add(Header1)
        Header.Dock = DockStyle.Top
        Header.Location = New Point(0, 0)
        Header.Name = "Header"
        Header.Size = New Size(1366, 95)
        Header.TabIndex = 5
        ' 
        ' mission
        ' 
        mission.BackColor = Color.Transparent
        mission.Location = New Point(1147, 26)
        mission.Name = "mission"
        mission.Size = New Size(106, 39)
        mission.TabIndex = 6
        ' 
        ' vision
        ' 
        vision.BackColor = Color.Transparent
        vision.Location = New Point(1006, 26)
        vision.Name = "vision"
        vision.Size = New Size(106, 39)
        vision.TabIndex = 5
        ' 
        ' aboutmebutton1
        ' 
        aboutmebutton1.BackColor = Color.Transparent
        aboutmebutton1.Cursor = Cursors.Hand
        aboutmebutton1.ForeColor = Color.Transparent
        aboutmebutton1.Location = New Point(855, 26)
        aboutmebutton1.Name = "aboutmebutton1"
        aboutmebutton1.Size = New Size(124, 39)
        aboutmebutton1.TabIndex = 3
        aboutmebutton1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BackHome
        ' 
        BackHome.BackColor = Color.Transparent
        BackHome.Cursor = Cursors.Hand
        BackHome.ForeColor = Color.White
        BackHome.Location = New Point(739, 26)
        BackHome.Name = "BackHome"
        BackHome.Size = New Size(79, 39)
        BackHome.TabIndex = 2
        BackHome.Text = "."
        BackHome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1287, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 40)
        Label1.TabIndex = 1
        Label1.Text = "."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Header1
        ' 
        Header1.Location = New Point(0, 0)
        Header1.Name = "Header1"
        Header1.Size = New Size(395, 96)
        Header1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1366, 830)
        Controls.Add(Header)
        Controls.Add(ScrollPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ScrollPanel.ResumeLayout(False)
        Section1.ResumeLayout(False)
        Section2.ResumeLayout(False)
        Section3.ResumeLayout(False)
        Section4.ResumeLayout(False)
        Header.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ScrollPanel As Panel
    Friend WithEvents Section1 As Panel
    Friend WithEvents Section2 As Panel
    Friend WithEvents Section3 As Panel
    Friend WithEvents MidContainer1 As MidContainer
    Friend WithEvents FinalContainer1 As FinalContainer
    Friend WithEvents Section4 As Panel
    Friend WithEvents RealFinalContainer1 As RealFinalContainer
    Friend WithEvents HomeContainer1 As HomeContainer
    Friend WithEvents Header As Panel
    Friend WithEvents Header1 As Header
    Friend WithEvents Label1 As Label
    Friend WithEvents Header2 As Header
    Friend WithEvents MidtermButton As Button
    Friend WithEvents FinalTermButtom As Button
    Friend WithEvents BackHome As Label
    Friend WithEvents aboutme2 As Label
    Friend WithEvents aboutmebutton1 As Label
    Friend WithEvents vision As Label
    Friend WithEvents mission As Label

End Class
