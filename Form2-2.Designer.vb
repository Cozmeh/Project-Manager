<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2_2
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
        Me.EmpName = New System.Windows.Forms.Label()
        Me.EmpId = New System.Windows.Forms.Label()
        Me.PreviousProject = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoutEmp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EmpName
        '
        Me.EmpName.AutoSize = True
        Me.EmpName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmpName.Location = New System.Drawing.Point(131, 69)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(104, 25)
        Me.EmpName.TabIndex = 12
        Me.EmpName.Text = "Emp Name"
        '
        'EmpId
        '
        Me.EmpId.AutoSize = True
        Me.EmpId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmpId.Location = New System.Drawing.Point(131, 39)
        Me.EmpId.Name = "EmpId"
        Me.EmpId.Size = New System.Drawing.Size(70, 25)
        Me.EmpId.TabIndex = 11
        Me.EmpId.Text = "Emp Id"
        '
        'PreviousProject
        '
        Me.PreviousProject.AutoSize = True
        Me.PreviousProject.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PreviousProject.Location = New System.Drawing.Point(23, 116)
        Me.PreviousProject.Name = "PreviousProject"
        Me.PreviousProject.Size = New System.Drawing.Size(75, 25)
        Me.PreviousProject.TabIndex = 10
        Me.PreviousProject.Text = "Project:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(66, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(100, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Id:"
        '
        'LogoutEmp
        '
        Me.LogoutEmp.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutEmp.Location = New System.Drawing.Point(688, 56)
        Me.LogoutEmp.Name = "LogoutEmp"
        Me.LogoutEmp.Size = New System.Drawing.Size(95, 33)
        Me.LogoutEmp.TabIndex = 7
        Me.LogoutEmp.Text = "Logout"
        Me.LogoutEmp.UseVisualStyleBackColor = True
        '
        'Form2_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EmpName)
        Me.Controls.Add(Me.EmpId)
        Me.Controls.Add(Me.PreviousProject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoutEmp)
        Me.Name = "Form2_2"
        Me.Text = "Form2_2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmpName As Label
    Friend WithEvents EmpId As Label
    Friend WithEvents PreviousProject As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutEmp As Button
End Class
