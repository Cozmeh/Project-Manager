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
        Save = New Button()
        Cancel = New Button()
        ContributorDataGrid = New DataGridView()
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        Label3 = New Label()
        AddRow = New Button()
        Add_Designtion = New ComboBox()
        Add_ID = New TextBox()
        TabPage2 = New TabPage()
        ComboBox1 = New ComboBox()
        GetBtn = New Button()
        UpdateRow = New Button()
        Upd_ID = New TextBox()
        TabPage3 = New TabPage()
        DeleteRow = New Button()
        Del_ID = New TextBox()
        Label4 = New Label()
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
        Label1.Location = New Point(73, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 1
        Label1.Text = "Project Id:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 25)
        Label2.TabIndex = 2
        Label2.Text = "Max Contributors:"' 
        ' projectName
        ' 
        projectName.AutoSize = True
        projectName.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        projectName.Location = New Point(175, 19)
        projectName.Name = "projectName"
        projectName.Size = New Size(62, 25)
        projectName.TabIndex = 3
        projectName.Text = "Name"' 
        ' Count
        ' 
        Count.AutoSize = True
        Count.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Count.Location = New Point(175, 55)
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
        projectId.Location = New Point(12, 22)
        projectId.Name = "projectId"
        projectId.Size = New Size(354, 100)
        projectId.TabIndex = 5
        projectId.TabStop = False
        projectId.Text = "Project Id:"' 
        ' Save
        ' 
        Save.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Save.Location = New Point(675, 30)
        Save.Name = "Save"
        Save.Size = New Size(88, 36)
        Save.TabIndex = 16
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Cancel
        ' 
        Cancel.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.Location = New Point(675, 77)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(88, 36)
        Cancel.TabIndex = 17
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
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
        ContributorDataGrid.Location = New Point(20, 296)
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
        ContributorDataGrid.Size = New Size(755, 184)
        ContributorDataGrid.TabIndex = 18
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Controls.Add(TabPage3)
        TabControl.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl.Location = New Point(18, 165)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(763, 125)
        TabControl.TabIndex = 19
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(AddRow)
        TabPage1.Controls.Add(Add_Designtion)
        TabPage1.Controls.Add(Add_ID)
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(755, 95)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(231, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 25)
        Label3.TabIndex = 27
        Label3.Text = "Task:"' 
        ' AddRow
        ' 
        AddRow.BackColor = Color.LightSeaGreen
        AddRow.FlatAppearance.BorderSize = 0
        AddRow.FlatStyle = FlatStyle.Flat
        AddRow.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        AddRow.Location = New Point(569, 33)
        AddRow.Name = "AddRow"
        AddRow.Size = New Size(159, 35)
        AddRow.TabIndex = 26
        AddRow.Text = "Add Contributor"
        AddRow.UseVisualStyleBackColor = False
        ' 
        ' Add_Designtion
        ' 
        Add_Designtion.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Add_Designtion.FormattingEnabled = True
        Add_Designtion.Items.AddRange(New Object() {"Requirement Analysis", "Design", "Development", "Testing"})
        Add_Designtion.Location = New Point(288, 33)
        Add_Designtion.Name = "Add_Designtion"
        Add_Designtion.Size = New Size(157, 33)
        Add_Designtion.TabIndex = 24
        ' 
        ' Add_ID
        ' 
        Add_ID.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Add_ID.Location = New Point(38, 34)
        Add_ID.Name = "Add_ID"
        Add_ID.PlaceholderText = "Contributor ID"
        Add_ID.Size = New Size(131, 32)
        Add_ID.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(ComboBox1)
        TabPage2.Controls.Add(GetBtn)
        TabPage2.Controls.Add(UpdateRow)
        TabPage2.Controls.Add(Upd_ID)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(755, 95)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Update"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Requirement Analysis", "Design", "Development", "Testing"})
        ComboBox1.Location = New Point(364, 30)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(157, 33)
        ComboBox1.TabIndex = 39
        ' 
        ' GetBtn
        ' 
        GetBtn.BackColor = Color.Silver
        GetBtn.FlatAppearance.BorderSize = 0
        GetBtn.FlatStyle = FlatStyle.Flat
        GetBtn.Location = New Point(132, 34)
        GetBtn.Name = "GetBtn"
        GetBtn.Size = New Size(63, 26)
        GetBtn.TabIndex = 38
        GetBtn.Text = "Get"
        GetBtn.UseVisualStyleBackColor = False
        ' 
        ' UpdateRow
        ' 
        UpdateRow.BackColor = Color.Goldenrod
        UpdateRow.FlatAppearance.BorderSize = 0
        UpdateRow.FlatStyle = FlatStyle.Flat
        UpdateRow.Location = New Point(630, 35)
        UpdateRow.Name = "UpdateRow"
        UpdateRow.Size = New Size(100, 25)
        UpdateRow.TabIndex = 37
        UpdateRow.Text = "Update User"
        UpdateRow.UseVisualStyleBackColor = False
        ' 
        ' Upd_ID
        ' 
        Upd_ID.Location = New Point(26, 35)
        Upd_ID.Name = "Upd_ID"
        Upd_ID.PlaceholderText = "UserID"
        Upd_ID.Size = New Size(100, 25)
        Upd_ID.TabIndex = 33
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(DeleteRow)
        TabPage3.Controls.Add(Del_ID)
        TabPage3.Location = New Point(4, 26)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(755, 95)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Remove"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' DeleteRow
        ' 
        DeleteRow.BackColor = Color.Tomato
        DeleteRow.FlatAppearance.BorderSize = 0
        DeleteRow.FlatStyle = FlatStyle.Flat
        DeleteRow.Location = New Point(630, 35)
        DeleteRow.Name = "DeleteRow"
        DeleteRow.Size = New Size(100, 25)
        DeleteRow.TabIndex = 34
        DeleteRow.Text = "Remove"
        DeleteRow.UseVisualStyleBackColor = False
        ' 
        ' Del_ID
        ' 
        Del_ID.Location = New Point(26, 35)
        Del_ID.Name = "Del_ID"
        Del_ID.PlaceholderText = "UserID"
        Del_ID.Size = New Size(227, 25)
        Del_ID.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(293, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 25)
        Label4.TabIndex = 40
        Label4.Text = "Task:"' 
        ' Contributors
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 492)
        Controls.Add(ContributorDataGrid)
        Controls.Add(TabControl)
        Controls.Add(Cancel)
        Controls.Add(Save)
        Controls.Add(projectId)
        Name = "Contributors"
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
    Friend WithEvents Save As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents ContributorDataGrid As DataGridView
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents AddRow As Button
    Friend WithEvents Add_Designtion As ComboBox
    Friend WithEvents Add_ID As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GetBtn As Button
    Friend WithEvents UpdateRow As Button
    Friend WithEvents Upd_ID As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DeleteRow As Button
    Friend WithEvents Del_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
