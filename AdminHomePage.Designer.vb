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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHomePage))
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
        Me.GetBtn = New System.Windows.Forms.Button()
        Me.UpdateRow = New System.Windows.Forms.Button()
        Me.Upd_Password = New System.Windows.Forms.TextBox()
        Me.Upd_Designation = New System.Windows.Forms.ComboBox()
        Me.Upd_Name = New System.Windows.Forms.TextBox()
        Me.Upd_ID = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DeleteRow = New System.Windows.Forms.Button()
        Me.Del_ID = New System.Windows.Forms.TextBox()
        Me.AdmingprBox.SuspendLayout()
        Me.EmpBox.SuspendLayout()
        CType(Me.AdminDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.AdminDataGrid.AllowUserToAddRows = False
        Me.AdminDataGrid.AllowUserToDeleteRows = False
        Me.AdminDataGrid.AllowUserToResizeColumns = False
        Me.AdminDataGrid.AllowUserToResizeRows = False
        Me.AdminDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AdminDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdminDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDataGrid.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AdminDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.AdminDataGrid.Location = New System.Drawing.Point(11, 164)
        Me.AdminDataGrid.Name = "AdminDataGrid"
        Me.AdminDataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdminDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AdminDataGrid.RowHeadersWidth = 20
        Me.AdminDataGrid.RowTemplate.Height = 25
        Me.AdminDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
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
        Me.AddRow.BackColor = System.Drawing.Color.LightSeaGreen
        Me.AddRow.FlatAppearance.BorderSize = 0
        Me.AddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddRow.Location = New System.Drawing.Point(630, 35)
        Me.AddRow.Name = "AddRow"
        Me.AddRow.Size = New System.Drawing.Size(100, 25)
        Me.AddRow.TabIndex = 26
        Me.AddRow.Text = "Add Row"
        Me.AddRow.UseVisualStyleBackColor = False
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
        Me.Add_Designtion.Items.AddRange(New Object() {"E", "M"})
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
        Me.TabPage2.Controls.Add(Me.GetBtn)
        Me.TabPage2.Controls.Add(Me.UpdateRow)
        Me.TabPage2.Controls.Add(Me.Upd_Password)
        Me.TabPage2.Controls.Add(Me.Upd_Designation)
        Me.TabPage2.Controls.Add(Me.Upd_Name)
        Me.TabPage2.Controls.Add(Me.Upd_ID)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(755, 95)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GetBtn
        '
        Me.GetBtn.BackColor = System.Drawing.Color.Silver
        Me.GetBtn.FlatAppearance.BorderSize = 0
        Me.GetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GetBtn.Location = New System.Drawing.Point(132, 34)
        Me.GetBtn.Name = "GetBtn"
        Me.GetBtn.Size = New System.Drawing.Size(63, 26)
        Me.GetBtn.TabIndex = 38
        Me.GetBtn.Text = "Get"
        Me.GetBtn.UseVisualStyleBackColor = False
        '
        'UpdateRow
        '
        Me.UpdateRow.BackColor = System.Drawing.Color.Goldenrod
        Me.UpdateRow.FlatAppearance.BorderSize = 0
        Me.UpdateRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateRow.Location = New System.Drawing.Point(630, 35)
        Me.UpdateRow.Name = "UpdateRow"
        Me.UpdateRow.Size = New System.Drawing.Size(100, 25)
        Me.UpdateRow.TabIndex = 37
        Me.UpdateRow.Text = "Update Row"
        Me.UpdateRow.UseVisualStyleBackColor = False
        '
        'Upd_Password
        '
        Me.Upd_Password.Location = New System.Drawing.Point(497, 35)
        Me.Upd_Password.Name = "Upd_Password"
        Me.Upd_Password.PlaceholderText = "Password"
        Me.Upd_Password.Size = New System.Drawing.Size(100, 25)
        Me.Upd_Password.TabIndex = 36
        '
        'Upd_Designation
        '
        Me.Upd_Designation.FormattingEnabled = True
        Me.Upd_Designation.Items.AddRange(New Object() {"E", "M"})
        Me.Upd_Designation.Location = New System.Drawing.Point(368, 35)
        Me.Upd_Designation.Name = "Upd_Designation"
        Me.Upd_Designation.Size = New System.Drawing.Size(100, 25)
        Me.Upd_Designation.TabIndex = 35
        '
        'Upd_Name
        '
        Me.Upd_Name.Location = New System.Drawing.Point(237, 35)
        Me.Upd_Name.Name = "Upd_Name"
        Me.Upd_Name.PlaceholderText = "Name"
        Me.Upd_Name.Size = New System.Drawing.Size(100, 25)
        Me.Upd_Name.TabIndex = 34
        '
        'Upd_ID
        '
        Me.Upd_ID.Location = New System.Drawing.Point(26, 35)
        Me.Upd_ID.Name = "Upd_ID"
        Me.Upd_ID.PlaceholderText = "UserID"
        Me.Upd_ID.Size = New System.Drawing.Size(100, 25)
        Me.Upd_ID.TabIndex = 33
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DeleteRow)
        Me.TabPage3.Controls.Add(Me.Del_ID)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(755, 95)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Delete"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DeleteRow
        '
        Me.DeleteRow.BackColor = System.Drawing.Color.Tomato
        Me.DeleteRow.FlatAppearance.BorderSize = 0
        Me.DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteRow.Location = New System.Drawing.Point(630, 35)
        Me.DeleteRow.Name = "DeleteRow"
        Me.DeleteRow.Size = New System.Drawing.Size(100, 25)
        Me.DeleteRow.TabIndex = 34
        Me.DeleteRow.Text = "Delete Row"
        Me.DeleteRow.UseVisualStyleBackColor = False
        '
        'Del_ID
        '
        Me.Del_ID.Location = New System.Drawing.Point(26, 35)
        Me.Del_ID.Name = "Del_ID"
        Me.Del_ID.PlaceholderText = "UserID"
        Me.Del_ID.Size = New System.Drawing.Size(227, 25)
        Me.Del_ID.TabIndex = 33
        '
        'AdminHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 492)
        Me.Controls.Add(Me.EmpBox)
        Me.Controls.Add(Me.AdmingprBox)
        Me.Controls.Add(Me.LogoutAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdminHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Home Page"
        Me.AdmingprBox.ResumeLayout(False)
        Me.AdmingprBox.PerformLayout()
        Me.EmpBox.ResumeLayout(False)
        CType(Me.AdminDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
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
    Friend WithEvents GetBtn As Button
    Friend WithEvents UpdateRow As Button
    Friend WithEvents Upd_Password As TextBox
    Friend WithEvents Upd_Designation As ComboBox
    Friend WithEvents Upd_Name As TextBox
    Friend WithEvents Upd_ID As TextBox
    Friend WithEvents DeleteRow As Button
    Friend WithEvents Del_ID As TextBox
End Class
