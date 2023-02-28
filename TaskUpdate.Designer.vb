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
        Cancel = New Button()
        Update = New Button()
        Lable1 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Pid = New Label()
        title = New Label()
        task = New Label()
        taskId = New Label()
        Label5 = New Label()
        Completed = New CheckBox()
        SuspendLayout()
        ' 
        ' Cancel
        ' 
        Cancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.Location = New Point(61, 145)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(101, 43)
        Cancel.TabIndex = 9
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' Update
        ' 
        Update.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Update.Location = New Point(203, 145)
        Update.Name = "Update"
        Update.Size = New Size(101, 43)
        Update.TabIndex = 10
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = True
        ' 
        ' Lable1
        ' 
        Lable1.AutoSize = True
        Lable1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Lable1.Location = New Point(39, 40)
        Lable1.Name = "Lable1"
        Lable1.Size = New Size(74, 19)
        Lable1.TabIndex = 7
        Lable1.Text = "Project Id :"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(26, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 19)
        Label1.TabIndex = 11
        Label1.Text = "Project Title :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(68, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 19)
        Label2.TabIndex = 12
        Label2.Text = "Task  :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(59, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 19)
        Label3.TabIndex = 13
        Label3.Text = "Status :"' 
        ' Pid
        ' 
        Pid.AllowDrop = True
        Pid.AutoSize = True
        Pid.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Pid.Location = New Point(136, 40)
        Pid.Name = "Pid"
        Pid.Size = New Size(23, 19)
        Pid.TabIndex = 14
        Pid.Text = "ID"' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        title.Location = New Point(136, 63)
        title.Name = "title"
        title.Size = New Size(32, 19)
        title.TabIndex = 15
        title.Text = "title"' 
        ' task
        ' 
        task.AutoSize = True
        task.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        task.Location = New Point(136, 85)
        task.Name = "task"
        task.Size = New Size(34, 19)
        task.TabIndex = 16
        task.Text = "task"' 
        ' taskId
        ' 
        taskId.AllowDrop = True
        taskId.AutoSize = True
        taskId.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        taskId.Location = New Point(136, 17)
        taskId.Name = "taskId"
        taskId.Size = New Size(23, 19)
        taskId.TabIndex = 18
        taskId.Text = "ID"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(56, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 19)
        Label5.TabIndex = 17
        Label5.Text = "Task Id :"' 
        ' Completed
        ' 
        Completed.AutoSize = True
        Completed.Location = New Point(119, 109)
        Completed.Name = "Completed"
        Completed.Size = New Size(85, 19)
        Completed.TabIndex = 19
        Completed.Text = "Completed"
        Completed.UseVisualStyleBackColor = True
        ' 
        ' TaskUpdate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 200)
        Controls.Add(Completed)
        Controls.Add(taskId)
        Controls.Add(Label5)
        Controls.Add(task)
        Controls.Add(title)
        Controls.Add(Pid)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cancel)
        Controls.Add(Update)
        Controls.Add(Lable1)
        Name = "TaskUpdate"
        Text = "TaskUpdate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents Update As Button
    Friend WithEvents Lable1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Pid As Label
    Friend WithEvents title As Label
    Friend WithEvents task As Label
    Friend WithEvents taskId As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Completed As CheckBox
End Class
