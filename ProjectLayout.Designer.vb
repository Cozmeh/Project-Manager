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
        Me.components = New System.ComponentModel.Container()
        Me.Layout = New System.Windows.Forms.GroupBox()
        Me.ProjectSpan = New System.Windows.Forms.Label()
        Me.DeploymentPanel = New System.Windows.Forms.Panel()
        Me.DeployPanel = New System.Windows.Forms.Panel()
        Me.DepBtn = New System.Windows.Forms.Button()
        Me.dead = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Label()
        Me.TestPanel = New System.Windows.Forms.Panel()
        Me.LeftTestSplitter = New System.Windows.Forms.Splitter()
        Me.TestingPanel = New System.Windows.Forms.Panel()
        Me.TestBtn = New System.Windows.Forms.Button()
        Me.RightTestPanel = New System.Windows.Forms.Panel()
        Me.DevPanel = New System.Windows.Forms.Panel()
        Me.RightDevPanel = New System.Windows.Forms.Panel()
        Me.RDevSplitter = New System.Windows.Forms.Splitter()
        Me.DevelopmentPanel = New System.Windows.Forms.Panel()
        Me.DevBtn = New System.Windows.Forms.Button()
        Me.LDevSplitter = New System.Windows.Forms.Splitter()
        Me.LeftDevPanel = New System.Windows.Forms.Panel()
        Me.DesignPanel = New System.Windows.Forms.Panel()
        Me.RightDesPanel = New System.Windows.Forms.Panel()
        Me.RightDesSplitter = New System.Windows.Forms.Splitter()
        Me.DesPanel = New System.Windows.Forms.Panel()
        Me.DesignBtn = New System.Windows.Forms.Button()
        Me.LeftDesSplitter = New System.Windows.Forms.Splitter()
        Me.LeftDesPanel = New System.Windows.Forms.Panel()
        Me.RaPanel = New System.Windows.Forms.Panel()
        Me.ReqSplitter = New System.Windows.Forms.Splitter()
        Me.ReqPanel = New System.Windows.Forms.Panel()
        Me.ReqBtn = New System.Windows.Forms.Button()
        Me.ProjectDetails = New System.Windows.Forms.GroupBox()
        Me.Count = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProjectId = New System.Windows.Forms.Label()
        Me.ProjectName = New System.Windows.Forms.Label()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.addEmp = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.ReqTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DesTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DevTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TestTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DepTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Layout.SuspendLayout()
        Me.DeploymentPanel.SuspendLayout()
        Me.DeployPanel.SuspendLayout()
        Me.TestPanel.SuspendLayout()
        Me.TestingPanel.SuspendLayout()
        Me.DevPanel.SuspendLayout()
        Me.DevelopmentPanel.SuspendLayout()
        Me.DesignPanel.SuspendLayout()
        Me.DesPanel.SuspendLayout()
        Me.RaPanel.SuspendLayout()
        Me.ReqPanel.SuspendLayout()
        Me.ProjectDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Layout
        '
        Me.Layout.Controls.Add(Me.ProjectSpan)
        Me.Layout.Controls.Add(Me.DeploymentPanel)
        Me.Layout.Controls.Add(Me.dead)
        Me.Layout.Controls.Add(Me.Start)
        Me.Layout.Controls.Add(Me.TestPanel)
        Me.Layout.Controls.Add(Me.DevPanel)
        Me.Layout.Controls.Add(Me.DesignPanel)
        Me.Layout.Controls.Add(Me.RaPanel)
        Me.Layout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Layout.Location = New System.Drawing.Point(12, 134)
        Me.Layout.Name = "Layout"
        Me.Layout.Size = New System.Drawing.Size(776, 367)
        Me.Layout.TabIndex = 14
        Me.Layout.TabStop = False
        Me.Layout.Text = "Plan Layout"
        '
        'ProjectSpan
        '
        Me.ProjectSpan.AutoSize = True
        Me.ProjectSpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectSpan.Location = New System.Drawing.Point(325, 50)
        Me.ProjectSpan.Name = "ProjectSpan"
        Me.ProjectSpan.Size = New System.Drawing.Size(85, 19)
        Me.ProjectSpan.TabIndex = 7
        Me.ProjectSpan.Text = "Project Span"
        '
        'DeploymentPanel
        '
        Me.DeploymentPanel.Controls.Add(Me.DeployPanel)
        Me.DeploymentPanel.Location = New System.Drawing.Point(6, 306)
        Me.DeploymentPanel.Name = "DeploymentPanel"
        Me.DeploymentPanel.Size = New System.Drawing.Size(764, 50)
        Me.DeploymentPanel.TabIndex = 6
        '
        'DeployPanel
        '
        Me.DeployPanel.Controls.Add(Me.DepBtn)
        Me.DeployPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeployPanel.Location = New System.Drawing.Point(682, 0)
        Me.DeployPanel.Name = "DeployPanel"
        Me.DeployPanel.Size = New System.Drawing.Size(82, 50)
        Me.DeployPanel.TabIndex = 0
        '
        'DepBtn
        '
        Me.DepBtn.BackColor = System.Drawing.Color.Orchid
        Me.DepBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DepBtn.FlatAppearance.BorderSize = 0
        Me.DepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DepBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DepBtn.Location = New System.Drawing.Point(0, 0)
        Me.DepBtn.Name = "DepBtn"
        Me.DepBtn.Size = New System.Drawing.Size(82, 50)
        Me.DepBtn.TabIndex = 2
        Me.DepBtn.Text = "Deploy-ment"
        Me.DepBtn.UseVisualStyleBackColor = False
        '
        'dead
        '
        Me.dead.AutoSize = True
        Me.dead.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.dead.Location = New System.Drawing.Point(664, 44)
        Me.dead.Name = "dead"
        Me.dead.Size = New System.Drawing.Size(89, 25)
        Me.dead.TabIndex = 5
        Me.dead.Text = "Deadline"
        '
        'Start
        '
        Me.Start.AutoSize = True
        Me.Start.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Start.Location = New System.Drawing.Point(6, 44)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(101, 25)
        Me.Start.TabIndex = 4
        Me.Start.Text = "Start Date"
        '
        'TestPanel
        '
        Me.TestPanel.Controls.Add(Me.LeftTestSplitter)
        Me.TestPanel.Controls.Add(Me.TestingPanel)
        Me.TestPanel.Controls.Add(Me.RightTestPanel)
        Me.TestPanel.Location = New System.Drawing.Point(6, 250)
        Me.TestPanel.Name = "TestPanel"
        Me.TestPanel.Size = New System.Drawing.Size(764, 50)
        Me.TestPanel.TabIndex = 3
        '
        'LeftTestSplitter
        '
        Me.LeftTestSplitter.BackColor = System.Drawing.Color.Black
        Me.LeftTestSplitter.Dock = System.Windows.Forms.DockStyle.Right
        Me.LeftTestSplitter.Location = New System.Drawing.Point(476, 0)
        Me.LeftTestSplitter.Name = "LeftTestSplitter"
        Me.LeftTestSplitter.Size = New System.Drawing.Size(3, 50)
        Me.LeftTestSplitter.TabIndex = 6
        Me.LeftTestSplitter.TabStop = False
        '
        'TestingPanel
        '
        Me.TestingPanel.Controls.Add(Me.TestBtn)
        Me.TestingPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.TestingPanel.Location = New System.Drawing.Point(479, 0)
        Me.TestingPanel.Name = "TestingPanel"
        Me.TestingPanel.Size = New System.Drawing.Size(203, 50)
        Me.TestingPanel.TabIndex = 5
        '
        'TestBtn
        '
        Me.TestBtn.BackColor = System.Drawing.Color.MediumPurple
        Me.TestBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TestBtn.FlatAppearance.BorderSize = 0
        Me.TestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TestBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TestBtn.Location = New System.Drawing.Point(0, 0)
        Me.TestBtn.Name = "TestBtn"
        Me.TestBtn.Size = New System.Drawing.Size(203, 50)
        Me.TestBtn.TabIndex = 0
        Me.TestBtn.Text = "Testing"
        Me.TestBtn.UseVisualStyleBackColor = False
        '
        'RightTestPanel
        '
        Me.RightTestPanel.BackColor = System.Drawing.SystemColors.Control
        Me.RightTestPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightTestPanel.Location = New System.Drawing.Point(682, 0)
        Me.RightTestPanel.Name = "RightTestPanel"
        Me.RightTestPanel.Size = New System.Drawing.Size(82, 50)
        Me.RightTestPanel.TabIndex = 2
        '
        'DevPanel
        '
        Me.DevPanel.Controls.Add(Me.RightDevPanel)
        Me.DevPanel.Controls.Add(Me.RDevSplitter)
        Me.DevPanel.Controls.Add(Me.DevelopmentPanel)
        Me.DevPanel.Controls.Add(Me.LDevSplitter)
        Me.DevPanel.Controls.Add(Me.LeftDevPanel)
        Me.DevPanel.Location = New System.Drawing.Point(6, 194)
        Me.DevPanel.Name = "DevPanel"
        Me.DevPanel.Size = New System.Drawing.Size(682, 50)
        Me.DevPanel.TabIndex = 2
        '
        'RightDevPanel
        '
        Me.RightDevPanel.BackColor = System.Drawing.SystemColors.Control
        Me.RightDevPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightDevPanel.Location = New System.Drawing.Point(322, 0)
        Me.RightDevPanel.Name = "RightDevPanel"
        Me.RightDevPanel.Size = New System.Drawing.Size(360, 50)
        Me.RightDevPanel.TabIndex = 5
        '
        'RDevSplitter
        '
        Me.RDevSplitter.BackColor = System.Drawing.Color.Black
        Me.RDevSplitter.Location = New System.Drawing.Point(319, 0)
        Me.RDevSplitter.Name = "RDevSplitter"
        Me.RDevSplitter.Size = New System.Drawing.Size(3, 50)
        Me.RDevSplitter.TabIndex = 3
        Me.RDevSplitter.TabStop = False
        '
        'DevelopmentPanel
        '
        Me.DevelopmentPanel.Controls.Add(Me.DevBtn)
        Me.DevelopmentPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DevelopmentPanel.Location = New System.Drawing.Point(209, 0)
        Me.DevelopmentPanel.Name = "DevelopmentPanel"
        Me.DevelopmentPanel.Size = New System.Drawing.Size(110, 50)
        Me.DevelopmentPanel.TabIndex = 2
        '
        'DevBtn
        '
        Me.DevBtn.AutoSize = True
        Me.DevBtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.DevBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DevBtn.FlatAppearance.BorderSize = 0
        Me.DevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DevBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DevBtn.Location = New System.Drawing.Point(0, 0)
        Me.DevBtn.Name = "DevBtn"
        Me.DevBtn.Size = New System.Drawing.Size(110, 50)
        Me.DevBtn.TabIndex = 0
        Me.DevBtn.Text = "Development"
        Me.DevBtn.UseVisualStyleBackColor = False
        '
        'LDevSplitter
        '
        Me.LDevSplitter.BackColor = System.Drawing.Color.Black
        Me.LDevSplitter.Location = New System.Drawing.Point(206, 0)
        Me.LDevSplitter.Name = "LDevSplitter"
        Me.LDevSplitter.Size = New System.Drawing.Size(3, 50)
        Me.LDevSplitter.TabIndex = 1
        Me.LDevSplitter.TabStop = False
        '
        'LeftDevPanel
        '
        Me.LeftDevPanel.BackColor = System.Drawing.SystemColors.Control
        Me.LeftDevPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftDevPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftDevPanel.Name = "LeftDevPanel"
        Me.LeftDevPanel.Size = New System.Drawing.Size(206, 50)
        Me.LeftDevPanel.TabIndex = 0
        '
        'DesignPanel
        '
        Me.DesignPanel.Controls.Add(Me.RightDesPanel)
        Me.DesignPanel.Controls.Add(Me.RightDesSplitter)
        Me.DesignPanel.Controls.Add(Me.DesPanel)
        Me.DesignPanel.Controls.Add(Me.LeftDesSplitter)
        Me.DesignPanel.Controls.Add(Me.LeftDesPanel)
        Me.DesignPanel.Location = New System.Drawing.Point(6, 138)
        Me.DesignPanel.Name = "DesignPanel"
        Me.DesignPanel.Size = New System.Drawing.Size(682, 50)
        Me.DesignPanel.TabIndex = 1
        '
        'RightDesPanel
        '
        Me.RightDesPanel.BackColor = System.Drawing.SystemColors.Control
        Me.RightDesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightDesPanel.Location = New System.Drawing.Point(209, 0)
        Me.RightDesPanel.Name = "RightDesPanel"
        Me.RightDesPanel.Size = New System.Drawing.Size(473, 50)
        Me.RightDesPanel.TabIndex = 7
        '
        'RightDesSplitter
        '
        Me.RightDesSplitter.BackColor = System.Drawing.Color.Black
        Me.RightDesSplitter.Location = New System.Drawing.Point(206, 0)
        Me.RightDesSplitter.Name = "RightDesSplitter"
        Me.RightDesSplitter.Size = New System.Drawing.Size(3, 50)
        Me.RightDesSplitter.TabIndex = 6
        Me.RightDesSplitter.TabStop = False
        '
        'DesPanel
        '
        Me.DesPanel.Controls.Add(Me.DesignBtn)
        Me.DesPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DesPanel.Location = New System.Drawing.Point(108, 0)
        Me.DesPanel.Name = "DesPanel"
        Me.DesPanel.Size = New System.Drawing.Size(98, 50)
        Me.DesPanel.TabIndex = 5
        '
        'DesignBtn
        '
        Me.DesignBtn.AutoSize = True
        Me.DesignBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.DesignBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesignBtn.FlatAppearance.BorderSize = 0
        Me.DesignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DesignBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DesignBtn.Location = New System.Drawing.Point(0, 0)
        Me.DesignBtn.Name = "DesignBtn"
        Me.DesignBtn.Size = New System.Drawing.Size(98, 50)
        Me.DesignBtn.TabIndex = 0
        Me.DesignBtn.Text = "Design"
        Me.DesignBtn.UseVisualStyleBackColor = False
        '
        'LeftDesSplitter
        '
        Me.LeftDesSplitter.BackColor = System.Drawing.Color.Black
        Me.LeftDesSplitter.Location = New System.Drawing.Point(105, 0)
        Me.LeftDesSplitter.Name = "LeftDesSplitter"
        Me.LeftDesSplitter.Size = New System.Drawing.Size(3, 50)
        Me.LeftDesSplitter.TabIndex = 4
        Me.LeftDesSplitter.TabStop = False
        '
        'LeftDesPanel
        '
        Me.LeftDesPanel.BackColor = System.Drawing.SystemColors.Control
        Me.LeftDesPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftDesPanel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LeftDesPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftDesPanel.Name = "LeftDesPanel"
        Me.LeftDesPanel.Size = New System.Drawing.Size(105, 50)
        Me.LeftDesPanel.TabIndex = 0
        '
        'RaPanel
        '
        Me.RaPanel.Controls.Add(Me.ReqSplitter)
        Me.RaPanel.Controls.Add(Me.ReqPanel)
        Me.RaPanel.Location = New System.Drawing.Point(6, 82)
        Me.RaPanel.Name = "RaPanel"
        Me.RaPanel.Size = New System.Drawing.Size(682, 50)
        Me.RaPanel.TabIndex = 0
        '
        'ReqSplitter
        '
        Me.ReqSplitter.BackColor = System.Drawing.Color.Black
        Me.ReqSplitter.Location = New System.Drawing.Point(209, 0)
        Me.ReqSplitter.Name = "ReqSplitter"
        Me.ReqSplitter.Size = New System.Drawing.Size(3, 50)
        Me.ReqSplitter.TabIndex = 1
        Me.ReqSplitter.TabStop = False
        '
        'ReqPanel
        '
        Me.ReqPanel.Controls.Add(Me.ReqBtn)
        Me.ReqPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ReqPanel.Location = New System.Drawing.Point(0, 0)
        Me.ReqPanel.Name = "ReqPanel"
        Me.ReqPanel.Size = New System.Drawing.Size(209, 50)
        Me.ReqPanel.TabIndex = 0
        '
        'ReqBtn
        '
        Me.ReqBtn.AutoSize = True
        Me.ReqBtn.BackColor = System.Drawing.Color.Tomato
        Me.ReqBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReqBtn.FlatAppearance.BorderSize = 0
        Me.ReqBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReqBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ReqBtn.Location = New System.Drawing.Point(0, 0)
        Me.ReqBtn.Name = "ReqBtn"
        Me.ReqBtn.Size = New System.Drawing.Size(209, 50)
        Me.ReqBtn.TabIndex = 0
        Me.ReqBtn.Text = "Requirment"
        Me.ReqBtn.UseVisualStyleBackColor = False
        '
        'ProjectDetails
        '
        Me.ProjectDetails.Controls.Add(Me.Count)
        Me.ProjectDetails.Controls.Add(Me.Label1)
        Me.ProjectDetails.Controls.Add(Me.Label2)
        Me.ProjectDetails.Controls.Add(Me.Label3)
        Me.ProjectDetails.Controls.Add(Me.ProjectId)
        Me.ProjectDetails.Controls.Add(Me.ProjectName)
        Me.ProjectDetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectDetails.Location = New System.Drawing.Point(12, 12)
        Me.ProjectDetails.Name = "ProjectDetails"
        Me.ProjectDetails.Size = New System.Drawing.Size(250, 119)
        Me.ProjectDetails.TabIndex = 13
        Me.ProjectDetails.TabStop = False
        Me.ProjectDetails.Text = "Project Details"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Count.Location = New System.Drawing.Point(94, 85)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(23, 25)
        Me.Count.TabIndex = 6
        Me.Count.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project Id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(25, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "People :"
        '
        'ProjectId
        '
        Me.ProjectId.AutoSize = True
        Me.ProjectId.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProjectId.Location = New System.Drawing.Point(94, 24)
        Me.ProjectId.Name = "ProjectId"
        Me.ProjectId.Size = New System.Drawing.Size(94, 25)
        Me.ProjectId.TabIndex = 4
        Me.ProjectId.Text = "Project Id"
        '
        'ProjectName
        '
        Me.ProjectName.AutoSize = True
        Me.ProjectName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProjectName.Location = New System.Drawing.Point(94, 55)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(129, 25)
        Me.ProjectName.TabIndex = 5
        Me.ProjectName.Text = "Project Name"
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Silver
        Me.Edit.FlatAppearance.BorderSize = 0
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(607, 12)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(88, 36)
        Me.Edit.TabIndex = 16
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.Silver
        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Save.Location = New System.Drawing.Point(700, 12)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(88, 36)
        Me.Save.TabIndex = 15
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'addEmp
        '
        Me.addEmp.BackColor = System.Drawing.Color.Silver
        Me.addEmp.FlatAppearance.BorderSize = 0
        Me.addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addEmp.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addEmp.Location = New System.Drawing.Point(607, 52)
        Me.addEmp.Name = "addEmp"
        Me.addEmp.Size = New System.Drawing.Size(181, 36)
        Me.addEmp.TabIndex = 17
        Me.addEmp.Text = "Add Contributors"
        Me.addEmp.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.Silver
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetBtn.Location = New System.Drawing.Point(607, 93)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(181, 35)
        Me.ResetBtn.TabIndex = 18
        Me.ResetBtn.Text = "Reset Layout"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'ReqTip
        '
        Me.ReqTip.ToolTipTitle = "Stage Deadline"
        '
        'DesTip
        '
        Me.DesTip.ToolTipTitle = "Stage Deadline"
        '
        'DevTip
        '
        Me.DevTip.ToolTipTitle = "Stage Deadline"
        '
        'TestTip
        '
        Me.TestTip.ToolTipTitle = "Stage Deadline"
        '
        'DepTip
        '
        Me.DepTip.ToolTipTitle = "Stage Deadline"
        '
        'ProjectLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 505)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.addEmp)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Layout)
        Me.Controls.Add(Me.ProjectDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProjectLayout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProjectLayout"
        Me.Layout.ResumeLayout(False)
        Me.Layout.PerformLayout()
        Me.DeploymentPanel.ResumeLayout(False)
        Me.DeployPanel.ResumeLayout(False)
        Me.TestPanel.ResumeLayout(False)
        Me.TestingPanel.ResumeLayout(False)
        Me.DevPanel.ResumeLayout(False)
        Me.DevelopmentPanel.ResumeLayout(False)
        Me.DevelopmentPanel.PerformLayout()
        Me.DesignPanel.ResumeLayout(False)
        Me.DesPanel.ResumeLayout(False)
        Me.DesPanel.PerformLayout()
        Me.RaPanel.ResumeLayout(False)
        Me.ReqPanel.ResumeLayout(False)
        Me.ReqPanel.PerformLayout()
        Me.ProjectDetails.ResumeLayout(False)
        Me.ProjectDetails.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
