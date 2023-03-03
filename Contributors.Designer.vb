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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        projectName = New Label()
        Count = New Label()
        projectId = New GroupBox()
        ContributorDataGrid = New DataGridView()
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        charactercount = New Label()
        Label5 = New Label()
        AddComment = New RichTextBox()
        Validate = New Button()
        Label3 = New Label()
        AddRow = New Button()
        Task = New ComboBox()
        ContId = New TextBox()
        TabPage2 = New TabPage()
        Label6 = New Label()
        UpdateComment = New RichTextBox()
        getId = New Button()
        UContId = New TextBox()
        Label4 = New Label()
        UTask = New ComboBox()
        UpdateRow = New Button()
        TabPage3 = New TabPage()
        DeleteRow = New Button()
        Del_ID = New TextBox()
        Ok = New Button()
        Label7 = New Label()
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
        TabPage1.Controls.Add(charactercount)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(AddComment)
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
        ' charactercount
        ' 
        charactercount.AutoSize = True
        charactercount.Location = New Point(570, 64)
        charactercount.Name = "charactercount"
        charactercount.Size = New Size(38, 19)
        charactercount.TabIndex = 42
        charactercount.Text = "0/50"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(398, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 25)
        Label5.TabIndex = 41
        Label5.Text = "Comment :"' 
        ' AddComment
        ' 
        AddComment.Location = New Point(398, 33)
        AddComment.Name = "AddComment"
        AddComment.Size = New Size(171, 54)
        AddComment.TabIndex = 40
        AddComment.Text = ""' 
        ' Validate
        ' 
        Validate.BackColor = Color.Silver
        Validate.FlatAppearance.BorderSize = 0
        Validate.FlatStyle = FlatStyle.Flat
        Validate.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Validate.Location = New Point(53, 55)
        Validate.Name = "Validate"
        Validate.Size = New Size(67, 25)
        Validate.TabIndex = 39
        Validate.Text = "Validate"
        Validate.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(217, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 25)
        Label3.TabIndex = 27
        Label3.Text = "Task :"' 
        ' AddRow
        ' 
        AddRow.BackColor = Color.LightSeaGreen
        AddRow.FlatAppearance.BorderSize = 0
        AddRow.FlatStyle = FlatStyle.Flat
        AddRow.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        AddRow.Location = New Point(617, 36)
        AddRow.Name = "AddRow"
        AddRow.Size = New Size(127, 25)
        AddRow.TabIndex = 26
        AddRow.Text = "Add Contributor"
        AddRow.UseVisualStyleBackColor = False
        ' 
        ' Task
        ' 
        Task.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Task.FormattingEnabled = True
        Task.Items.AddRange(New Object() {"UnAssigned", "Requirement Analysis", "Design", "Development", "Testing"})
        Task.Location = New Point(217, 49)
        Task.Name = "Task"
        Task.Size = New Size(154, 25)
        Task.TabIndex = 24
        Task.Text = "Un-Assigned"' 
        ' ContId
        ' 
        ContId.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ContId.Location = New Point(29, 24)
        ContId.Name = "ContId"
        ContId.PlaceholderText = "Contributor ID"
        ContId.Size = New Size(122, 25)
        ContId.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(UpdateComment)
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(398, 7)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 25)
        Label6.TabIndex = 44
        Label6.Text = "Comment :"' 
        ' UpdateComment
        ' 
        UpdateComment.Enabled = False
        UpdateComment.Location = New Point(398, 35)
        UpdateComment.Name = "UpdateComment"
        UpdateComment.Size = New Size(171, 54)
        UpdateComment.TabIndex = 43
        UpdateComment.Text = ""' 
        ' getId
        ' 
        getId.BackColor = Color.Silver
        getId.FlatAppearance.BorderSize = 0
        getId.FlatStyle = FlatStyle.Flat
        getId.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        getId.Location = New Point(52, 55)
        getId.Name = "getId"
        getId.Size = New Size(78, 25)
        getId.TabIndex = 42
        getId.Text = "Get"
        getId.UseVisualStyleBackColor = False
        ' 
        ' UContId
        ' 
        UContId.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UContId.Location = New Point(31, 24)
        UContId.Name = "UContId"
        UContId.PlaceholderText = "Contribution ID"
        UContId.Size = New Size(120, 25)
        UContId.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(213, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 25)
        Label4.TabIndex = 40
        Label4.Text = "Task :"' 
        ' UTask
        ' 
        UTask.Enabled = False
        UTask.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UTask.FormattingEnabled = True
        UTask.Items.AddRange(New Object() {"Requirement Analysis", "Design", "Development", "Testing"})
        UTask.Location = New Point(213, 49)
        UTask.Name = "UTask"
        UTask.Size = New Size(154, 25)
        UTask.TabIndex = 39
        UTask.Text = "Requirement Analysis"' 
        ' UpdateRow
        ' 
        UpdateRow.BackColor = Color.Goldenrod
        UpdateRow.Enabled = False
        UpdateRow.FlatAppearance.BorderSize = 0
        UpdateRow.FlatStyle = FlatStyle.Flat
        UpdateRow.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UpdateRow.Location = New Point(617, 36)
        UpdateRow.Name = "UpdateRow"
        UpdateRow.Size = New Size(127, 25)
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
        DeleteRow.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteRow.Location = New Point(617, 36)
        DeleteRow.Name = "DeleteRow"
        DeleteRow.Size = New Size(127, 25)
        DeleteRow.TabIndex = 34
        DeleteRow.Text = "Remove"
        DeleteRow.UseVisualStyleBackColor = False
        ' 
        ' Del_ID
        ' 
        Del_ID.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Del_ID.Location = New Point(28, 35)
        Del_ID.Name = "Del_ID"
        Del_ID.PlaceholderText = "Contributor ID"
        Del_ID.Size = New Size(188, 25)
        Del_ID.TabIndex = 33
        ' 
        ' Ok
        ' 
        Ok.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Ok.Location = New Point(700, 13)
        Ok.Name = "Ok"
        Ok.Size = New Size(88, 36)
        Ok.TabIndex = 20
        Ok.Text = "Done"
        Ok.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(570, 66)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 19)
        Label7.TabIndex = 45
        Label7.Text = "0/50"' 
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
    Friend WithEvents Label5 As Label
    Friend WithEvents AddComment As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents UpdateComment As RichTextBox
    Friend WithEvents charactercount As Label
    Friend WithEvents Label7 As Label
End Class
