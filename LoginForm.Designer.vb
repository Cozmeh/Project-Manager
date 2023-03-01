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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm))
        loginbtn = New Button()
        empimg = New PictureBox()
        UserIDBox = New TextBox()
        PassBox = New TextBox()
        CType(empimg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' loginbtn
        ' 
        loginbtn.BackColor = Color.CornflowerBlue
        loginbtn.FlatAppearance.BorderSize = 0
        loginbtn.FlatStyle = FlatStyle.Flat
        loginbtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        loginbtn.ForeColor = Color.Black
        loginbtn.Location = New Point(179, 257)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(162, 44)
        loginbtn.TabIndex = 0
        loginbtn.Text = "LOGIN"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' empimg
        ' 
        empimg.Image = My.Resources.Resources.users
        empimg.Location = New Point(179, 3)
        empimg.Name = "empimg"
        empimg.Size = New Size(162, 124)
        empimg.SizeMode = PictureBoxSizeMode.Zoom
        empimg.TabIndex = 1
        empimg.TabStop = False
        ' 
        ' UserIDBox
        ' 
        UserIDBox.AutoCompleteCustomSource.AddRange(New String() {"admin"})
        UserIDBox.Cursor = Cursors.IBeam
        UserIDBox.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        UserIDBox.Location = New Point(126, 142)
        UserIDBox.Name = "UserIDBox"
        UserIDBox.PlaceholderText = "User Id"
        UserIDBox.Size = New Size(282, 32)
        UserIDBox.TabIndex = 2
        ' 
        ' PassBox
        ' 
        PassBox.Cursor = Cursors.IBeam
        PassBox.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        PassBox.Location = New Point(126, 193)
        PassBox.Name = "PassBox"
        PassBox.PlaceholderText = "Password"
        PassBox.Size = New Size(282, 32)
        PassBox.TabIndex = 3
        PassBox.UseSystemPasswordChar = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(529, 314)
        Controls.Add(PassBox)
        Controls.Add(UserIDBox)
        Controls.Add(empimg)
        Controls.Add(loginbtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Project Manager"
        CType(empimg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents empimg As PictureBox
    Friend WithEvents UserIDBox As TextBox
    Friend WithEvents PassBox As TextBox
End Class
