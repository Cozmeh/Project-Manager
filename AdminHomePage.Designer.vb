<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomePage
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AdminName = New System.Windows.Forms.Label()
        Me.AdminId = New System.Windows.Forms.Label()
        Me.LogoutAdmin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdmingprBox = New System.Windows.Forms.GroupBox()
        Me.EmpBox = New System.Windows.Forms.GroupBox()
        Me.AdminDataGrid = New System.Windows.Forms.DataGridView()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AddRow = New System.Windows.Forms.Button()
        Me.Add_Password = New System.Windows.Forms.TextBox()
        Me.Add_Designtion = New System.Windows.Forms.ComboBox()
        Me.Add_EmpName = New System.Windows.Forms.TextBox()
        Me.Add_ID = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AdmingprBox.SuspendLayout()
        Me.EmpBox.SuspendLayout()
        CType(Me.AdminDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdminName
        '
        Me.AdminName.AutoSize = True
        Me.AdminName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AdminName.Location = New System.Drawing.Point(84, 59)
        Me.AdminName.Name = "AdminName"
        Me.AdminName.Size = New System.Drawing.Size(122, 25)
        Me.AdminName.TabIndex = 18
        Me.AdminName.Text = "Admin Name"
        '
        'AdminId
        '
        Me.AdminId.AutoSize = True
        Me.AdminId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AdminId.Location = New System.Drawing.Point(84, 18)
        Me.AdminId.Name = "AdminId"
        Me.AdminId.Size = New System.Drawing.Size(88, 25)
        Me.AdminId.TabIndex = 17
        Me.AdminId.Text = "Admin Id"
        '
        'LogoutAdmin
        '
        Me.LogoutAdmin.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutAdmin.Location = New System.Drawing.Point(704, 43)
        Me.LogoutAdmin.Name = "LogoutAdmin"
        Me.LogoutAdmin.Size = New System.Drawing.Size(85, 44)
        Me.LogoutAdmin.TabIndex = 13
        Me.LogoutAdmin.Text = "Logout"
        Me.LogoutAdmin.UseVisualStyleBackColor = True
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(7, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UserID :"
        '
        'AdmingprBox
        '
        Me.AdmingprBox.Controls.Add(Me.Label3)
        Me.AdmingprBox.Controls.Add(Me.Label4)
        Me.AdmingprBox.Controls.Add(Me.AdminName)
        Me.AdmingprBox.Controls.Add(Me.AdminId)
        Me.AdmingprBox.Location = New System.Drawing.Point(12, 12)
        Me.AdmingprBox.Name = "AdmingprBox"
        Me.AdmingprBox.Size = New System.Drawing.Size(220, 100)
        Me.AdmingprBox.TabIndex = 22
        Me.AdmingprBox.TabStop = False
        Me.AdmingprBox.Text = "Admin"
        '
        'EmpBox
        '
        Me.EmpBox.Controls.Add(Me.AdminDataGrid)
        Me.EmpBox.Controls.Add(Me.TabControl)
        Me.EmpBox.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmpBox.Location = New System.Drawing.Point(12, 118)
        Me.EmpBox.Name = "EmpBox"
        Me.EmpBox.Size = New System.Drawing.Size(776, 362)
        Me.EmpBox.TabIndex = 23
        Me.EmpBox.TabStop = False
        Me.EmpBox.Text = "Employees:"
        '
        'AdminDataGrid
        '
        Me.AdminDataGrid.AllowUserToResizeColumns = False
        Me.AdminDataGrid.AllowUserToResizeRows = False
        Me.AdminDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdminDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.AdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AdminDataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.AdminDataGrid.Location = New System.Drawing.Point(11, 164)
        Me.AdminDataGrid.Name = "AdminDataGrid"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdminDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.AdminDataGrid.RowTemplate.Height = 25
        Me.AdminDataGrid.Size = New System.Drawing.Size(755, 184)
        Me.AdminDataGrid.TabIndex = 0
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabControl.Location = New System.Drawing.Point(7, 33)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(763, 125)
        Me.TabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AddRow)
        Me.TabPage1.Controls.Add(Me.Add_Password)
        Me.TabPage1.Controls.Add(Me.Add_Designtion)
        Me.TabPage1.Controls.Add(Me.Add_EmpName)
        Me.TabPage1.Controls.Add(Me.Add_ID)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(755, 95)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AddRow
        '
        Me.AddRow.Location = New System.Drawing.Point(636, 35)
        Me.AddRow.Name = "AddRow"
        Me.AddRow.Size = New System.Drawing.Size(75, 25)
        Me.AddRow.TabIndex = 26
        Me.AddRow.Text = "Add Row"
        Me.AddRow.UseVisualStyleBackColor = True
        '
        'Add_Password
        '
        Me.Add_Password.Location = New System.Drawing.Point(423, 35)
        Me.Add_Password.Name = "Add_Password"
        Me.Add_Password.PlaceholderText = "Password"
        Me.Add_Password.Size = New System.Drawing.Size(100, 25)
        Me.Add_Password.TabIndex = 25
        '
        'Add_Designtion
        '
        Me.Add_Designtion.FormattingEnabled = True
        Me.Add_Designtion.Items.AddRange(New Object() {"E ", "M "})
        Me.Add_Designtion.Location = New System.Drawing.Point(283, 35)
        Me.Add_Designtion.Name = "Add_Designtion"
        Me.Add_Designtion.Size = New System.Drawing.Size(100, 25)
        Me.Add_Designtion.TabIndex = 24
        '
        'Add_EmpName
        '
        Me.Add_EmpName.Location = New System.Drawing.Point(155, 35)
        Me.Add_EmpName.Name = "Add_EmpName"
        Me.Add_EmpName.PlaceholderText = "Name"
        Me.Add_EmpName.Size = New System.Drawing.Size(100, 25)
        Me.Add_EmpName.TabIndex = 1
        '
        'Add_ID
        '
        Me.Add_ID.Location = New System.Drawing.Point(28, 35)
        Me.Add_ID.Name = "Add_ID"
        Me.Add_ID.PlaceholderText = "UserID"
        Me.Add_ID.Size = New System.Drawing.Size(100, 25)
        Me.Add_ID.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(755, 95)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Delete"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(755, 95)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Update"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AdminHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 492)
        Me.Controls.Add(Me.EmpBox)
        Me.Controls.Add(Me.AdmingprBox)
        Me.Controls.Add(Me.LogoutAdmin)
        Me.Name = "AdminHomePage"
        Me.Text = "Admin Home Page"
        Me.AdmingprBox.ResumeLayout(False)
        Me.AdmingprBox.PerformLayout()
        Me.EmpBox.ResumeLayout(False)
        CType(Me.AdminDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminName As Label
    Friend WithEvents AdminId As Label
    Friend WithEvents LogoutAdmin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AdmingprBox As GroupBox
    Friend WithEvents EmpBox As GroupBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents AdminDataGrid As DataGridView
    Friend WithEvents Add_EmpName As TextBox
    Friend WithEvents Add_ID As TextBox
    Friend WithEvents Add_Designtion As ComboBox
    Friend WithEvents Add_Password As TextBox
    Friend WithEvents AddRow As Button
End Class
