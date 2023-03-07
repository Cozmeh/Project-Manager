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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeHomePage))
        Me.EmpName = New System.Windows.Forms.Label()
        Me.EmpId = New System.Windows.Forms.Label()
        Me.EmpGrpBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TaskDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoutEmp = New System.Windows.Forms.Button()
        Me.EmpGrpBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TaskDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpName
        '
        Me.EmpName.AutoSize = True
        Me.EmpName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmpName.Location = New System.Drawing.Point(76, 56)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(107, 25)
        Me.EmpName.TabIndex = 12
        Me.EmpName.Text = "Emp Name"
        '
        'EmpId
        '
        Me.EmpId.AutoSize = True
        Me.EmpId.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmpId.Location = New System.Drawing.Point(76, 20)
        Me.EmpId.Name = "EmpId"
        Me.EmpId.Size = New System.Drawing.Size(72, 25)
        Me.EmpId.TabIndex = 11
        Me.EmpId.Text = "Emp Id"
        '
        'EmpGrpBox
        '
        Me.EmpGrpBox.Controls.Add(Me.Label3)
        Me.EmpGrpBox.Controls.Add(Me.EmpName)
        Me.EmpGrpBox.Controls.Add(Me.Label4)
        Me.EmpGrpBox.Controls.Add(Me.EmpId)
        Me.EmpGrpBox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.EmpGrpBox.Location = New System.Drawing.Point(12, 13)
        Me.EmpGrpBox.Name = "EmpGrpBox"
        Me.EmpGrpBox.Size = New System.Drawing.Size(234, 100)
        Me.EmpGrpBox.TabIndex = 13
        Me.EmpGrpBox.TabStop = False
        Me.EmpGrpBox.Text = "Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Id :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(7, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Name   :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TaskDataGrid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 319)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project(s)"
        '
        'TaskDataGrid
        '
        Me.TaskDataGrid.AllowUserToAddRows = False
        Me.TaskDataGrid.AllowUserToDeleteRows = False
        Me.TaskDataGrid.AllowUserToResizeColumns = False
        Me.TaskDataGrid.AllowUserToResizeRows = False
        Me.TaskDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TaskDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TaskDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TaskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaskDataGrid.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TaskDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.TaskDataGrid.Location = New System.Drawing.Point(7, 30)
        Me.TaskDataGrid.Name = "TaskDataGrid"
        Me.TaskDataGrid.ReadOnly = True
        Me.TaskDataGrid.RowHeadersWidth = 20
        Me.TaskDataGrid.RowTemplate.Height = 25
        Me.TaskDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TaskDataGrid.Size = New System.Drawing.Size(764, 283)
        Me.TaskDataGrid.TabIndex = 2
        Me.TaskDataGrid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(45, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(638, 37)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "All of your past and ongoing task will be shown here"
        '
        'LogoutEmp
        '
        Me.LogoutEmp.BackColor = System.Drawing.Color.Silver
        Me.LogoutEmp.FlatAppearance.BorderSize = 0
        Me.LogoutEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutEmp.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutEmp.Image = Global.ProjectManager.My.Resources.Resources.Log_out2
        Me.LogoutEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LogoutEmp.Location = New System.Drawing.Point(688, 12)
        Me.LogoutEmp.Name = "LogoutEmp"
        Me.LogoutEmp.Size = New System.Drawing.Size(100, 44)
        Me.LogoutEmp.TabIndex = 15
        Me.LogoutEmp.Text = "Logout"
        Me.LogoutEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutEmp.UseVisualStyleBackColor = False
        '
        'EmployeeHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogoutEmp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EmpGrpBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EmployeeHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Home Page"
        Me.EmpGrpBox.ResumeLayout(False)
        Me.EmpGrpBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TaskDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmpName As Label
    Friend WithEvents EmpId As Label
    Friend WithEvents EmpGrpBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TaskDataGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutEmp As Button
End Class
