<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LogoutManager = New System.Windows.Forms.Button()
        Me.NewProject = New System.Windows.Forms.Button()
        Me.IdManager = New System.Windows.Forms.Label()
        Me.NameManager = New System.Windows.Forms.Label()
        Me.PreviousProject = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogoutManager
        '
        Me.LogoutManager.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutManager.Location = New System.Drawing.Point(677, 51)
        Me.LogoutManager.Name = "LogoutManager"
        Me.LogoutManager.Size = New System.Drawing.Size(95, 33)
        Me.LogoutManager.TabIndex = 0
        Me.LogoutManager.Text = "Logout"
        Me.LogoutManager.UseVisualStyleBackColor = True
        '
        'NewProject
        '
        Me.NewProject.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewProject.Location = New System.Drawing.Point(677, 405)
        Me.NewProject.Name = "NewProject"
        Me.NewProject.Size = New System.Drawing.Size(95, 33)
        Me.NewProject.TabIndex = 1
        Me.NewProject.Text = "New +"
        Me.NewProject.UseVisualStyleBackColor = True
        '
        'IdManager
        '
        Me.IdManager.AutoSize = True
        Me.IdManager.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IdManager.Location = New System.Drawing.Point(89, 34)
        Me.IdManager.Name = "IdManager"
        Me.IdManager.Size = New System.Drawing.Size(32, 25)
        Me.IdManager.TabIndex = 2
        Me.IdManager.Text = "Id:"
        '
        'NameManager
        '
        Me.NameManager.AutoSize = True
        Me.NameManager.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameManager.Location = New System.Drawing.Point(55, 64)
        Me.NameManager.Name = "NameManager"
        Me.NameManager.Size = New System.Drawing.Size(66, 25)
        Me.NameManager.TabIndex = 3
        Me.NameManager.Text = "Name:"
        '
        'PreviousProject
        '
        Me.PreviousProject.AutoSize = True
        Me.PreviousProject.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PreviousProject.Location = New System.Drawing.Point(12, 111)
        Me.PreviousProject.Name = "PreviousProject"
        Me.PreviousProject.Size = New System.Drawing.Size(152, 25)
        Me.PreviousProject.TabIndex = 4
        Me.PreviousProject.Text = "Previous Project:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PreviousProject)
        Me.Controls.Add(Me.NameManager)
        Me.Controls.Add(Me.IdManager)
        Me.Controls.Add(Me.NewProject)
        Me.Controls.Add(Me.LogoutManager)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoutManager As Button
    Friend WithEvents NewProject As Button
    Friend WithEvents IdManager As Label
    Friend WithEvents NameManager As Label
    Friend WithEvents PreviousProject As Label
End Class
