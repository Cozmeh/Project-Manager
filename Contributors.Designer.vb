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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.projectName = New System.Windows.Forms.Label()
        Me.Count = New System.Windows.Forms.Label()
        Me.projectId = New System.Windows.Forms.GroupBox()
        Me.ContributorDataGrid = New System.Windows.Forms.DataGridView()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.charactercount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddComment = New System.Windows.Forms.RichTextBox()
        Me.Validate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddRow = New System.Windows.Forms.Button()
        Me.Task = New System.Windows.Forms.ComboBox()
        Me.ContId = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UpdateRow = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UpdateComment = New System.Windows.Forms.RichTextBox()
        Me.getId = New System.Windows.Forms.Button()
        Me.UContId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UTask = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DeleteRow = New System.Windows.Forms.Button()
        Me.Del_ID = New System.Windows.Forms.TextBox()
        Me.Ok = New System.Windows.Forms.Button()
        Me.projectId.SuspendLayout()
        CType(Me.ContributorDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(48, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Project Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Max Contributors :"
        '
        'projectName
        '
        Me.projectName.AutoSize = True
        Me.projectName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.projectName.Location = New System.Drawing.Point(165, 20)
        Me.projectName.Name = "projectName"
        Me.projectName.Size = New System.Drawing.Size(64, 25)
        Me.projectName.TabIndex = 3
        Me.projectName.Text = "Name"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Count.Location = New System.Drawing.Point(165, 55)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(64, 25)
        Me.Count.TabIndex = 4
        Me.Count.Text = "Count"
        '
        'projectId
        '
        Me.projectId.Controls.Add(Me.Label2)
        Me.projectId.Controls.Add(Me.Count)
        Me.projectId.Controls.Add(Me.Label1)
        Me.projectId.Controls.Add(Me.projectName)
        Me.projectId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.projectId.Location = New System.Drawing.Point(12, 13)
        Me.projectId.Name = "projectId"
        Me.projectId.Size = New System.Drawing.Size(354, 100)
        Me.projectId.TabIndex = 5
        Me.projectId.TabStop = False
        Me.projectId.Text = "Project Id:"
        '
        'ContributorDataGrid
        '
        Me.ContributorDataGrid.AllowUserToAddRows = False
        Me.ContributorDataGrid.AllowUserToDeleteRows = False
        Me.ContributorDataGrid.AllowUserToResizeColumns = False
        Me.ContributorDataGrid.AllowUserToResizeRows = False
        Me.ContributorDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ContributorDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContributorDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ContributorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContributorDataGrid.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ContributorDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.ContributorDataGrid.Location = New System.Drawing.Point(12, 246)
        Me.ContributorDataGrid.Name = "ContributorDataGrid"
        Me.ContributorDataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContributorDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ContributorDataGrid.RowHeadersWidth = 20
        Me.ContributorDataGrid.RowTemplate.Height = 25
        Me.ContributorDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ContributorDataGrid.Size = New System.Drawing.Size(776, 192)
        Me.ContributorDataGrid.TabIndex = 18
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabControl.Location = New System.Drawing.Point(12, 119)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(776, 125)
        Me.TabControl.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.charactercount)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.AddComment)
        Me.TabPage1.Controls.Add(Me.Validate)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.AddRow)
        Me.TabPage1.Controls.Add(Me.Task)
        Me.TabPage1.Controls.Add(Me.ContId)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 95)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'charactercount
        '
        Me.charactercount.AutoSize = True
        Me.charactercount.Location = New System.Drawing.Point(527, 9)
        Me.charactercount.Name = "charactercount"
        Me.charactercount.Size = New System.Drawing.Size(38, 19)
        Me.charactercount.TabIndex = 42
        Me.charactercount.Text = "0/50"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(381, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 21)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Comment "
        '
        'AddComment
        '
        Me.AddComment.Location = New System.Drawing.Point(381, 29)
        Me.AddComment.Name = "AddComment"
        Me.AddComment.Size = New System.Drawing.Size(184, 49)
        Me.AddComment.TabIndex = 40
        Me.AddComment.Text = ""
        '
        'Validate
        '
        Me.Validate.BackColor = System.Drawing.Color.Silver
        Me.Validate.FlatAppearance.BorderSize = 0
        Me.Validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Validate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Validate.Location = New System.Drawing.Point(29, 53)
        Me.Validate.Name = "Validate"
        Me.Validate.Size = New System.Drawing.Size(122, 25)
        Me.Validate.TabIndex = 39
        Me.Validate.Text = "Validate"
        Me.Validate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(196, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Task "
        '
        'AddRow
        '
        Me.AddRow.BackColor = System.Drawing.Color.LightSeaGreen
        Me.AddRow.FlatAppearance.BorderSize = 0
        Me.AddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddRow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddRow.Location = New System.Drawing.Point(614, 29)
        Me.AddRow.Name = "AddRow"
        Me.AddRow.Size = New System.Drawing.Size(127, 38)
        Me.AddRow.TabIndex = 26
        Me.AddRow.Text = "Add Contributor"
        Me.AddRow.UseVisualStyleBackColor = False
        '
        'Task
        '
        Me.Task.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Task.FormattingEnabled = True
        Me.Task.Items.AddRange(New Object() {"UnAssigned", "Requirement Analysis", "Design", "Development", "Testing"})
        Me.Task.Location = New System.Drawing.Point(196, 53)
        Me.Task.Name = "Task"
        Me.Task.Size = New System.Drawing.Size(154, 25)
        Me.Task.TabIndex = 24
        Me.Task.Text = "Un-Assigned"
        '
        'ContId
        '
        Me.ContId.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ContId.Location = New System.Drawing.Point(29, 22)
        Me.ContId.Name = "ContId"
        Me.ContId.PlaceholderText = "Contributor ID"
        Me.ContId.Size = New System.Drawing.Size(122, 25)
        Me.ContId.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.UpdateRow)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.UpdateComment)
        Me.TabPage2.Controls.Add(Me.getId)
        Me.TabPage2.Controls.Add(Me.UContId)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.UTask)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 95)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Update"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'UpdateRow
        '
        Me.UpdateRow.BackColor = System.Drawing.Color.Goldenrod
        Me.UpdateRow.FlatAppearance.BorderSize = 0
        Me.UpdateRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateRow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateRow.Location = New System.Drawing.Point(614, 29)
        Me.UpdateRow.Name = "UpdateRow"
        Me.UpdateRow.Size = New System.Drawing.Size(127, 38)
        Me.UpdateRow.TabIndex = 46
        Me.UpdateRow.Text = "Update"
        Me.UpdateRow.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(527, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 19)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "0/50"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(381, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 21)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Comment "
        '
        'UpdateComment
        '
        Me.UpdateComment.Enabled = False
        Me.UpdateComment.Location = New System.Drawing.Point(381, 29)
        Me.UpdateComment.Name = "UpdateComment"
        Me.UpdateComment.Size = New System.Drawing.Size(184, 49)
        Me.UpdateComment.TabIndex = 43
        Me.UpdateComment.Text = ""
        '
        'getId
        '
        Me.getId.BackColor = System.Drawing.Color.Silver
        Me.getId.FlatAppearance.BorderSize = 0
        Me.getId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.getId.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.getId.Location = New System.Drawing.Point(29, 53)
        Me.getId.Name = "getId"
        Me.getId.Size = New System.Drawing.Size(122, 25)
        Me.getId.TabIndex = 42
        Me.getId.Text = "Get"
        Me.getId.UseVisualStyleBackColor = False
        '
        'UContId
        '
        Me.UContId.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UContId.Location = New System.Drawing.Point(29, 22)
        Me.UContId.Name = "UContId"
        Me.UContId.PlaceholderText = "Contribution ID"
        Me.UContId.Size = New System.Drawing.Size(122, 25)
        Me.UContId.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(196, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Task "
        '
        'UTask
        '
        Me.UTask.Enabled = False
        Me.UTask.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UTask.FormattingEnabled = True
        Me.UTask.Items.AddRange(New Object() {"Requirement Analysis", "Design", "Development", "Testing"})
        Me.UTask.Location = New System.Drawing.Point(196, 53)
        Me.UTask.Name = "UTask"
        Me.UTask.Size = New System.Drawing.Size(154, 25)
        Me.UTask.TabIndex = 39
        Me.UTask.Text = "Requirement Analysis"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DeleteRow)
        Me.TabPage3.Controls.Add(Me.Del_ID)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(768, 95)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Remove"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DeleteRow
        '
        Me.DeleteRow.BackColor = System.Drawing.Color.Tomato
        Me.DeleteRow.FlatAppearance.BorderSize = 0
        Me.DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteRow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteRow.Location = New System.Drawing.Point(614, 29)
        Me.DeleteRow.Name = "DeleteRow"
        Me.DeleteRow.Size = New System.Drawing.Size(127, 38)
        Me.DeleteRow.TabIndex = 34
        Me.DeleteRow.Text = "Remove"
        Me.DeleteRow.UseVisualStyleBackColor = False
        '
        'Del_ID
        '
        Me.Del_ID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Del_ID.Location = New System.Drawing.Point(26, 36)
        Me.Del_ID.Name = "Del_ID"
        Me.Del_ID.PlaceholderText = "Contributor ID"
        Me.Del_ID.Size = New System.Drawing.Size(188, 25)
        Me.Del_ID.TabIndex = 33
        '
        'Ok
        '
        Me.Ok.BackColor = System.Drawing.Color.Silver
        Me.Ok.FlatAppearance.BorderSize = 0
        Me.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ok.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ok.Location = New System.Drawing.Point(700, 13)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(88, 45)
        Me.Ok.TabIndex = 20
        Me.Ok.Text = "Done"
        Me.Ok.UseVisualStyleBackColor = False
        '
        'Contributors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.ContributorDataGrid)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.projectId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Contributors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contributors"
        Me.projectId.ResumeLayout(False)
        Me.projectId.PerformLayout()
        CType(Me.ContributorDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents UpdateRow As Button
End Class
