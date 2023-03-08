<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProjectWizard
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
        Me.ProjectName = New System.Windows.Forms.TextBox()
        Me.DeadlineDuration = New System.Windows.Forms.DateTimePicker()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.ProjectGrpBox = New System.Windows.Forms.GroupBox()
        Me.PeopleCount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Create = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ProjectGrpBox.SuspendLayout()
        CType(Me.PeopleCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectName
        '
        Me.ProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectName.Location = New System.Drawing.Point(68, 53)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.PlaceholderText = "Enter Project Title"
        Me.ProjectName.Size = New System.Drawing.Size(244, 34)
        Me.ProjectName.TabIndex = 1
        '
        'DeadlineDuration
        '
        Me.DeadlineDuration.CalendarFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeadlineDuration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeadlineDuration.CustomFormat = "dd-MM-yyyy"
        Me.DeadlineDuration.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeadlineDuration.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DeadlineDuration.Location = New System.Drawing.Point(25, 60)
        Me.DeadlineDuration.MinDate = New Date(2023, 1, 23, 0, 0, 0, 0)
        Me.DeadlineDuration.Name = "DeadlineDuration"
        Me.DeadlineDuration.Size = New System.Drawing.Size(195, 25)
        Me.DeadlineDuration.TabIndex = 2
        Me.DeadlineDuration.Value = New Date(2023, 1, 23, 0, 0, 0, 0)
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lable1.Location = New System.Drawing.Point(68, 33)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(79, 17)
        Me.Lable1.TabIndex = 3
        Me.Lable1.Text = "Project Title"
        '
        'ProjectGrpBox
        '
        Me.ProjectGrpBox.Controls.Add(Me.PeopleCount)
        Me.ProjectGrpBox.Controls.Add(Me.DeadlineDuration)
        Me.ProjectGrpBox.Controls.Add(Me.Label2)
        Me.ProjectGrpBox.Controls.Add(Me.Label1)
        Me.ProjectGrpBox.Location = New System.Drawing.Point(68, 119)
        Me.ProjectGrpBox.Name = "ProjectGrpBox"
        Me.ProjectGrpBox.Size = New System.Drawing.Size(244, 187)
        Me.ProjectGrpBox.TabIndex = 4
        Me.ProjectGrpBox.TabStop = False
        Me.ProjectGrpBox.Text = "Project Id:"
        '
        'PeopleCount
        '
        Me.PeopleCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PeopleCount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PeopleCount.Location = New System.Drawing.Point(25, 136)
        Me.PeopleCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.PeopleCount.Name = "PeopleCount"
        Me.PeopleCount.Size = New System.Drawing.Size(195, 25)
        Me.PeopleCount.TabIndex = 4
        Me.PeopleCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
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
        'Create
        '
        Me.Create.BackColor = System.Drawing.Color.Silver
        Me.Create.FlatAppearance.BorderSize = 0
        Me.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Create.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Create.Location = New System.Drawing.Point(211, 349)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(101, 43)
        Me.Create.TabIndex = 5
        Me.Create.Text = "Create"
        Me.Create.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Silver
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cancel.Location = New System.Drawing.Point(68, 349)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(101, 43)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'NewProjectWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(375, 415)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Create)
        Me.Controls.Add(Me.ProjectGrpBox)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.ProjectName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewProjectWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New-Project wizard"
        Me.ProjectGrpBox.ResumeLayout(False)
        Me.ProjectGrpBox.PerformLayout()
        CType(Me.PeopleCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectName As TextBox
    Friend WithEvents DeadlineDuration As DateTimePicker
    Friend WithEvents Lable1 As Label
    Friend WithEvents ProjectGrpBox As GroupBox
    Friend WithEvents PeopleCount As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Create As Button
    Friend WithEvents Cancel As Button
End Class
