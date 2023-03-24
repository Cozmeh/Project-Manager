<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskContributor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        projectId = New GroupBox()
        Label2 = New Label()
        Task = New Label()
        Label1 = New Label()
        projectName = New Label()
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        asize = New Label()
        Label5 = New Label()
        AddComment = New RichTextBox()
        Validate = New Button()
        AddRow = New Button()
        ContId = New TextBox()
        TabPage2 = New TabPage()
        UpdateRow = New Button()
        usize = New Label()
        Label6 = New Label()
        UpdateComment = New RichTextBox()
        getId = New Button()
        UContId = New TextBox()
        ContributorDataGrid = New DataGridView()
        Ok = New Button()
        Unassigned = New Button()
        projectId.SuspendLayout()
        TabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(ContributorDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' projectId
        ' 
        projectId.Controls.Add(Label2)
        projectId.Controls.Add(Task)
        projectId.Controls.Add(Label1)
        projectId.Controls.Add(projectName)
        projectId.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        projectId.Location = New Point(12, 12)
        projectId.Name = "projectId"
        projectId.Size = New Size(348, 91)
        projectId.TabIndex = 6
        projectId.TabStop = False
        projectId.Text = "Project Id:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(39, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 21)
        Label2.TabIndex = 2
        Label2.Text = "Stage task :"' 
        ' Task
        ' 
        Task.AutoSize = True
        Task.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Task.Location = New Point(128, 49)
        Task.Name = "Task"
        Task.Size = New Size(48, 25)
        Task.TabIndex = 4
        Task.Text = "Task"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(15, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 21)
        Label1.TabIndex = 1
        Label1.Text = "Project Name :"' 
        ' projectName
        ' 
        projectName.AutoSize = True
        projectName.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        projectName.Location = New Point(128, 19)
        projectName.Name = "projectName"
        projectName.Size = New Size(64, 25)
        projectName.TabIndex = 3
        projectName.Text = "Name"' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl.Location = New Point(12, 109)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(776, 125)
        TabControl.TabIndex = 20
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(asize)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(AddComment)
        TabPage1.Controls.Add(Validate)
        TabPage1.Controls.Add(AddRow)
        TabPage1.Controls.Add(ContId)
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 95)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' asize
        ' 
        asize.AutoSize = True
        asize.Location = New Point(492, 8)
        asize.Name = "asize"
        asize.Size = New Size(34, 17)
        asize.TabIndex = 42
        asize.Text = "0/50"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(346, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 21)
        Label5.TabIndex = 41
        Label5.Text = "Comment"' 
        ' AddComment
        ' 
        AddComment.Enabled = False
        AddComment.Location = New Point(346, 29)
        AddComment.Name = "AddComment"
        AddComment.Size = New Size(184, 51)
        AddComment.TabIndex = 40
        AddComment.Text = ""' 
        ' Validate
        ' 
        Validate.BackColor = Color.Silver
        Validate.FlatAppearance.BorderSize = 0
        Validate.FlatStyle = FlatStyle.Flat
        Validate.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Validate.Location = New Point(148, 35)
        Validate.Name = "Validate"
        Validate.Size = New Size(122, 25)
        Validate.TabIndex = 39
        Validate.Text = "Validate"
        Validate.UseVisualStyleBackColor = False
        ' 
        ' AddRow
        ' 
        AddRow.BackColor = Color.LightSeaGreen
        AddRow.FlatAppearance.BorderSize = 0
        AddRow.FlatStyle = FlatStyle.Flat
        AddRow.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        AddRow.Location = New Point(614, 29)
        AddRow.Name = "AddRow"
        AddRow.Size = New Size(127, 38)
        AddRow.TabIndex = 26
        AddRow.Text = "Add Contributor"
        AddRow.UseVisualStyleBackColor = False
        ' 
        ' ContId
        ' 
        ContId.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ContId.Location = New Point(20, 35)
        ContId.Name = "ContId"
        ContId.PlaceholderText = "Contributor ID"
        ContId.Size = New Size(122, 25)
        ContId.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(UpdateRow)
        TabPage2.Controls.Add(usize)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(UpdateComment)
        TabPage2.Controls.Add(getId)
        TabPage2.Controls.Add(UContId)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 95)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Update"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' UpdateRow
        ' 
        UpdateRow.BackColor = Color.Goldenrod
        UpdateRow.FlatAppearance.BorderSize = 0
        UpdateRow.FlatStyle = FlatStyle.Flat
        UpdateRow.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        UpdateRow.Location = New Point(614, 29)
        UpdateRow.Name = "UpdateRow"
        UpdateRow.Size = New Size(127, 38)
        UpdateRow.TabIndex = 46
        UpdateRow.Text = "Update"
        UpdateRow.UseVisualStyleBackColor = False
        ' 
        ' usize
        ' 
        usize.AutoSize = True
        usize.Location = New Point(492, 9)
        usize.Name = "usize"
        usize.Size = New Size(34, 17)
        usize.TabIndex = 45
        usize.Text = "0/50"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(346, 5)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 21)
        Label6.TabIndex = 44
        Label6.Text = "Comment"' 
        ' UpdateComment
        ' 
        UpdateComment.Enabled = False
        UpdateComment.Location = New Point(346, 29)
        UpdateComment.Name = "UpdateComment"
        UpdateComment.Size = New Size(184, 51)
        UpdateComment.TabIndex = 43
        UpdateComment.Text = ""' 
        ' getId
        ' 
        getId.BackColor = Color.Silver
        getId.FlatAppearance.BorderSize = 0
        getId.FlatStyle = FlatStyle.Flat
        getId.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        getId.Location = New Point(148, 35)
        getId.Name = "getId"
        getId.Size = New Size(122, 25)
        getId.TabIndex = 42
        getId.Text = "Get"
        getId.UseVisualStyleBackColor = False
        ' 
        ' UContId
        ' 
        UContId.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UContId.Location = New Point(20, 35)
        UContId.Name = "UContId"
        UContId.PlaceholderText = "Contribution ID"
        UContId.Size = New Size(122, 25)
        UContId.TabIndex = 41
        ' 
        ' ContributorDataGrid
        ' 
        ContributorDataGrid.AllowUserToAddRows = False
        ContributorDataGrid.AllowUserToDeleteRows = False
        ContributorDataGrid.AllowUserToResizeColumns = False
        ContributorDataGrid.AllowUserToResizeRows = False
        ContributorDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ContributorDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ContributorDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ContributorDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ContributorDataGrid.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        ContributorDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        ContributorDataGrid.Location = New Point(12, 246)
        ContributorDataGrid.Name = "ContributorDataGrid"
        ContributorDataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        ContributorDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        ContributorDataGrid.RowHeadersWidth = 20
        ContributorDataGrid.RowTemplate.Height = 25
        ContributorDataGrid.ScrollBars = ScrollBars.Vertical
        ContributorDataGrid.Size = New Size(776, 192)
        ContributorDataGrid.TabIndex = 21
        ' 
        ' Ok
        ' 
        Ok.BackColor = Color.Silver
        Ok.FlatAppearance.BorderSize = 0
        Ok.FlatStyle = FlatStyle.Flat
        Ok.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Ok.Location = New Point(669, 12)
        Ok.Name = "Ok"
        Ok.Size = New Size(119, 42)
        Ok.TabIndex = 22
        Ok.Text = "Done"
        Ok.UseVisualStyleBackColor = False
        ' 
        ' Unassigned
        ' 
        Unassigned.BackColor = Color.Silver
        Unassigned.FlatAppearance.BorderSize = 0
        Unassigned.FlatStyle = FlatStyle.Flat
        Unassigned.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Unassigned.Location = New Point(669, 61)
        Unassigned.Name = "Unassigned"
        Unassigned.Size = New Size(119, 42)
        Unassigned.TabIndex = 23
        Unassigned.Text = " Unassigned"
        Unassigned.UseVisualStyleBackColor = False
        ' 
        ' TaskContributor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Unassigned)
        Controls.Add(Ok)
        Controls.Add(ContributorDataGrid)
        Controls.Add(TabControl)
        Controls.Add(projectId)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "TaskContributor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TaskContributor"
        projectId.ResumeLayout(False)
        projectId.PerformLayout()
        TabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(ContributorDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents projectId As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Task As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents projectName As Label
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents asize As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddComment As RichTextBox
    Friend WithEvents Validate As Button
    Friend WithEvents AddRow As Button
    Friend WithEvents ContId As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UpdateRow As Button
    Friend WithEvents usize As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents UpdateComment As RichTextBox
    Friend WithEvents getId As Button
    Friend WithEvents UContId As TextBox
    Friend WithEvents ContributorDataGrid As DataGridView
    Friend WithEvents Ok As Button
    Friend WithEvents Unassigned As Button
End Class
