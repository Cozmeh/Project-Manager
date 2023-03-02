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
        Completed = New CheckBox()
        taskId = New Label()
        Label5 = New Label()
        Taskname = New Label()
        title = New Label()
        Pid = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Cancel = New Button()
        Update = New Button()
        Lable1 = New Label()
        GroupBox1 = New GroupBox()
        comments = New Label()
        Comment = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Completed
        ' 
        Completed.AutoSize = True
        Completed.Location = New Point(105, 128)
        Completed.Name = "Completed"
        Completed.Size = New Size(85, 19)
        Completed.TabIndex = 31
        Completed.Text = "Completed"
        Completed.UseVisualStyleBackColor = True
        ' 
        ' taskId
        ' 
        taskId.AllowDrop = True
        taskId.AutoSize = True
        taskId.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        taskId.Location = New Point(122, 31)
        taskId.Name = "taskId"
        taskId.Size = New Size(23, 19)
        taskId.TabIndex = 30
        taskId.Text = "ID" ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(42, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 19)
        Label5.TabIndex = 29
        Label5.Text = "Task Id :" ' 
        ' Taskname
        ' 
        Taskname.AutoSize = True
        Taskname.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Taskname.Location = New Point(122, 103)
        Taskname.Name = "Taskname"
        Taskname.Size = New Size(34, 19)
        Taskname.TabIndex = 28
        Taskname.Text = "task" ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        title.Location = New Point(122, 79)
        title.Name = "title"
        title.Size = New Size(32, 19)
        title.TabIndex = 27
        title.Text = "title" ' 
        ' Pid
        ' 
        Pid.AllowDrop = True
        Pid.AutoSize = True
        Pid.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Pid.Location = New Point(122, 55)
        Pid.Name = "Pid"
        Pid.Size = New Size(23, 19)
        Pid.TabIndex = 26
        Pid.Text = "ID" ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(45, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 19)
        Label3.TabIndex = 25
        Label3.Text = "Status :" ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(54, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 19)
        Label2.TabIndex = 24
        Label2.Text = "Task  :" ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 19)
        Label4.TabIndex = 23
        Label4.Text = "Project Title :" ' 
        ' Cancel
        ' 
        Cancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.Location = New Point(73, 177)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(101, 43)
        Cancel.TabIndex = 21
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' Update
        ' 
        Update.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Update.Location = New Point(217, 177)
        Update.Name = "Update"
        Update.Size = New Size(101, 43)
        Update.TabIndex = 22
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = True
        ' 
        ' Lable1
        ' 
        Lable1.AutoSize = True
        Lable1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lable1.Location = New Point(25, 55)
        Lable1.Name = "Lable1"
        Lable1.Size = New Size(74, 19)
        Lable1.TabIndex = 20
        Lable1.Text = "Project Id :" ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(comments)
        GroupBox1.Controls.Add(Comment)
        GroupBox1.Location = New Point(205, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(183, 141)
        GroupBox1.TabIndex = 32
        GroupBox1.TabStop = False
        GroupBox1.Text = "Comment for task:" ' 
        ' comments
        ' 
        comments.Location = New Point(12, 24)
        comments.Name = "comments"
        comments.Size = New Size(164, 105)
        comments.TabIndex = 1
        comments.Text = "someting"
        comments.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Comment
        ' 
        Comment.AutoSize = True
        Comment.Location = New Point(12, 24)
        Comment.Name = "Comment"
        Comment.Size = New Size(0, 15)
        Comment.TabIndex = 0
        ' 
        ' TaskUpdate
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(406, 236)
        Controls.Add(GroupBox1)
        Controls.Add(Completed)
        Controls.Add(taskId)
        Controls.Add(Label5)
        Controls.Add(Taskname)
        Controls.Add(title)
        Controls.Add(Pid)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Cancel)
        Controls.Add(Update)
        Controls.Add(Lable1)
        Name = "TaskUpdate"
        Text = "Task"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
