<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProjectId = New System.Windows.Forms.Label()
        Me.ProjectName = New System.Windows.Forms.Label()
        Me.Count = New System.Windows.Forms.Label()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Deadline = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(77, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(43, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(36, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "People:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(18, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Deadline:"
        '
        'ProjectId
        '
        Me.ProjectId.AutoSize = True
        Me.ProjectId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectId.Location = New System.Drawing.Point(115, 27)
        Me.ProjectId.Name = "ProjectId"
        Me.ProjectId.Size = New System.Drawing.Size(92, 25)
        Me.ProjectId.TabIndex = 4
        Me.ProjectId.Text = "Project Id"
        '
        'ProjectName
        '
        Me.ProjectName.AutoSize = True
        Me.ProjectName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectName.Location = New System.Drawing.Point(115, 58)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(126, 25)
        Me.ProjectName.TabIndex = 5
        Me.ProjectName.Text = "Project Name"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Count.Location = New System.Drawing.Point(115, 89)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(22, 25)
        Me.Count.TabIndex = 6
        Me.Count.Text = "2"
        '
        'Apply
        '
        Me.Apply.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Apply.Location = New System.Drawing.Point(673, 383)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(88, 36)
        Me.Apply.TabIndex = 7
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(485, 383)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(88, 36)
        Me.Delete.TabIndex = 8
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cancel.Location = New System.Drawing.Point(579, 383)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(88, 36)
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Deadline
        '
        Me.Deadline.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Deadline.Enabled = False
        Me.Deadline.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Deadline.Location = New System.Drawing.Point(115, 117)
        Me.Deadline.Name = "Deadline"
        Me.Deadline.Size = New System.Drawing.Size(200, 32)
        Me.Deadline.TabIndex = 10
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Deadline)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.ProjectName)
        Me.Controls.Add(Me.ProjectId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProjectId As Label
    Friend WithEvents ProjectName As Label
    Friend WithEvents Count As Label
    Friend WithEvents Apply As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Deadline As DateTimePicker
End Class
