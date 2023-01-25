<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2_3
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
        Me.AdminName = New System.Windows.Forms.Label()
        Me.AdminId = New System.Windows.Forms.Label()
        Me.Employees = New System.Windows.Forms.Label()
        Me.LogoutAdmin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdmingprBox = New System.Windows.Forms.GroupBox()
        Me.NewEmployee = New System.Windows.Forms.Button()
        Me.AdmingprBox.SuspendLayout()
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
        'Employees
        '
        Me.Employees.AutoSize = True
        Me.Employees.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Employees.Location = New System.Drawing.Point(12, 150)
        Me.Employees.Name = "Employees"
        Me.Employees.Size = New System.Drawing.Size(111, 25)
        Me.Employees.TabIndex = 16
        Me.Employees.Text = "Employees "
        '
        'LogoutAdmin
        '
        Me.LogoutAdmin.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutAdmin.Location = New System.Drawing.Point(703, 12)
        Me.LogoutAdmin.Name = "LogoutAdmin"
        Me.LogoutAdmin.Size = New System.Drawing.Size(85, 33)
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
        'NewEmployee
        '
        Me.NewEmployee.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewEmployee.Location = New System.Drawing.Point(704, 378)
        Me.NewEmployee.Name = "NewEmployee"
        Me.NewEmployee.Size = New System.Drawing.Size(84, 60)
        Me.NewEmployee.TabIndex = 20
        Me.NewEmployee.Tag = ""
        Me.NewEmployee.Text = "New +"
        Me.NewEmployee.UseVisualStyleBackColor = True
        '
        'Form2_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AdmingprBox)
        Me.Controls.Add(Me.NewEmployee)
        Me.Controls.Add(Me.Employees)
        Me.Controls.Add(Me.LogoutAdmin)
        Me.Name = "Form2_3"
        Me.Text = "Admin Home Page"
        Me.AdmingprBox.ResumeLayout(False)
        Me.AdmingprBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdminName As Label
    Friend WithEvents AdminId As Label
    Friend WithEvents Employees As Label
    Friend WithEvents LogoutAdmin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AdmingprBox As GroupBox
    Friend WithEvents NewEmployee As Button
End Class
