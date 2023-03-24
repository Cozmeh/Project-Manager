<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectLayout
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
        components = New ComponentModel.Container()
        Layout = New GroupBox()
        ProjectSpan = New Label()
        DeploymentPanel = New Panel()
        DeployPanel = New Panel()
        DepBtn = New Button()
        dead = New Label()
        Start = New Label()
        TestPanel = New Panel()
        LeftTestSplitter = New Splitter()
        TestingPanel = New Panel()
        TestBtn = New Button()
        RightTestPanel = New Panel()
        DevPanel = New Panel()
        RightDevPanel = New Panel()
        RDevSplitter = New Splitter()
        DevelopmentPanel = New Panel()
        DevBtn = New Button()
        LDevSplitter = New Splitter()
        LeftDevPanel = New Panel()
        DesignPanel = New Panel()
        RightDesPanel = New Panel()
        RightDesSplitter = New Splitter()
        DesPanel = New Panel()
        DesignBtn = New Button()
        LeftDesSplitter = New Splitter()
        LeftDesPanel = New Panel()
        RaPanel = New Panel()
        ReqSplitter = New Splitter()
        ReqPanel = New Panel()
        ReqBtn = New Button()
        ProjectDetails = New GroupBox()
        Count = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ProjectId = New Label()
        ProjectName = New Label()
        Edit = New Button()
        Save = New Button()
        addEmp = New Button()
        ResetBtn = New Button()
        ReqTip = New ToolTip(components)
        DesTip = New ToolTip(components)
        DevTip = New ToolTip(components)
        TestTip = New ToolTip(components)
        DepTip = New ToolTip(components)
        StartDateTIp = New ToolTip(components)
        EndDateTip = New ToolTip(components)
        reqNum = New NumericUpDown()
        devNum = New NumericUpDown()
        desNum = New NumericUpDown()
        SetDays = New Button()
        UndoBtn = New Button()
        OptionsBox = New GroupBox()
        Layout.SuspendLayout()
        DeploymentPanel.SuspendLayout()
        DeployPanel.SuspendLayout()
        TestPanel.SuspendLayout()
        TestingPanel.SuspendLayout()
        DevPanel.SuspendLayout()
        DevelopmentPanel.SuspendLayout()
        DesignPanel.SuspendLayout()
        DesPanel.SuspendLayout()
        RaPanel.SuspendLayout()
        ReqPanel.SuspendLayout()
        ProjectDetails.SuspendLayout()
        CType(reqNum, ComponentModel.ISupportInitialize).BeginInit()
        CType(devNum, ComponentModel.ISupportInitialize).BeginInit()
        CType(desNum, ComponentModel.ISupportInitialize).BeginInit()
        OptionsBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' Layout
        ' 
        Layout.Controls.Add(ProjectSpan)
        Layout.Controls.Add(DeploymentPanel)
        Layout.Controls.Add(dead)
        Layout.Controls.Add(Start)
        Layout.Controls.Add(TestPanel)
        Layout.Controls.Add(DevPanel)
        Layout.Controls.Add(DesignPanel)
        Layout.Controls.Add(RaPanel)
        Layout.Font = New Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Layout.Location = New Point(12, 134)
        Layout.Name = "Layout"
        Layout.Size = New Size(776, 367)
        Layout.TabIndex = 14
        Layout.TabStop = False
        Layout.Text = "Plan Layout"' 
        ' ProjectSpan
        ' 
        ProjectSpan.AutoSize = True
        ProjectSpan.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectSpan.Location = New Point(325, 35)
        ProjectSpan.Name = "ProjectSpan"
        ProjectSpan.Size = New Size(85, 19)
        ProjectSpan.TabIndex = 7
        ProjectSpan.Text = "Project Span"' 
        ' DeploymentPanel
        ' 
        DeploymentPanel.Controls.Add(DeployPanel)
        DeploymentPanel.Location = New Point(6, 306)
        DeploymentPanel.Name = "DeploymentPanel"
        DeploymentPanel.Size = New Size(764, 50)
        DeploymentPanel.TabIndex = 6
        ' 
        ' DeployPanel
        ' 
        DeployPanel.Controls.Add(DepBtn)
        DeployPanel.Dock = DockStyle.Right
        DeployPanel.Location = New Point(682, 0)
        DeployPanel.Name = "DeployPanel"
        DeployPanel.Size = New Size(82, 50)
        DeployPanel.TabIndex = 0
        ' 
        ' DepBtn
        ' 
        DepBtn.BackColor = Color.Orchid
        DepBtn.Dock = DockStyle.Fill
        DepBtn.FlatAppearance.BorderSize = 0
        DepBtn.FlatStyle = FlatStyle.Flat
        DepBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        DepBtn.Location = New Point(0, 0)
        DepBtn.Name = "DepBtn"
        DepBtn.Size = New Size(82, 50)
        DepBtn.TabIndex = 2
        DepBtn.Text = "Deploy-ment"
        DepBtn.UseVisualStyleBackColor = False
        ' 
        ' dead
        ' 
        dead.AutoSize = True
        dead.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        dead.Location = New Point(679, 35)
        dead.Name = "dead"
        dead.Size = New Size(75, 21)
        dead.TabIndex = 5
        dead.Text = "Deadline"
        EndDateTip.SetToolTip(dead, "Project End date")
        ' 
        ' Start
        ' 
        Start.AutoSize = True
        Start.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Start.Location = New Point(6, 35)
        Start.Name = "Start"
        Start.Size = New Size(84, 21)
        Start.TabIndex = 4
        Start.Text = "Start Date"
        StartDateTIp.SetToolTip(Start, "Project Start date")
        ' 
        ' TestPanel
        ' 
        TestPanel.Controls.Add(LeftTestSplitter)
        TestPanel.Controls.Add(TestingPanel)
        TestPanel.Controls.Add(RightTestPanel)
        TestPanel.Location = New Point(6, 250)
        TestPanel.Name = "TestPanel"
        TestPanel.Size = New Size(764, 50)
        TestPanel.TabIndex = 3
        ' 
        ' LeftTestSplitter
        ' 
        LeftTestSplitter.BackColor = Color.Black
        LeftTestSplitter.Dock = DockStyle.Right
        LeftTestSplitter.Location = New Point(476, 0)
        LeftTestSplitter.Name = "LeftTestSplitter"
        LeftTestSplitter.Size = New Size(3, 50)
        LeftTestSplitter.TabIndex = 6
        LeftTestSplitter.TabStop = False
        ' 
        ' TestingPanel
        ' 
        TestingPanel.Controls.Add(TestBtn)
        TestingPanel.Dock = DockStyle.Right
        TestingPanel.Location = New Point(479, 0)
        TestingPanel.Name = "TestingPanel"
        TestingPanel.Size = New Size(203, 50)
        TestingPanel.TabIndex = 5
        ' 
        ' TestBtn
        ' 
        TestBtn.BackColor = Color.MediumPurple
        TestBtn.Dock = DockStyle.Fill
        TestBtn.FlatAppearance.BorderSize = 0
        TestBtn.FlatStyle = FlatStyle.Flat
        TestBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TestBtn.Location = New Point(0, 0)
        TestBtn.Name = "TestBtn"
        TestBtn.Size = New Size(203, 50)
        TestBtn.TabIndex = 0
        TestBtn.Text = "Testing"
        TestBtn.UseVisualStyleBackColor = False
        ' 
        ' RightTestPanel
        ' 
        RightTestPanel.BackColor = SystemColors.Control
        RightTestPanel.Dock = DockStyle.Right
        RightTestPanel.Location = New Point(682, 0)
        RightTestPanel.Name = "RightTestPanel"
        RightTestPanel.Size = New Size(82, 50)
        RightTestPanel.TabIndex = 2
        ' 
        ' DevPanel
        ' 
        DevPanel.Controls.Add(RightDevPanel)
        DevPanel.Controls.Add(RDevSplitter)
        DevPanel.Controls.Add(DevelopmentPanel)
        DevPanel.Controls.Add(LDevSplitter)
        DevPanel.Controls.Add(LeftDevPanel)
        DevPanel.Location = New Point(6, 194)
        DevPanel.Name = "DevPanel"
        DevPanel.Size = New Size(682, 50)
        DevPanel.TabIndex = 2
        ' 
        ' RightDevPanel
        ' 
        RightDevPanel.BackColor = SystemColors.Control
        RightDevPanel.Dock = DockStyle.Fill
        RightDevPanel.Location = New Point(322, 0)
        RightDevPanel.Name = "RightDevPanel"
        RightDevPanel.Size = New Size(360, 50)
        RightDevPanel.TabIndex = 5
        ' 
        ' RDevSplitter
        ' 
        RDevSplitter.BackColor = Color.Black
        RDevSplitter.Location = New Point(319, 0)
        RDevSplitter.Name = "RDevSplitter"
        RDevSplitter.Size = New Size(3, 50)
        RDevSplitter.TabIndex = 3
        RDevSplitter.TabStop = False
        ' 
        ' DevelopmentPanel
        ' 
        DevelopmentPanel.Controls.Add(DevBtn)
        DevelopmentPanel.Dock = DockStyle.Left
        DevelopmentPanel.Location = New Point(209, 0)
        DevelopmentPanel.Name = "DevelopmentPanel"
        DevelopmentPanel.Size = New Size(110, 50)
        DevelopmentPanel.TabIndex = 2
        ' 
        ' DevBtn
        ' 
        DevBtn.AutoSize = True
        DevBtn.BackColor = Color.LightSeaGreen
        DevBtn.Dock = DockStyle.Fill
        DevBtn.FlatAppearance.BorderSize = 0
        DevBtn.FlatStyle = FlatStyle.Flat
        DevBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        DevBtn.Location = New Point(0, 0)
        DevBtn.Name = "DevBtn"
        DevBtn.Size = New Size(110, 50)
        DevBtn.TabIndex = 0
        DevBtn.Text = "Development"
        DevBtn.UseVisualStyleBackColor = False
        ' 
        ' LDevSplitter
        ' 
        LDevSplitter.BackColor = Color.Black
        LDevSplitter.Location = New Point(206, 0)
        LDevSplitter.Name = "LDevSplitter"
        LDevSplitter.Size = New Size(3, 50)
        LDevSplitter.TabIndex = 1
        LDevSplitter.TabStop = False
        ' 
        ' LeftDevPanel
        ' 
        LeftDevPanel.BackColor = SystemColors.Control
        LeftDevPanel.Dock = DockStyle.Left
        LeftDevPanel.Location = New Point(0, 0)
        LeftDevPanel.MaximumSize = New Size(650, 50)
        LeftDevPanel.Name = "LeftDevPanel"
        LeftDevPanel.Size = New Size(206, 50)
        LeftDevPanel.TabIndex = 0
        ' 
        ' DesignPanel
        ' 
        DesignPanel.Controls.Add(RightDesPanel)
        DesignPanel.Controls.Add(RightDesSplitter)
        DesignPanel.Controls.Add(DesPanel)
        DesignPanel.Controls.Add(LeftDesSplitter)
        DesignPanel.Controls.Add(LeftDesPanel)
        DesignPanel.Location = New Point(6, 138)
        DesignPanel.Name = "DesignPanel"
        DesignPanel.Size = New Size(682, 50)
        DesignPanel.TabIndex = 1
        ' 
        ' RightDesPanel
        ' 
        RightDesPanel.BackColor = SystemColors.Control
        RightDesPanel.Dock = DockStyle.Fill
        RightDesPanel.Location = New Point(209, 0)
        RightDesPanel.Name = "RightDesPanel"
        RightDesPanel.Size = New Size(473, 50)
        RightDesPanel.TabIndex = 7
        ' 
        ' RightDesSplitter
        ' 
        RightDesSplitter.BackColor = Color.Black
        RightDesSplitter.Location = New Point(206, 0)
        RightDesSplitter.Name = "RightDesSplitter"
        RightDesSplitter.Size = New Size(3, 50)
        RightDesSplitter.TabIndex = 6
        RightDesSplitter.TabStop = False
        ' 
        ' DesPanel
        ' 
        DesPanel.Controls.Add(DesignBtn)
        DesPanel.Dock = DockStyle.Left
        DesPanel.Location = New Point(108, 0)
        DesPanel.Name = "DesPanel"
        DesPanel.Size = New Size(98, 50)
        DesPanel.TabIndex = 5
        ' 
        ' DesignBtn
        ' 
        DesignBtn.AutoSize = True
        DesignBtn.BackColor = Color.YellowGreen
        DesignBtn.Dock = DockStyle.Fill
        DesignBtn.FlatAppearance.BorderSize = 0
        DesignBtn.FlatStyle = FlatStyle.Flat
        DesignBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        DesignBtn.Location = New Point(0, 0)
        DesignBtn.Name = "DesignBtn"
        DesignBtn.Size = New Size(98, 50)
        DesignBtn.TabIndex = 0
        DesignBtn.Text = "Design"
        DesignBtn.UseVisualStyleBackColor = False
        ' 
        ' LeftDesSplitter
        ' 
        LeftDesSplitter.BackColor = Color.Black
        LeftDesSplitter.Location = New Point(105, 0)
        LeftDesSplitter.Name = "LeftDesSplitter"
        LeftDesSplitter.Size = New Size(3, 50)
        LeftDesSplitter.TabIndex = 4
        LeftDesSplitter.TabStop = False
        ' 
        ' LeftDesPanel
        ' 
        LeftDesPanel.BackColor = SystemColors.Control
        LeftDesPanel.Dock = DockStyle.Left
        LeftDesPanel.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        LeftDesPanel.Location = New Point(0, 0)
        LeftDesPanel.Name = "LeftDesPanel"
        LeftDesPanel.Size = New Size(105, 50)
        LeftDesPanel.TabIndex = 0
        ' 
        ' RaPanel
        ' 
        RaPanel.Controls.Add(ReqSplitter)
        RaPanel.Controls.Add(ReqPanel)
        RaPanel.Location = New Point(6, 82)
        RaPanel.Name = "RaPanel"
        RaPanel.Size = New Size(682, 50)
        RaPanel.TabIndex = 0
        ' 
        ' ReqSplitter
        ' 
        ReqSplitter.BackColor = Color.Black
        ReqSplitter.Location = New Point(209, 0)
        ReqSplitter.Name = "ReqSplitter"
        ReqSplitter.Size = New Size(3, 50)
        ReqSplitter.TabIndex = 1
        ReqSplitter.TabStop = False
        ' 
        ' ReqPanel
        ' 
        ReqPanel.Controls.Add(ReqBtn)
        ReqPanel.Dock = DockStyle.Left
        ReqPanel.Location = New Point(0, 0)
        ReqPanel.Name = "ReqPanel"
        ReqPanel.Size = New Size(209, 50)
        ReqPanel.TabIndex = 0
        ' 
        ' ReqBtn
        ' 
        ReqBtn.AutoSize = True
        ReqBtn.BackColor = Color.Tomato
        ReqBtn.Dock = DockStyle.Fill
        ReqBtn.FlatAppearance.BorderSize = 0
        ReqBtn.FlatStyle = FlatStyle.Flat
        ReqBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ReqBtn.Location = New Point(0, 0)
        ReqBtn.Name = "ReqBtn"
        ReqBtn.Size = New Size(209, 50)
        ReqBtn.TabIndex = 0
        ReqBtn.Text = "Requirment"
        ReqBtn.UseVisualStyleBackColor = False
        ' 
        ' ProjectDetails
        ' 
        ProjectDetails.Controls.Add(Count)
        ProjectDetails.Controls.Add(Label1)
        ProjectDetails.Controls.Add(Label2)
        ProjectDetails.Controls.Add(Label3)
        ProjectDetails.Controls.Add(ProjectId)
        ProjectDetails.Controls.Add(ProjectName)
        ProjectDetails.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        ProjectDetails.Location = New Point(12, 12)
        ProjectDetails.Name = "ProjectDetails"
        ProjectDetails.Size = New Size(297, 119)
        ProjectDetails.TabIndex = 13
        ProjectDetails.TabStop = False
        ProjectDetails.Text = "Project Details"' 
        ' Count
        ' 
        Count.AutoSize = True
        Count.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Count.Location = New Point(94, 85)
        Count.Name = "Count"
        Count.Size = New Size(23, 25)
        Count.TabIndex = 6
        Count.Text = "2"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(6, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 21)
        Label1.TabIndex = 0
        Label1.Text = "Project Id :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(29, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 21)
        Label2.TabIndex = 1
        Label2.Text = "Name :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(25, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 2
        Label3.Text = "People :"' 
        ' ProjectId
        ' 
        ProjectId.AutoSize = True
        ProjectId.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ProjectId.Location = New Point(94, 24)
        ProjectId.Name = "ProjectId"
        ProjectId.Size = New Size(94, 25)
        ProjectId.TabIndex = 4
        ProjectId.Text = "Project Id"' 
        ' ProjectName
        ' 
        ProjectName.AutoSize = True
        ProjectName.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ProjectName.Location = New Point(94, 55)
        ProjectName.Name = "ProjectName"
        ProjectName.Size = New Size(129, 25)
        ProjectName.TabIndex = 5
        ProjectName.Text = "Project Name"' 
        ' Edit
        ' 
        Edit.BackColor = Color.Silver
        Edit.FlatAppearance.BorderSize = 0
        Edit.FlatStyle = FlatStyle.Flat
        Edit.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Edit.Image = My.Resources.Resources.Edit
        Edit.ImageAlign = ContentAlignment.MiddleRight
        Edit.Location = New Point(133, 20)
        Edit.Name = "Edit"
        Edit.Size = New Size(100, 42)
        Edit.TabIndex = 16
        Edit.Text = " Edit"
        Edit.TextAlign = ContentAlignment.MiddleLeft
        Edit.UseVisualStyleBackColor = False
        ' 
        ' Save
        ' 
        Save.BackColor = Color.Silver
        Save.FlatAppearance.BorderSize = 0
        Save.FlatStyle = FlatStyle.Flat
        Save.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Save.Image = My.Resources.Resources.save2
        Save.ImageAlign = ContentAlignment.MiddleRight
        Save.Location = New Point(15, 20)
        Save.Name = "Save"
        Save.Size = New Size(100, 42)
        Save.TabIndex = 15
        Save.Text = " Save"
        Save.TextAlign = ContentAlignment.MiddleLeft
        Save.UseVisualStyleBackColor = False
        ' 
        ' addEmp
        ' 
        addEmp.BackColor = Color.Silver
        addEmp.FlatAppearance.BorderSize = 0
        addEmp.FlatStyle = FlatStyle.Flat
        addEmp.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        addEmp.Location = New Point(290, 74)
        addEmp.Name = "addEmp"
        addEmp.Size = New Size(169, 36)
        addEmp.TabIndex = 17
        addEmp.Text = "Add Contributors"
        addEmp.UseVisualStyleBackColor = False
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.Silver
        ResetBtn.FlatAppearance.BorderSize = 0
        ResetBtn.FlatStyle = FlatStyle.Flat
        ResetBtn.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.Image = My.Resources.Resources.reset1
        ResetBtn.ImageAlign = ContentAlignment.MiddleRight
        ResetBtn.Location = New Point(359, 20)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(100, 42)
        ResetBtn.TabIndex = 18
        ResetBtn.Text = " Reset"
        ResetBtn.TextAlign = ContentAlignment.MiddleLeft
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' ReqTip
        ' 
        ReqTip.ToolTipTitle = "Requirment EndDate"' 
        ' DesTip
        ' 
        DesTip.ToolTipTitle = "Design EndDate"' 
        ' DevTip
        ' 
        DevTip.ToolTipTitle = "Development EndDate"' 
        ' TestTip
        ' 
        TestTip.ToolTipTitle = "Testing EndDate"' 
        ' DepTip
        ' 
        DepTip.ToolTipTitle = "Deployment EndDate"' 
        ' reqNum
        ' 
        reqNum.BackColor = Color.Tomato
        reqNum.Cursor = Cursors.Hand
        reqNum.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        reqNum.Location = New Point(15, 74)
        reqNum.Minimum = New [Decimal](New Integer() {4, 0, 0, 0})
        reqNum.Name = "reqNum"
        reqNum.Size = New Size(53, 34)
        reqNum.TabIndex = 19
        reqNum.Value = New [Decimal](New Integer() {5, 0, 0, 0})
        ' 
        ' devNum
        ' 
        devNum.BackColor = Color.LightSeaGreen
        devNum.Cursor = Cursors.Hand
        devNum.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        devNum.Location = New Point(133, 74)
        devNum.Minimum = New [Decimal](New Integer() {8, 0, 0, 0})
        devNum.Name = "devNum"
        devNum.Size = New Size(53, 34)
        devNum.TabIndex = 21
        devNum.Value = New [Decimal](New Integer() {9, 0, 0, 0})
        ' 
        ' desNum
        ' 
        desNum.BackColor = Color.YellowGreen
        desNum.Cursor = Cursors.Hand
        desNum.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        desNum.Location = New Point(74, 74)
        desNum.Minimum = New [Decimal](New Integer() {5, 0, 0, 0})
        desNum.Name = "desNum"
        desNum.Size = New Size(53, 34)
        desNum.TabIndex = 22
        desNum.Value = New [Decimal](New Integer() {6, 0, 0, 0})
        ' 
        ' SetDays
        ' 
        SetDays.BackColor = Color.Silver
        SetDays.FlatAppearance.BorderSize = 0
        SetDays.FlatStyle = FlatStyle.Flat
        SetDays.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        SetDays.Location = New Point(192, 74)
        SetDays.Name = "SetDays"
        SetDays.Size = New Size(92, 35)
        SetDays.TabIndex = 23
        SetDays.Text = "Set Days"
        SetDays.UseVisualStyleBackColor = False
        ' 
        ' UndoBtn
        ' 
        UndoBtn.BackColor = Color.Silver
        UndoBtn.FlatAppearance.BorderSize = 0
        UndoBtn.FlatStyle = FlatStyle.Flat
        UndoBtn.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        UndoBtn.Image = My.Resources.Resources.undo
        UndoBtn.ImageAlign = ContentAlignment.MiddleRight
        UndoBtn.Location = New Point(246, 20)
        UndoBtn.Name = "UndoBtn"
        UndoBtn.Size = New Size(100, 42)
        UndoBtn.TabIndex = 24
        UndoBtn.Text = " Undo"
        UndoBtn.TextAlign = ContentAlignment.MiddleLeft
        UndoBtn.UseVisualStyleBackColor = False
        ' 
        ' OptionsBox
        ' 
        OptionsBox.Controls.Add(UndoBtn)
        OptionsBox.Controls.Add(Edit)
        OptionsBox.Controls.Add(SetDays)
        OptionsBox.Controls.Add(Save)
        OptionsBox.Controls.Add(desNum)
        OptionsBox.Controls.Add(addEmp)
        OptionsBox.Controls.Add(devNum)
        OptionsBox.Controls.Add(ResetBtn)
        OptionsBox.Controls.Add(reqNum)
        OptionsBox.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        OptionsBox.Location = New Point(315, 12)
        OptionsBox.Name = "OptionsBox"
        OptionsBox.Size = New Size(474, 119)
        OptionsBox.TabIndex = 25
        OptionsBox.TabStop = False
        OptionsBox.Text = "Options"' 
        ' ProjectLayout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 505)
        Controls.Add(OptionsBox)
        Controls.Add(Layout)
        Controls.Add(ProjectDetails)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "ProjectLayout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProjectLayout"
        Layout.ResumeLayout(False)
        Layout.PerformLayout()
        DeploymentPanel.ResumeLayout(False)
        DeployPanel.ResumeLayout(False)
        TestPanel.ResumeLayout(False)
        TestingPanel.ResumeLayout(False)
        DevPanel.ResumeLayout(False)
        DevelopmentPanel.ResumeLayout(False)
        DevelopmentPanel.PerformLayout()
        DesignPanel.ResumeLayout(False)
        DesPanel.ResumeLayout(False)
        DesPanel.PerformLayout()
        RaPanel.ResumeLayout(False)
        ReqPanel.ResumeLayout(False)
        ReqPanel.PerformLayout()
        ProjectDetails.ResumeLayout(False)
        ProjectDetails.PerformLayout()
        CType(reqNum, ComponentModel.ISupportInitialize).EndInit()
        CType(devNum, ComponentModel.ISupportInitialize).EndInit()
        CType(desNum, ComponentModel.ISupportInitialize).EndInit()
        OptionsBox.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Layout As GroupBox
    Friend WithEvents ProjectDetails As GroupBox
    Friend WithEvents Count As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProjectId As Label
    Friend WithEvents ProjectName As Label
    Friend WithEvents Edit As Button
    Friend WithEvents Save As Button
    Friend WithEvents addEmp As Button
    Friend WithEvents TestPanel As Panel
    Friend WithEvents DevPanel As Panel
    Friend WithEvents DesignPanel As Panel
    Friend WithEvents RaPanel As Panel
    Friend WithEvents ReqSplitter As Splitter
    Friend WithEvents ReqPanel As Panel
    Friend WithEvents ReqBtn As Button
    Friend WithEvents LeftDesPanel As Panel
    Friend WithEvents LeftDesSplitter As Splitter
    Friend WithEvents DesPanel As Panel
    Friend WithEvents DesignBtn As Button
    Friend WithEvents RightDesSplitter As Splitter
    Friend WithEvents RightDesPanel As Panel
    Friend WithEvents LeftDevPanel As Panel
    Friend WithEvents RDevSplitter As Splitter
    Friend WithEvents DevelopmentPanel As Panel
    Friend WithEvents DevBtn As Button
    Friend WithEvents LDevSplitter As Splitter
    Friend WithEvents ResetBtn As Button
    Friend WithEvents RightTestPanel As Panel
    Friend WithEvents Start As Label
    Friend WithEvents dead As Label
    Friend WithEvents DeploymentPanel As Panel
    Friend WithEvents DeployPanel As Panel
    Friend WithEvents DepBtn As Button
    Friend WithEvents LeftTestSplitter As Splitter
    Friend WithEvents TestingPanel As Panel
    Friend WithEvents TestBtn As Button
    Friend WithEvents RightDevPanel As Panel
    Friend WithEvents ReqTip As ToolTip
    Friend WithEvents DesTip As ToolTip
    Friend WithEvents DevTip As ToolTip
    Friend WithEvents TestTip As ToolTip
    Friend WithEvents DepTip As ToolTip
    Friend WithEvents ProjectSpan As Label
    Friend WithEvents StartDateTIp As ToolTip
    Friend WithEvents EndDateTip As ToolTip
    Friend WithEvents reqNum As NumericUpDown
    Friend WithEvents devNum As NumericUpDown
    Friend WithEvents desNum As NumericUpDown
    Friend WithEvents SetDays As Button
    Friend WithEvents UndoBtn As Button
    Friend WithEvents OptionsBox As GroupBox
End Class
