<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskUpdate))
        Me.Completed = New System.Windows.Forms.CheckBox()
        Me.taskId = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Taskname = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.Pid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comments = New System.Windows.Forms.Label()
        Me.Comment = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Completed
        '
        Me.Completed.AutoSize = True
        Me.Completed.Location = New System.Drawing.Point(105, 128)
        Me.Completed.Name = "Completed"
        Me.Completed.Size = New System.Drawing.Size(85, 19)
        Me.Completed.TabIndex = 31
        Me.Completed.Text = "Completed"
        Me.Completed.UseVisualStyleBackColor = True
        '
        'taskId
        '
        Me.taskId.AllowDrop = True
        Me.taskId.AutoSize = True
        Me.taskId.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.taskId.Location = New System.Drawing.Point(122, 31)
        Me.taskId.Name = "taskId"
        Me.taskId.Size = New System.Drawing.Size(23, 19)
        Me.taskId.TabIndex = 30
        Me.taskId.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(42, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Task Id :"
        '
        'Taskname
        '
        Me.Taskname.AutoSize = True
        Me.Taskname.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Taskname.Location = New System.Drawing.Point(122, 103)
        Me.Taskname.Name = "Taskname"
        Me.Taskname.Size = New System.Drawing.Size(34, 19)
        Me.Taskname.TabIndex = 28
        Me.Taskname.Text = "task"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(122, 79)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(32, 19)
        Me.title.TabIndex = 27
        Me.title.Text = "title"
        '
        'Pid
        '
        Me.Pid.AllowDrop = True
        Me.Pid.AutoSize = True
        Me.Pid.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Pid.Location = New System.Drawing.Point(122, 55)
        Me.Pid.Name = "Pid"
        Me.Pid.Size = New System.Drawing.Size(23, 19)
        Me.Pid.TabIndex = 26
        Me.Pid.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(45, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Status :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(54, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Task  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Project Title :"
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Silver
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cancel.Location = New System.Drawing.Point(89, 177)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(101, 43)
        Me.Cancel.TabIndex = 21
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Update
        '
        Me.Update.BackColor = System.Drawing.Color.Silver
        Me.Update.FlatAppearance.BorderSize = 0
        Me.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Update.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Update.Location = New System.Drawing.Point(232, 177)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(101, 43)
        Me.Update.TabIndex = 22
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = False
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lable1.Location = New System.Drawing.Point(25, 55)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(74, 19)
        Me.Lable1.TabIndex = 20
        Me.Lable1.Text = "Project Id :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comments)
        Me.GroupBox1.Controls.Add(Me.Comment)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 141)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comment for task"
        '
        'comments
        '
        Me.comments.Location = New System.Drawing.Point(10, 24)
        Me.comments.Name = "comments"
        Me.comments.Size = New System.Drawing.Size(136, 105)
        Me.comments.TabIndex = 1
        Me.comments.Text = "someting"
        Me.comments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Comment
        '
        Me.Comment.AutoSize = True
        Me.Comment.Location = New System.Drawing.Point(12, 24)
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(0, 15)
        Me.Comment.TabIndex = 0
        '
        'TaskUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 236)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Completed)
        Me.Controls.Add(Me.taskId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Taskname)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Pid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Lable1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TaskUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Task"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Completed As CheckBox
    Friend WithEvents taskId As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Taskname As Label
    Friend WithEvents title As Label
    Friend WithEvents Pid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents Update As Button
    Friend WithEvents Lable1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Comment As Label
    Friend WithEvents comments As Label
End Class
