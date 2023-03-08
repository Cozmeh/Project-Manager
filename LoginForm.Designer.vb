<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.empimg = New System.Windows.Forms.PictureBox()
        Me.UserIDBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.empimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.loginbtn.FlatAppearance.BorderSize = 0
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.loginbtn.ForeColor = System.Drawing.Color.Black
        Me.loginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.loginbtn.Location = New System.Drawing.Point(179, 257)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(162, 44)
        Me.loginbtn.TabIndex = 0
        Me.loginbtn.Text = "LOGIN"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'empimg
        '
        Me.empimg.Image = Global.ProjectManager.My.Resources.Resources.users
        Me.empimg.Location = New System.Drawing.Point(179, 3)
        Me.empimg.Name = "empimg"
        Me.empimg.Size = New System.Drawing.Size(162, 124)
        Me.empimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.empimg.TabIndex = 1
        Me.empimg.TabStop = False
        '
        'UserIDBox
        '
        Me.UserIDBox.AutoCompleteCustomSource.AddRange(New String() {"admin"})
        Me.UserIDBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserIDBox.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserIDBox.Location = New System.Drawing.Point(157, 143)
        Me.UserIDBox.Name = "UserIDBox"
        Me.UserIDBox.PlaceholderText = "User Id"
        Me.UserIDBox.Size = New System.Drawing.Size(223, 34)
        Me.UserIDBox.TabIndex = 2
        '
        'PassBox
        '
        Me.PassBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PassBox.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PassBox.Location = New System.Drawing.Point(157, 194)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PlaceholderText = "Password"
        Me.PassBox.Size = New System.Drawing.Size(223, 34)
        Me.PassBox.TabIndex = 3
        Me.PassBox.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.ProjectManager.My.Resources.Resources.userID
        Me.PictureBox1.Location = New System.Drawing.Point(119, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.ProjectManager.My.Resources.Resources.Password1
        Me.PictureBox2.Location = New System.Drawing.Point(119, 194)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 314)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserIDBox)
        Me.Controls.Add(Me.empimg)
        Me.Controls.Add(Me.loginbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Manager"
        CType(Me.empimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents empimg As PictureBox
    Friend WithEvents UserIDBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
