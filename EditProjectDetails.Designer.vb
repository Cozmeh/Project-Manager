<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProjectDetails
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
        Me.ProjectId = New System.Windows.Forms.GroupBox()
        Me.PeopleCount = New System.Windows.Forms.NumericUpDown()
        Me.DeadlineDuration = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.ProjectName = New System.Windows.Forms.TextBox()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ProjectId.SuspendLayout()
        CType(Me.PeopleCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectId
        '
        Me.ProjectId.Controls.Add(Me.PeopleCount)
        Me.ProjectId.Controls.Add(Me.DeadlineDuration)
        Me.ProjectId.Controls.Add(Me.Label2)
        Me.ProjectId.Controls.Add(Me.Label1)
        Me.ProjectId.Location = New System.Drawing.Point(68, 119)
        Me.ProjectId.Name = "ProjectId"
        Me.ProjectId.Size = New System.Drawing.Size(244, 187)
        Me.ProjectId.TabIndex = 15
        Me.ProjectId.TabStop = False
        Me.ProjectId.Text = "Project Id:"
        '
        'PeopleCount
        '
        Me.PeopleCount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PeopleCount.Location = New System.Drawing.Point(25, 136)
        Me.PeopleCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.PeopleCount.Name = "PeopleCount"
        Me.PeopleCount.Size = New System.Drawing.Size(195, 25)
        Me.PeopleCount.TabIndex = 4
        Me.PeopleCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'DeadlineDuration
        '
        Me.DeadlineDuration.CalendarFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeadlineDuration.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeadlineDuration.Location = New System.Drawing.Point(25, 60)
        Me.DeadlineDuration.MinDate = New Date(2023, 1, 23, 0, 0, 0, 0)
        Me.DeadlineDuration.Name = "DeadlineDuration"
        Me.DeadlineDuration.Size = New System.Drawing.Size(195, 25)
        Me.DeadlineDuration.TabIndex = 2
        Me.DeadlineDuration.Value = New Date(2023, 1, 23, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(25, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No of People"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Project Deadline"
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lable1.Location = New System.Drawing.Point(68, 33)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(79, 17)
        Me.Lable1.TabIndex = 14
        Me.Lable1.Text = "Project Title"
        '
        'ProjectName
        '
        Me.ProjectName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectName.Location = New System.Drawing.Point(68, 53)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.PlaceholderText = "Enter Project Title"
        Me.ProjectName.Size = New System.Drawing.Size(244, 34)
        Me.ProjectName.TabIndex = 13
        '
        'Apply
        '
        Me.Apply.BackColor = System.Drawing.Color.Silver
        Me.Apply.FlatAppearance.BorderSize = 0
        Me.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Apply.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Apply.Location = New System.Drawing.Point(50, 346)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(88, 36)
        Me.Apply.TabIndex = 16
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Silver
        Me.Delete.Enabled = False
        Me.Delete.FlatAppearance.BorderSize = 0
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(148, 346)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(88, 36)
        Me.Delete.TabIndex = 17
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Silver
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cancel.Location = New System.Drawing.Point(242, 346)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(88, 36)
        Me.Cancel.TabIndex = 18
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'EditProjectDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 415)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.ProjectId)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.ProjectName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditProjectDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditProjectDetails"
        Me.ProjectId.ResumeLayout(False)
        Me.ProjectId.PerformLayout()
        CType(Me.PeopleCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectId As GroupBox
    Friend WithEvents PeopleCount As NumericUpDown
    Friend WithEvents DeadlineDuration As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lable1 As Label
    Friend WithEvents ProjectName As TextBox
    Friend WithEvents Apply As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Cancel As Button
End Class
