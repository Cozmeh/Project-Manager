<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerHomePage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerHomePage))
        Me.LogoutManager = New System.Windows.Forms.Button()
        Me.NewProject = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ManagerId = New System.Windows.Forms.Label()
        Me.ManagerName = New System.Windows.Forms.Label()
        Me.UsergprBox = New System.Windows.Forms.GroupBox()
        Me.ProjectBox = New System.Windows.Forms.GroupBox()
        Me.ManagerDataGrid = New System.Windows.Forms.DataGridView()
        Me.UsergprBox.SuspendLayout()
        Me.ProjectBox.SuspendLayout()
        CType(Me.ManagerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoutManager
        '
        Me.LogoutManager.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutManager.Location = New System.Drawing.Point(704, 43)
        Me.LogoutManager.Name = "LogoutManager"
        Me.LogoutManager.Size = New System.Drawing.Size(85, 44)
        Me.LogoutManager.TabIndex = 0
        Me.LogoutManager.Text = "Logout"
        Me.LogoutManager.UseVisualStyleBackColor = True
        '
        'NewProject
        '
        Me.NewProject.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewProject.Location = New System.Drawing.Point(704, 402)
        Me.NewProject.Name = "NewProject"
        Me.NewProject.Size = New System.Drawing.Size(84, 40)
        Me.NewProject.TabIndex = 1
        Me.NewProject.Text = "New +"
        Me.NewProject.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(7, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name  :"
        '
        'ManagerId
        '
        Me.ManagerId.AutoSize = True
        Me.ManagerId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ManagerId.Location = New System.Drawing.Point(80, 19)
        Me.ManagerId.Name = "ManagerId"
        Me.ManagerId.Size = New System.Drawing.Size(109, 25)
        Me.ManagerId.TabIndex = 5
        Me.ManagerId.Text = "Manager Id"
        '
        'ManagerName
        '
        Me.ManagerName.AutoSize = True
        Me.ManagerName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ManagerName.Location = New System.Drawing.Point(80, 59)
        Me.ManagerName.Name = "ManagerName"
        Me.ManagerName.Size = New System.Drawing.Size(143, 25)
        Me.ManagerName.TabIndex = 6
        Me.ManagerName.Text = "Manager Name"
        '
        'UsergprBox
        '
        Me.UsergprBox.Controls.Add(Me.ManagerName)
        Me.UsergprBox.Controls.Add(Me.Label1)
        Me.UsergprBox.Controls.Add(Me.ManagerId)
        Me.UsergprBox.Controls.Add(Me.Label2)
        Me.UsergprBox.Location = New System.Drawing.Point(12, 12)
        Me.UsergprBox.Name = "UsergprBox"
        Me.UsergprBox.Size = New System.Drawing.Size(234, 100)
        Me.UsergprBox.TabIndex = 7
        Me.UsergprBox.TabStop = False
        Me.UsergprBox.Text = "Manager"
        '
        'ProjectBox
        '
        Me.ProjectBox.Controls.Add(Me.ManagerDataGrid)
        Me.ProjectBox.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProjectBox.Location = New System.Drawing.Point(12, 118)
        Me.ProjectBox.Name = "ProjectBox"
        Me.ProjectBox.Size = New System.Drawing.Size(776, 278)
        Me.ProjectBox.TabIndex = 15
        Me.ProjectBox.TabStop = False
        Me.ProjectBox.Text = "Projects:"
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
        Me.ManagerDataGrid.Location = New System.Drawing.Point(6, 33)
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
        Me.ManagerDataGrid.TabIndex = 1
        '
        'ManagerHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProjectBox)
        Me.Controls.Add(Me.UsergprBox)
        Me.Controls.Add(Me.NewProject)
        Me.Controls.Add(Me.LogoutManager)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ManagerHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager Home Page"
        Me.UsergprBox.ResumeLayout(False)
        Me.UsergprBox.PerformLayout()
        Me.ProjectBox.ResumeLayout(False)
        CType(Me.ManagerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoutManager As Button
    Friend WithEvents NewProject As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ManagerId As Label
    Friend WithEvents ManagerName As Label
    Friend WithEvents UsergprBox As GroupBox
    Friend WithEvents ProjectBox As GroupBox
    Friend WithEvents ManagerDataGrid As DataGridView
End Class
