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
        Me.Layout = New System.Windows.Forms.GroupBox()
        Me.DeploymentPanel = New System.Windows.Forms.Panel()
        Me.DeploySplitter = New System.Windows.Forms.Splitter()
        Me.DeployPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dead = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Label()
        Me.TestPanel = New System.Windows.Forms.Panel()
        Me.RightTestPanel = New System.Windows.Forms.Panel()
        Me.RightTestSplitter = New System.Windows.Forms.Splitter()
        Me.TestingPanel = New System.Windows.Forms.Panel()
        Me.TestBtn = New System.Windows.Forms.Button()
        Me.LeftTestSplitter = New System.Windows.Forms.Splitter()
        Me.LeftTestPanel = New System.Windows.Forms.Panel()
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
        Me.RA = New System.Windows.Forms.Button()
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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Layout.Controls.Add(Me.DeploymentPanel)
        Me.Layout.Controls.Add(Me.dead)
        Me.Layout.Controls.Add(Me.Start)
        Me.Layout.Controls.Add(Me.TestPanel)
        Me.Layout.Controls.Add(Me.DevPanel)
        Me.Layout.Controls.Add(Me.DesignPanel)
        Me.Layout.Controls.Add(Me.RaPanel)
        Me.Layout.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Layout.Location = New System.Drawing.Point(12, 134)
        Me.Layout.Name = "Layout"
        Me.Layout.Size = New System.Drawing.Size(776, 352)
        Me.Layout.TabIndex = 14
        Me.Layout.TabStop = False
        Me.Layout.Text = "Plan Layout"
        '
        'DeploymentPanel
        '
        Me.DeploymentPanel.Controls.Add(Me.DeploySplitter)
        Me.DeploymentPanel.Controls.Add(Me.DeployPanel)
        Me.DeploymentPanel.Location = New System.Drawing.Point(6, 289)
        Me.DeploymentPanel.Name = "DeploymentPanel"
        Me.DeploymentPanel.Size = New System.Drawing.Size(764, 50)
        Me.DeploymentPanel.TabIndex = 6
        '
        'DeploySplitter
        '
        Me.DeploySplitter.BackColor = System.Drawing.Color.Black
        Me.DeploySplitter.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeploySplitter.Location = New System.Drawing.Point(616, 0)
        Me.DeploySplitter.Name = "DeploySplitter"
        Me.DeploySplitter.Size = New System.Drawing.Size(3, 50)
        Me.DeploySplitter.TabIndex = 1
        Me.DeploySplitter.TabStop = False
        '
        'DeployPanel
        '
        Me.DeployPanel.Controls.Add(Me.Button2)
        Me.DeployPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeployPanel.Location = New System.Drawing.Point(619, 0)
        Me.DeployPanel.Name = "DeployPanel"
        Me.DeployPanel.Size = New System.Drawing.Size(145, 50)
        Me.DeployPanel.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orchid
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Deployment"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dead
        '
        Me.dead.AutoSize = True
        Me.dead.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dead.Location = New System.Drawing.Point(666, 30)
        Me.dead.Name = "dead"
        Me.dead.Size = New System.Drawing.Size(87, 25)
        Me.dead.TabIndex = 5
        Me.dead.Text = "Deadline"
        '
        'Start
        '
        Me.Start.AutoSize = True
        Me.Start.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Start.Location = New System.Drawing.Point(6, 30)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(94, 25)
        Me.Start.TabIndex = 4
        Me.Start.Text = "Start Date"
        '
        'TestPanel
        '
        Me.TestPanel.Controls.Add(Me.RightTestPanel)
        Me.TestPanel.Controls.Add(Me.RightTestSplitter)
        Me.TestPanel.Controls.Add(Me.TestingPanel)
        Me.TestPanel.Controls.Add(Me.LeftTestSplitter)
        Me.TestPanel.Controls.Add(Me.LeftTestPanel)
        Me.TestPanel.Location = New System.Drawing.Point(6, 233)
        Me.TestPanel.Name = "TestPanel"
        Me.TestPanel.Size = New System.Drawing.Size(764, 50)
        Me.TestPanel.TabIndex = 3
        '
        'RightTestPanel
        '
        Me.RightTestPanel.BackColor = System.Drawing.SystemColors.Control
        Me.RightTestPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightTestPanel.Location = New System.Drawing.Point(401, 0)
        Me.RightTestPanel.Name = "RightTestPanel"
        Me.RightTestPanel.Size = New System.Drawing.Size(363, 50)
        Me.RightTestPanel.TabIndex = 4
        '
        'RightTestSplitter
        '
        Me.RightTestSplitter.BackColor = System.Drawing.Color.Black
        Me.RightTestSplitter.Location = New System.Drawing.Point(398, 0)
        Me.RightTestSplitter.Name = "RightTestSplitter"
        Me.RightTestSplitter.Size = New System.Drawing.Size(3, 50)
        Me.RightTestSplitter.TabIndex = 3
        Me.RightTestSplitter.TabStop = False
        '
        'TestingPanel
        '
        Me.TestingPanel.Controls.Add(Me.TestBtn)
        Me.TestingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TestingPanel.Location = New System.Drawing.Point(322, 0)
        Me.TestingPanel.Name = "TestingPanel"
        Me.TestingPanel.Size = New System.Drawing.Size(76, 50)
        Me.TestingPanel.TabIndex = 2
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
        Me.TestBtn.Size = New System.Drawing.Size(76, 50)
        Me.TestBtn.TabIndex = 0
        Me.TestBtn.Text = "Testing"
        Me.TestBtn.UseVisualStyleBackColor = False
        '
        'LeftTestSplitter
        '
        Me.LeftTestSplitter.BackColor = System.Drawing.Color.Black
        Me.LeftTestSplitter.Location = New System.Drawing.Point(319, 0)
        Me.LeftTestSplitter.Name = "LeftTestSplitter"
        Me.LeftTestSplitter.Size = New System.Drawing.Size(3, 50)
        Me.LeftTestSplitter.TabIndex = 1
        Me.LeftTestSplitter.TabStop = False
        '
        'LeftTestPanel
        '
        Me.LeftTestPanel.BackColor = System.Drawing.SystemColors.Control
        Me.LeftTestPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftTestPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftTestPanel.Name = "LeftTestPanel"
        Me.LeftTestPanel.Size = New System.Drawing.Size(319, 50)
        Me.LeftTestPanel.TabIndex = 0
        '
        'DevPanel
        '
        Me.DevPanel.Controls.Add(Me.RightDevPanel)
        Me.DevPanel.Controls.Add(Me.RDevSplitter)
        Me.DevPanel.Controls.Add(Me.DevelopmentPanel)
        Me.DevPanel.Controls.Add(Me.LDevSplitter)
        Me.DevPanel.Controls.Add(Me.LeftDevPanel)
        Me.DevPanel.Location = New System.Drawing.Point(6, 177)
        Me.DevPanel.Name = "DevPanel"
        Me.DevPanel.Size = New System.Drawing.Size(764, 50)
        Me.DevPanel.TabIndex = 2
        '
        'RightDevPanel
        '
        Me.RightDevPanel.BackColor = System.Drawing.SystemColors.Control
        Me.RightDevPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightDevPanel.Location = New System.Drawing.Point(322, 0)
        Me.RightDevPanel.Name = "RightDevPanel"
        Me.RightDevPanel.Size = New System.Drawing.Size(442, 50)
        Me.RightDevPanel.TabIndex = 4
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
        Me.DesignPanel.Location = New System.Drawing.Point(6, 122)
        Me.DesignPanel.Name = "DesignPanel"
        Me.DesignPanel.Size = New System.Drawing.Size(764, 50)
        Me.DesignPanel.TabIndex = 1
        '
        'RightDesPanel
        '
        Me.RightDesPanel.BackColor = System.Drawing.SystemColors.Control
        Me.RightDesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightDesPanel.Location = New System.Drawing.Point(209, 0)
        Me.RightDesPanel.Name = "RightDesPanel"
        Me.RightDesPanel.Size = New System.Drawing.Size(555, 50)
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
        Me.RaPanel.Location = New System.Drawing.Point(6, 66)
        Me.RaPanel.Name = "RaPanel"
        Me.RaPanel.Size = New System.Drawing.Size(764, 50)
        Me.RaPanel.TabIndex = 0
        '
        'ReqSplitter
        '
        Me.ReqSplitter.BackColor = System.Drawing.Color.Black
        Me.ReqSplitter.Location = New System.Drawing.Point(105, 0)
        Me.ReqSplitter.Name = "ReqSplitter"
        Me.ReqSplitter.Size = New System.Drawing.Size(3, 50)
        Me.ReqSplitter.TabIndex = 1
        Me.ReqSplitter.TabStop = False
        '
        'ReqPanel
        '
        Me.ReqPanel.Controls.Add(Me.RA)
        Me.ReqPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ReqPanel.Location = New System.Drawing.Point(0, 0)
        Me.ReqPanel.Name = "ReqPanel"
        Me.ReqPanel.Size = New System.Drawing.Size(105, 50)
        Me.ReqPanel.TabIndex = 0
        '
        'RA
        '
        Me.RA.AutoSize = True
        Me.RA.BackColor = System.Drawing.Color.Tomato
        Me.RA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RA.FlatAppearance.BorderSize = 0
        Me.RA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RA.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RA.Location = New System.Drawing.Point(0, 0)
        Me.RA.Name = "RA"
        Me.RA.Size = New System.Drawing.Size(105, 50)
        Me.RA.TabIndex = 0
        Me.RA.Text = "Requirment"
        Me.RA.UseVisualStyleBackColor = False
        '
        'ProjectDetails
        '
        Me.ProjectDetails.Controls.Add(Me.Count)
        Me.ProjectDetails.Controls.Add(Me.Label1)
        Me.ProjectDetails.Controls.Add(Me.Label2)
        Me.ProjectDetails.Controls.Add(Me.Label3)
        Me.ProjectDetails.Controls.Add(Me.ProjectId)
        Me.ProjectDetails.Controls.Add(Me.ProjectName)
        Me.ProjectDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectDetails.Location = New System.Drawing.Point(12, 12)
        Me.ProjectDetails.Name = "ProjectDetails"
        Me.ProjectDetails.Size = New System.Drawing.Size(250, 116)
        Me.ProjectDetails.TabIndex = 13
        Me.ProjectDetails.TabStop = False
        Me.ProjectDetails.Text = "Project Details"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Count.Location = New System.Drawing.Point(110, 82)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(22, 25)
        Me.Count.TabIndex = 6
        Me.Count.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name      :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(9, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "People     :"
        '
        'ProjectId
        '
        Me.ProjectId.AutoSize = True
        Me.ProjectId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectId.Location = New System.Drawing.Point(110, 20)
        Me.ProjectId.Name = "ProjectId"
        Me.ProjectId.Size = New System.Drawing.Size(92, 25)
        Me.ProjectId.TabIndex = 4
        Me.ProjectId.Text = "Project Id"
        '
        'ProjectName
        '
        Me.ProjectName.AutoSize = True
        Me.ProjectName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectName.Location = New System.Drawing.Point(110, 51)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(126, 25)
        Me.ProjectName.TabIndex = 5
        Me.ProjectName.Text = "Project Name"
        '
        'Edit
        '
        Me.Edit.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(607, 12)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(88, 36)
        Me.Edit.TabIndex = 16
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Ok
        '
        Me.Save.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Save.Location = New System.Drawing.Point(700, 12)
        Me.Save.Name = "Ok"
        Me.Save.Size = New System.Drawing.Size(88, 36)
        Me.Save.TabIndex = 15
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'addEmp
        '
        Me.addEmp.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addEmp.Location = New System.Drawing.Point(607, 52)
        Me.addEmp.Name = "addEmp"
        Me.addEmp.Size = New System.Drawing.Size(181, 36)
        Me.addEmp.TabIndex = 17
        Me.addEmp.Text = "Add Contributors"
        Me.addEmp.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(607, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Reset Layout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProjectLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents RA As Button
    Friend WithEvents LeftDesPanel As Panel
    Friend WithEvents LeftDesSplitter As Splitter
    Friend WithEvents DesPanel As Panel
    Friend WithEvents DesignBtn As Button
    Friend WithEvents RightDesSplitter As Splitter
    Friend WithEvents RightDesPanel As Panel
    Friend WithEvents LeftDevPanel As Panel
    Friend WithEvents LeftTestSplitter As Splitter
    Friend WithEvents LeftTestPanel As Panel
    Friend WithEvents RightDevPanel As Panel
    Friend WithEvents RDevSplitter As Splitter
    Friend WithEvents DevelopmentPanel As Panel
    Friend WithEvents DevBtn As Button
    Friend WithEvents LDevSplitter As Splitter
    Friend WithEvents Button1 As Button
    Friend WithEvents RightTestPanel As Panel
    Friend WithEvents RightTestSplitter As Splitter
    Friend WithEvents TestingPanel As Panel
    Friend WithEvents TestBtn As Button
    Friend WithEvents Start As Label
    Friend WithEvents dead As Label
    Friend WithEvents DeploymentPanel As Panel
    Friend WithEvents DeployPanel As Panel
    Friend WithEvents DeploySplitter As Splitter
    Friend WithEvents Button2 As Button
End Class
