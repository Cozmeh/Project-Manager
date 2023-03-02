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
        Layout = New GroupBox()
        dead = New Label()
        Start = New Label()
        TestPanel = New Panel()
        RightTestPanel = New Panel()
        RightTestSplitter = New Splitter()
        TestingPanel = New Panel()
        TestBtn = New Button()
        LeftTestSplitter = New Splitter()
        LeftTestPanel = New Panel()
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
        RA = New Button()
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
        Button1 = New Button()
        Layout.SuspendLayout()
        TestPanel.SuspendLayout()
        TestingPanel.SuspendLayout()
        DevPanel.SuspendLayout()
        DevelopmentPanel.SuspendLayout()
        DesignPanel.SuspendLayout()
        DesPanel.SuspendLayout()
        RaPanel.SuspendLayout()
        ReqPanel.SuspendLayout()
        ProjectDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Layout
        ' 
        Layout.Controls.Add(dead)
        Layout.Controls.Add(Start)
        Layout.Controls.Add(TestPanel)
        Layout.Controls.Add(DevPanel)
        Layout.Controls.Add(DesignPanel)
        Layout.Controls.Add(RaPanel)
        Layout.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Layout.Location = New Point(12, 134)
        Layout.Name = "Layout"
        Layout.Size = New Size(776, 352)
        Layout.TabIndex = 14
        Layout.TabStop = False
        Layout.Text = "Plan Layout"' 
        ' dead
        ' 
        dead.AutoSize = True
        dead.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        dead.Location = New Point(676, 38)
        dead.Name = "dead"
        dead.Size = New Size(87, 25)
        dead.TabIndex = 5
        dead.Text = "Deadline"' 
        ' Start
        ' 
        Start.AutoSize = True
        Start.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Start.Location = New Point(11, 38)
        Start.Name = "Start"
        Start.Size = New Size(94, 25)
        Start.TabIndex = 4
        Start.Text = "Start Date"' 
        ' TestPanel
        ' 
        TestPanel.Controls.Add(RightTestPanel)
        TestPanel.Controls.Add(RightTestSplitter)
        TestPanel.Controls.Add(TestingPanel)
        TestPanel.Controls.Add(LeftTestSplitter)
        TestPanel.Controls.Add(LeftTestPanel)
        TestPanel.Location = New Point(6, 233)
        TestPanel.Name = "TestPanel"
        TestPanel.Size = New Size(764, 50)
        TestPanel.TabIndex = 3
        ' 
        ' RightTestPanel
        ' 
        RightTestPanel.BackColor = SystemColors.Control
        RightTestPanel.Dock = DockStyle.Fill
        RightTestPanel.Location = New Point(401, 0)
        RightTestPanel.Name = "RightTestPanel"
        RightTestPanel.Size = New Size(363, 50)
        RightTestPanel.TabIndex = 4
        ' 
        ' RightTestSplitter
        ' 
        RightTestSplitter.BackColor = Color.Black
        RightTestSplitter.Location = New Point(398, 0)
        RightTestSplitter.Name = "RightTestSplitter"
        RightTestSplitter.Size = New Size(3, 50)
        RightTestSplitter.TabIndex = 3
        RightTestSplitter.TabStop = False
        ' 
        ' TestingPanel
        ' 
        TestingPanel.Controls.Add(TestBtn)
        TestingPanel.Dock = DockStyle.Left
        TestingPanel.Location = New Point(322, 0)
        TestingPanel.Name = "TestingPanel"
        TestingPanel.Size = New Size(76, 50)
        TestingPanel.TabIndex = 2
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
        TestBtn.Size = New Size(76, 50)
        TestBtn.TabIndex = 0
        TestBtn.Text = "Testing"
        TestBtn.UseVisualStyleBackColor = False
        ' 
        ' LeftTestSplitter
        ' 
        LeftTestSplitter.BackColor = Color.Black
        LeftTestSplitter.Location = New Point(319, 0)
        LeftTestSplitter.Name = "LeftTestSplitter"
        LeftTestSplitter.Size = New Size(3, 50)
        LeftTestSplitter.TabIndex = 1
        LeftTestSplitter.TabStop = False
        ' 
        ' LeftTestPanel
        ' 
        LeftTestPanel.BackColor = SystemColors.Control
        LeftTestPanel.Dock = DockStyle.Left
        LeftTestPanel.Location = New Point(0, 0)
        LeftTestPanel.Name = "LeftTestPanel"
        LeftTestPanel.Size = New Size(319, 50)
        LeftTestPanel.TabIndex = 0
        ' 
        ' DevPanel
        ' 
        DevPanel.Controls.Add(RightDevPanel)
        DevPanel.Controls.Add(RDevSplitter)
        DevPanel.Controls.Add(DevelopmentPanel)
        DevPanel.Controls.Add(LDevSplitter)
        DevPanel.Controls.Add(LeftDevPanel)
        DevPanel.Location = New Point(6, 177)
        DevPanel.Name = "DevPanel"
        DevPanel.Size = New Size(764, 50)
        DevPanel.TabIndex = 2
        ' 
        ' RightDevPanel
        ' 
        RightDevPanel.BackColor = SystemColors.Control
        RightDevPanel.Dock = DockStyle.Fill
        RightDevPanel.Location = New Point(322, 0)
        RightDevPanel.Name = "RightDevPanel"
        RightDevPanel.Size = New Size(442, 50)
        RightDevPanel.TabIndex = 4
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
        DesignPanel.Location = New Point(6, 122)
        DesignPanel.Name = "DesignPanel"
        DesignPanel.Size = New Size(764, 50)
        DesignPanel.TabIndex = 1
        ' 
        ' RightDesPanel
        ' 
        RightDesPanel.BackColor = SystemColors.Control
        RightDesPanel.Dock = DockStyle.Fill
        RightDesPanel.Location = New Point(209, 0)
        RightDesPanel.Name = "RightDesPanel"
        RightDesPanel.Size = New Size(555, 50)
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
        RaPanel.Location = New Point(6, 66)
        RaPanel.Name = "RaPanel"
        RaPanel.Size = New Size(764, 50)
        RaPanel.TabIndex = 0
        ' 
        ' ReqSplitter
        ' 
        ReqSplitter.BackColor = Color.Black
        ReqSplitter.Location = New Point(105, 0)
        ReqSplitter.Name = "ReqSplitter"
        ReqSplitter.Size = New Size(3, 50)
        ReqSplitter.TabIndex = 1
        ReqSplitter.TabStop = False
        ' 
        ' ReqPanel
        ' 
        ReqPanel.Controls.Add(RA)
        ReqPanel.Dock = DockStyle.Left
        ReqPanel.Location = New Point(0, 0)
        ReqPanel.Name = "ReqPanel"
        ReqPanel.Size = New Size(105, 50)
        ReqPanel.TabIndex = 0
        ' 
        ' RA
        ' 
        RA.AutoSize = True
        RA.BackColor = Color.Tomato
        RA.Dock = DockStyle.Fill
        RA.FlatAppearance.BorderSize = 0
        RA.FlatStyle = FlatStyle.Flat
        RA.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        RA.Location = New Point(0, 0)
        RA.Name = "RA"
        RA.Size = New Size(105, 50)
        RA.TabIndex = 0
        RA.Text = "Requirment"
        RA.UseVisualStyleBackColor = False
        ' 
        ' ProjectDetails
        ' 
        ProjectDetails.Controls.Add(Count)
        ProjectDetails.Controls.Add(Label1)
        ProjectDetails.Controls.Add(Label2)
        ProjectDetails.Controls.Add(Label3)
        ProjectDetails.Controls.Add(ProjectId)
        ProjectDetails.Controls.Add(ProjectName)
        ProjectDetails.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectDetails.Location = New Point(12, 12)
        ProjectDetails.Name = "ProjectDetails"
        ProjectDetails.Size = New Size(250, 116)
        ProjectDetails.TabIndex = 13
        ProjectDetails.TabStop = False
        ProjectDetails.Text = "Project Details"' 
        ' Count
        ' 
        Count.AutoSize = True
        Count.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Count.Location = New Point(110, 82)
        Count.Name = "Count"
        Count.Size = New Size(22, 25)
        Count.TabIndex = 6
        Count.Text = "2"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(11, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 0
        Label1.Text = "Project Id:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(11, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 1
        Label2.Text = "Name      :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(9, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 25)
        Label3.TabIndex = 2
        Label3.Text = "People     :"' 
        ' ProjectId
        ' 
        ProjectId.AutoSize = True
        ProjectId.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectId.Location = New Point(110, 20)
        ProjectId.Name = "ProjectId"
        ProjectId.Size = New Size(92, 25)
        ProjectId.TabIndex = 4
        ProjectId.Text = "Project Id"' 
        ' ProjectName
        ' 
        ProjectName.AutoSize = True
        ProjectName.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectName.Location = New Point(110, 51)
        ProjectName.Name = "ProjectName"
        ProjectName.Size = New Size(126, 25)
        ProjectName.TabIndex = 5
        ProjectName.Text = "Project Name"' 
        ' Edit
        ' 
        Edit.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Edit.Location = New Point(607, 12)
        Edit.Name = "Edit"
        Edit.Size = New Size(88, 36)
        Edit.TabIndex = 16
        Edit.Text = "Edit"
        Edit.UseVisualStyleBackColor = True
        ' 
        ' Save
        ' 
        Save.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Save.Location = New Point(700, 12)
        Save.Name = "Save"
        Save.Size = New Size(88, 36)
        Save.TabIndex = 15
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' addEmp
        ' 
        addEmp.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        addEmp.Location = New Point(607, 52)
        addEmp.Name = "addEmp"
        addEmp.Size = New Size(181, 36)
        addEmp.TabIndex = 17
        addEmp.Text = "Add Contributors"
        addEmp.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(607, 93)
        Button1.Name = "Button1"
        Button1.Size = New Size(181, 35)
        Button1.TabIndex = 18
        Button1.Text = "Reset Layout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ProjectLayout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 498)
        Controls.Add(Button1)
        Controls.Add(addEmp)
        Controls.Add(Edit)
        Controls.Add(Save)
        Controls.Add(Layout)
        Controls.Add(ProjectDetails)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "ProjectLayout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProjectLayout"
        Layout.ResumeLayout(False)
        Layout.PerformLayout()
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
End Class
