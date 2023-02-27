<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contributors
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        projectName = New Label()
        Count = New Label()
        projectId = New GroupBox()
        ContributorDataGrid = New DataGridView()
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        Validate = New Button()
        Label3 = New Label()
        AddRow = New Button()
        Task = New ComboBox()
        ContId = New TextBox()
        TabPage2 = New TabPage()
        getId = New Button()
        UContId = New TextBox()
        Label4 = New Label()
        UTask = New ComboBox()
        UpdateRow = New Button()
        TabPage3 = New TabPage()
        DeleteRow = New Button()
        Del_ID = New TextBox()
        Ok = New Button()
        projectId.SuspendLayout()
        CType(ContributorDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(97, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 1
        Label1.Text = "Project Id:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(30, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 25)
        Label2.TabIndex = 2
        Label2.Text = "Max Contributors:"' 
        ' projectName
        ' 
        projectName.AutoSize = True
        projectName.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        projectName.Location = New Point(199, 19)
        projectName.Name = "projectName"
        projectName.Size = New Size(62, 25)
        projectName.TabIndex = 3
        projectName.Text = "Name"' 
        ' Count
        ' 
        Count.AutoSize = True
        Count.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Count.Location = New Point(199, 55)
        Count.Name = "Count"
        Count.Size = New Size(63, 25)
        Count.TabIndex = 4
        Count.Text = "Count"' 
        ' projectId
        ' 
        projectId.Controls.Add(Label2)
        projectId.Controls.Add(Count)
        projectId.Controls.Add(Label1)
        projectId.Controls.Add(projectName)
        projectId.Location = New Point(12, 13)
        projectId.Name = "projectId"
        projectId.Size = New Size(354, 100)
        projectId.TabIndex = 5
        projectId.TabStop = False
        projectId.Text = "Project Id:"' 
        ' ContributorDataGrid
        ' 
        ContributorDataGrid.AllowUserToAddRows = False
        ContributorDataGrid.AllowUserToDeleteRows = False
        ContributorDataGrid.AllowUserToResizeColumns = False
        ContributorDataGrid.AllowUserToResizeRows = False
        ContributorDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ContributorDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        ContributorDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        ContributorDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ContributorDataGrid.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        ContributorDataGrid.DefaultCellStyle = DataGridViewCellStyle5
        ContributorDataGrid.Location = New Point(12, 246)
        ContributorDataGrid.Name = "ContributorDataGrid"
        ContributorDataGrid.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        ContributorDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        ContributorDataGrid.RowHeadersWidth = 20
        ContributorDataGrid.RowTemplate.Height = 25
        ContributorDataGrid.ScrollBars = ScrollBars.Vertical
        ContributorDataGrid.Size = New Size(776, 192)
        ContributorDataGrid.TabIndex = 18
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Controls.Add(TabPage3)
        TabControl.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl.Location = New Point(12, 119)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(776, 125)
        TabControl.TabIndex = 19
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Validate)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(AddRow)
        TabPage1.Controls.Add(Task)
        TabPage1.Controls.Add(ContId)
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 95)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Validate
        ' 
        Validate.BackColor = Color.Silver
        Validate.FlatAppearance.BorderSize = 0
        Validate.FlatStyle = FlatStyle.Flat
        Validate.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Validate.Location = New Point(170, 35)
        Validate.Name = "Validate"
        Validate.Size = New Size(109, 32)
        Validate.TabIndex = 39
        Validate.Text = "Validate"
        Validate.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(299, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 25)
        Label3.TabIndex = 27
        Label3.Text = "Task :"' 
        ' AddRow
        ' 
        AddRow.BackColor = Color.LightSeaGreen
        AddRow.FlatAppearance.BorderSize = 0
        AddRow.FlatStyle = FlatStyle.Flat
        AddRow.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        AddRow.Location = New Point(574, 34)
        AddRow.Name = "AddRow"
        AddRow.Size = New Size(170, 33)
        AddRow.TabIndex = 26
        AddRow.Text = "Add Contributor"
        AddRow.UseVisualStyleBackColor = False
        ' 
        ' Task
        ' 
        Task.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Task.FormattingEnabled = True
        Task.Items.AddRange(New Object() {"UnAssigned", "Requirement Analysis", "Design", "Development", "Testing"})
        Task.Location = New Point(357, 34)
        Task.Name = "Task"
        Task.Size = New Size(202, 33)
        Task.TabIndex = 24
        Task.Text = "Un-Assigned"' 
        ' ContId
        ' 
        ContId.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ContId.Location = New Point(22, 35)
        ContId.Name = "ContId"
        ContId.PlaceholderText = "Contributor ID"
        ContId.Size = New Size(131, 32)
        ContId.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(getId)
        TabPage2.Controls.Add(UContId)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(UTask)
        TabPage2.Controls.Add(UpdateRow)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 95)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Update"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' getId
        ' 
        getId.BackColor = Color.Silver
        getId.FlatAppearance.BorderSize = 0
        getId.FlatStyle = FlatStyle.Flat
        getId.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        getId.Location = New Point(171, 35)
        getId.Name = "getId"
        getId.Size = New Size(105, 33)
        getId.TabIndex = 42
        getId.Text = "Get"
        getId.UseVisualStyleBackColor = False
        ' 
        ' UContId
        ' 
        UContId.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        UContId.Location = New Point(22, 35)
        UContId.Name = "UContId"
        UContId.PlaceholderText = "Contribution ID"
        UContId.Size = New Size(143, 32)
        UContId.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(304, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 25)
        Label4.TabIndex = 40
        Label4.Text = "Task:"' 
        ' UTask
        ' 
        UTask.Enabled = False
        UTask.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        UTask.FormattingEnabled = True
        UTask.Items.AddRange(New Object() {"Requirement Analysis", "Design", "Development", "Testing"})
        UTask.Location = New Point(372, 34)
        UTask.Name = "UTask"
        UTask.Size = New Size(209, 33)
        UTask.TabIndex = 39
        ' 
        ' UpdateRow
        ' 
        UpdateRow.BackColor = Color.Goldenrod
        UpdateRow.Enabled = False
        UpdateRow.FlatAppearance.BorderSize = 0
        UpdateRow.FlatStyle = FlatStyle.Flat
        UpdateRow.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        UpdateRow.Location = New Point(611, 34)
        UpdateRow.Name = "UpdateRow"
        UpdateRow.Size = New Size(136, 33)
        UpdateRow.TabIndex = 37
        UpdateRow.Text = "Update Task"
        UpdateRow.UseVisualStyleBackColor = False
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(DeleteRow)
        TabPage3.Controls.Add(Del_ID)
        TabPage3.Location = New Point(4, 26)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(768, 95)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Remove"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' DeleteRow
        ' 
        DeleteRow.BackColor = Color.Tomato
        DeleteRow.FlatAppearance.BorderSize = 0
        DeleteRow.FlatStyle = FlatStyle.Flat
        DeleteRow.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteRow.Location = New Point(593, 35)
        DeleteRow.Name = "DeleteRow"
        DeleteRow.Size = New Size(126, 32)
        DeleteRow.TabIndex = 34
        DeleteRow.Text = "Remove"
        DeleteRow.UseVisualStyleBackColor = False
        ' 
        ' Del_ID
        ' 
        Del_ID.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Del_ID.Location = New Point(46, 35)
        Del_ID.Name = "Del_ID"
        Del_ID.PlaceholderText = "Contributor ID"
        Del_ID.Size = New Size(239, 32)
        Del_ID.TabIndex = 33
        ' 
        ' Ok
        ' 
        Ok.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Ok.Location = New Point(696, 41)
        Ok.Name = "Ok"
        Ok.Size = New Size(88, 36)
        Ok.TabIndex = 20
        Ok.Text = "Done"
        Ok.UseVisualStyleBackColor = True
        ' 
        ' Contributors
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Ok)
        Controls.Add(ContributorDataGrid)
        Controls.Add(TabControl)
        Controls.Add(projectId)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Contributors"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Contributors"
        projectId.ResumeLayout(False)
        projectId.PerformLayout()
        CType(ContributorDataGrid, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents projectName As Label
    Friend WithEvents Count As Label
    Friend WithEvents projectId As GroupBox
    Friend WithEvents ContributorDataGrid As DataGridView
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents AddRow As Button
    Friend WithEvents Task As ComboBox
    Friend WithEvents ContId As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UpdateRow As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DeleteRow As Button
    Friend WithEvents Del_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UTask As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Ok As Button
    Friend WithEvents Validate As Button
    Friend WithEvents getId As Button
    Friend WithEvents UContId As TextBox
End Class
