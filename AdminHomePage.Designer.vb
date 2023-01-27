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
        Me.AdminName = New System.Windows.Forms.Label()
        Me.AdminId = New System.Windows.Forms.Label()
        Me.LogoutAdmin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdmingprBox = New System.Windows.Forms.GroupBox()
        Me.EmpBox = New System.Windows.Forms.GroupBox()
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
        Me.EmpBox.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmpBox.Location = New System.Drawing.Point(12, 118)
        Me.EmpBox.Name = "EmpBox"
        Me.EmpBox.Size = New System.Drawing.Size(776, 278)
        Me.EmpBox.TabIndex = 23
        Me.EmpBox.TabStop = False
        Me.EmpBox.Text = "Employees:"
        '
        'AdminHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 408)
        Me.Controls.Add(Me.EmpBox)
        Me.Controls.Add(Me.AdmingprBox)
        Me.Controls.Add(Me.LogoutAdmin)
        Me.Name = "AdminHomePage"
        Me.Text = "Admin Home Page"
        Me.AdmingprBox.ResumeLayout(False)
        Me.AdmingprBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminName As Label
    Friend WithEvents AdminId As Label
    Friend WithEvents LogoutAdmin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AdmingprBox As GroupBox
    Friend WithEvents EmpBox As GroupBox
End Class
