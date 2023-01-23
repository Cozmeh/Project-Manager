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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoutAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AdminName
        '
        Me.AdminName.AutoSize = True
        Me.AdminName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AdminName.Location = New System.Drawing.Point(126, 72)
        Me.AdminName.Name = "AdminName"
        Me.AdminName.Size = New System.Drawing.Size(122, 25)
        Me.AdminName.TabIndex = 18
        Me.AdminName.Text = "Admin Name"
        '
        'AdminId
        '
        Me.AdminId.AutoSize = True
        Me.AdminId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AdminId.Location = New System.Drawing.Point(126, 42)
        Me.AdminId.Name = "AdminId"
        Me.AdminId.Size = New System.Drawing.Size(88, 25)
        Me.AdminId.TabIndex = 17
        Me.AdminId.Text = "Admin Id"
        '
        'Employees
        '
        Me.Employees.AutoSize = True
        Me.Employees.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Employees.Location = New System.Drawing.Point(18, 119)
        Me.Employees.Name = "Employees"
        Me.Employees.Size = New System.Drawing.Size(106, 25)
        Me.Employees.TabIndex = 16
        Me.Employees.Text = "Employees:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(61, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(95, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Id:"
        '
        'LogoutAdmin
        '
        Me.LogoutAdmin.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutAdmin.Location = New System.Drawing.Point(683, 59)
        Me.LogoutAdmin.Name = "LogoutAdmin"
        Me.LogoutAdmin.Size = New System.Drawing.Size(95, 33)
        Me.LogoutAdmin.TabIndex = 13
        Me.LogoutAdmin.Text = "Logout"
        Me.LogoutAdmin.UseVisualStyleBackColor = True
        '
        'Form2_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AdminName)
        Me.Controls.Add(Me.AdminId)
        Me.Controls.Add(Me.Employees)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoutAdmin)
        Me.Name = "Form2_3"
        Me.Text = "Admin Home Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdminName As Label
    Friend WithEvents AdminId As Label
    Friend WithEvents Employees As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutAdmin As Button
End Class
