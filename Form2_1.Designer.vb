<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2_1
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
        Me.LogoutManager = New System.Windows.Forms.Button()
        Me.NewProject = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PreviousProject = New System.Windows.Forms.Label()
        Me.ManagerId = New System.Windows.Forms.Label()
        Me.ManagerName = New System.Windows.Forms.Label()
        Me.UsergprBox = New System.Windows.Forms.GroupBox()
        Me.UsergprBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoutManager
        '
        Me.LogoutManager.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutManager.Location = New System.Drawing.Point(703, 12)
        Me.LogoutManager.Name = "LogoutManager"
        Me.LogoutManager.Size = New System.Drawing.Size(85, 33)
        Me.LogoutManager.TabIndex = 0
        Me.LogoutManager.Text = "Logout"
        Me.LogoutManager.UseVisualStyleBackColor = True
        '
        'NewProject
        '
        Me.NewProject.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewProject.Location = New System.Drawing.Point(704, 378)
        Me.NewProject.Name = "NewProject"
        Me.NewProject.Size = New System.Drawing.Size(84, 60)
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
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "UserID :"
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
        'PreviousProject
        '
        Me.PreviousProject.AutoSize = True
        Me.PreviousProject.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PreviousProject.Location = New System.Drawing.Point(12, 146)
        Me.PreviousProject.Name = "PreviousProject"
        Me.PreviousProject.Size = New System.Drawing.Size(75, 25)
        Me.PreviousProject.TabIndex = 4
        Me.PreviousProject.Text = "Project"
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
        'Form2_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UsergprBox)
        Me.Controls.Add(Me.PreviousProject)
        Me.Controls.Add(Me.NewProject)
        Me.Controls.Add(Me.LogoutManager)
        Me.Name = "Form2_1"
        Me.Text = "Manager Home Page"
        Me.UsergprBox.ResumeLayout(False)
        Me.UsergprBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoutManager As Button
    Friend WithEvents NewProject As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PreviousProject As Label
    Friend WithEvents ManagerId As Label
    Friend WithEvents ManagerName As Label
    Friend WithEvents UsergprBox As GroupBox
End Class
