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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeHomePage))
        Me.EmpName = New System.Windows.Forms.Label()
        Me.EmpId = New System.Windows.Forms.Label()
        Me.LogoutEmp = New System.Windows.Forms.Button()
        Me.EmpGrpBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ManagerDataGrid = New System.Windows.Forms.DataGridView()
        Me.EmpGrpBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ManagerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpName
        '
        Me.EmpName.AutoSize = True
        Me.EmpName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmpName.Location = New System.Drawing.Point(90, 59)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(104, 25)
        Me.EmpName.TabIndex = 12
        Me.EmpName.Text = "Emp Name"
        '
        'EmpId
        '
        Me.EmpId.AutoSize = True
        Me.EmpId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmpId.Location = New System.Drawing.Point(90, 19)
        Me.EmpId.Name = "EmpId"
        Me.EmpId.Size = New System.Drawing.Size(70, 25)
        Me.EmpId.TabIndex = 11
        Me.EmpId.Text = "Emp Id"
        '
        'LogoutEmp
        '
        Me.LogoutEmp.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutEmp.Location = New System.Drawing.Point(705, 44)
        Me.LogoutEmp.Name = "LogoutEmp"
        Me.LogoutEmp.Size = New System.Drawing.Size(83, 44)
        Me.LogoutEmp.TabIndex = 7
        Me.LogoutEmp.Text = "Logout"
        Me.LogoutEmp.UseVisualStyleBackColor = True
        '
        'EmpGrpBox
        '
        Me.EmpGrpBox.Controls.Add(Me.Label3)
        Me.EmpGrpBox.Controls.Add(Me.EmpName)
        Me.EmpGrpBox.Controls.Add(Me.Label4)
        Me.EmpGrpBox.Controls.Add(Me.EmpId)
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
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(7, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Id:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(7, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Name  :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ManagerDataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 319)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project(s):"
        '
        'ManagerDataGrid
        '
        Me.ManagerDataGrid.AllowUserToAddRows = False
        Me.ManagerDataGrid.AllowUserToDeleteRows = False
        Me.ManagerDataGrid.AllowUserToResizeColumns = False
        Me.ManagerDataGrid.AllowUserToResizeRows = False
        Me.ManagerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ManagerDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ManagerDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ManagerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ManagerDataGrid.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ManagerDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.ManagerDataGrid.Location = New System.Drawing.Point(6, 40)
        Me.ManagerDataGrid.Name = "ManagerDataGrid"
        Me.ManagerDataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ManagerDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ManagerDataGrid.RowHeadersWidth = 20
        Me.ManagerDataGrid.RowTemplate.Height = 25
        Me.ManagerDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ManagerDataGrid.Size = New System.Drawing.Size(764, 239)
        Me.ManagerDataGrid.TabIndex = 2
        '
        'EmployeeHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EmpGrpBox)
        Me.Controls.Add(Me.LogoutEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EmployeeHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Home Page"
        Me.EmpGrpBox.ResumeLayout(False)
        Me.EmpGrpBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ManagerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmpName As Label
    Friend WithEvents EmpId As Label
    Friend WithEvents LogoutEmp As Button
    Friend WithEvents EmpGrpBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ManagerDataGrid As DataGridView
End Class
