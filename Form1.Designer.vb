<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.empimg = New System.Windows.Forms.PictureBox()
        Me.UserIDBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        CType(Me.empimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.loginbtn.Location = New System.Drawing.Point(185, 257)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(162, 44)
        Me.loginbtn.TabIndex = 0
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'empimg
        '
        Me.empimg.Image = Global.ProjectManager.My.Resources.Resources.login
        Me.empimg.Location = New System.Drawing.Point(216, 22)
        Me.empimg.Name = "empimg"
        Me.empimg.Size = New System.Drawing.Size(100, 100)
        Me.empimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.empimg.TabIndex = 1
        Me.empimg.TabStop = False
        '
        'UserIDBox
        '
        Me.UserIDBox.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserIDBox.Location = New System.Drawing.Point(138, 142)
        Me.UserIDBox.Name = "UserIDBox"
        Me.UserIDBox.PlaceholderText = "User Id"
        Me.UserIDBox.Size = New System.Drawing.Size(282, 32)
        Me.UserIDBox.TabIndex = 2
        '
        'PassBox
        '
        Me.PassBox.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PassBox.Location = New System.Drawing.Point(138, 193)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PlaceholderText = "Password"
        Me.PassBox.Size = New System.Drawing.Size(282, 32)
        Me.PassBox.TabIndex = 3
        Me.PassBox.UseSystemPasswordChar = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 331)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserIDBox)
        Me.Controls.Add(Me.empimg)
        Me.Controls.Add(Me.loginbtn)
        Me.Name = "Form1"
        Me.Text = "Project Manager"
        CType(Me.empimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents empimg As PictureBox
    Friend WithEvents UserIDBox As TextBox
    Friend WithEvents PassBox As TextBox
End Class
