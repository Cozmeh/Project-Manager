<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeHomePage
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(EmployeeHomePage))
        EmpName = New Label()
        EmpId = New Label()
        LogoutEmp = New Button()
        EmpGrpBox = New GroupBox()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        TaskDataGrid = New DataGridView()
        Label1 = New Label()
        EmpGrpBox.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(TaskDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EmpName
        ' 
        EmpName.AutoSize = True
        EmpName.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        EmpName.Location = New Point(90, 59)
        EmpName.Name = "EmpName"
        EmpName.Size = New Size(104, 25)
        EmpName.TabIndex = 12
        EmpName.Text = "Emp Name"' 
        ' EmpId
        ' 
        EmpId.AutoSize = True
        EmpId.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        EmpId.Location = New Point(90, 19)
        EmpId.Name = "EmpId"
        EmpId.Size = New Size(70, 25)
        EmpId.TabIndex = 11
        EmpId.Text = "Emp Id"' 
        ' LogoutEmp
        ' 
        LogoutEmp.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LogoutEmp.Location = New Point(705, 44)
        LogoutEmp.Name = "LogoutEmp"
        LogoutEmp.Size = New Size(83, 44)
        LogoutEmp.TabIndex = 7
        LogoutEmp.Text = "Logout"
        LogoutEmp.UseVisualStyleBackColor = True
        ' 
        ' EmpGrpBox
        ' 
        EmpGrpBox.Controls.Add(Label3)
        EmpGrpBox.Controls.Add(EmpName)
        EmpGrpBox.Controls.Add(Label4)
        EmpGrpBox.Controls.Add(EmpId)
        EmpGrpBox.Location = New Point(12, 13)
        EmpGrpBox.Name = "EmpGrpBox"
        EmpGrpBox.Size = New Size(234, 100)
        EmpGrpBox.TabIndex = 13
        EmpGrpBox.TabStop = False
        EmpGrpBox.Text = "Employee"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(7, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 25)
        Label3.TabIndex = 2
        Label3.Text = "User Id:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(7, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 25)
        Label4.TabIndex = 3
        Label4.Text = "Name  :"' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TaskDataGrid)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 119)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 319)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Project(s):"' 
        ' TaskDataGrid
        ' 
        TaskDataGrid.AllowUserToAddRows = False
        TaskDataGrid.AllowUserToDeleteRows = False
        TaskDataGrid.AllowUserToResizeColumns = False
        TaskDataGrid.AllowUserToResizeRows = False
        TaskDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TaskDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        TaskDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        TaskDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TaskDataGrid.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        TaskDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        TaskDataGrid.Location = New Point(7, 39)
        TaskDataGrid.Name = "TaskDataGrid"
        TaskDataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        TaskDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        TaskDataGrid.RowHeadersWidth = 20
        TaskDataGrid.RowTemplate.Height = 25
        TaskDataGrid.ScrollBars = ScrollBars.Vertical
        TaskDataGrid.Size = New Size(764, 269)
        TaskDataGrid.TabIndex = 2
        TaskDataGrid.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(45, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(638, 37)
        Label1.TabIndex = 15
        Label1.Text = "All of your past and ongoing task will be shown here"' 
        ' EmployeeHomePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(EmpGrpBox)
        Controls.Add(LogoutEmp)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "EmployeeHomePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Home Page"
        EmpGrpBox.ResumeLayout(False)
        EmpGrpBox.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(TaskDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmpName As Label
    Friend WithEvents EmpId As Label
    Friend WithEvents LogoutEmp As Button
    Friend WithEvents EmpGrpBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TaskDataGrid As DataGridView
    Friend WithEvents Label1 As Label
End Class
