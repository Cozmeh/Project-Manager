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
        Me.Id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddProject = New System.Windows.Forms.Button()
        Me.PreviousProjectBox = New System.Windows.Forms.GroupBox()
        Me.LogoutManager = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Id.Location = New System.Drawing.Point(64, 41)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(32, 25)
        Me.Id.TabIndex = 0
        Me.Id.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'AddProject
        '
        Me.AddProject.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddProject.Location = New System.Drawing.Point(667, 402)
        Me.AddProject.Name = "AddProject"
        Me.AddProject.Size = New System.Drawing.Size(90, 36)
        Me.AddProject.TabIndex = 3
        Me.AddProject.Text = "New +"
        Me.AddProject.UseVisualStyleBackColor = True
        '
        'PreviousProjectBox
        '
        Me.PreviousProjectBox.Location = New System.Drawing.Point(30, 138)
        Me.PreviousProjectBox.Name = "PreviousProjectBox"
        Me.PreviousProjectBox.Size = New System.Drawing.Size(740, 258)
        Me.PreviousProjectBox.TabIndex = 4
        Me.PreviousProjectBox.TabStop = False
        Me.PreviousProjectBox.Text = "Previous Projects:"
        '
        'LogoutManager
        '
        Me.LogoutManager.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutManager.Location = New System.Drawing.Point(667, 52)
        Me.LogoutManager.Name = "LogoutManager"
        Me.LogoutManager.Size = New System.Drawing.Size(90, 36)
        Me.LogoutManager.TabIndex = 5
        Me.LogoutManager.Text = "Logout"
        Me.LogoutManager.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PreviousProjectBox)
        Me.Controls.Add(Me.LogoutManager)
        Me.Controls.Add(Me.AddProject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Id)
        Me.Name = "Form2"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddProject As Button
    Friend WithEvents PreviousProjectBox As GroupBox
    Friend WithEvents LogoutManager As Button
End Class
