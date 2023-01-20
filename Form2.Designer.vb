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
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NewProject)
        Me.Controls.Add(Me.LogoutManager)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoutManager As Button
    Friend WithEvents NewProject As Button
End Class
