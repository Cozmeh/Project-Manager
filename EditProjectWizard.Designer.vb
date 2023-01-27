<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProjectWizard
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
        Me.Deadline = New System.Windows.Forms.DateTimePicker()
        Me.ProjectDetails = New System.Windows.Forms.GroupBox()
        Me.Layout = New System.Windows.Forms.GroupBox()
        Me.Ok = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.ProjectDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name      :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(8, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "People     :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(8, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Deadline :"
        '
        'ProjectId
        '
        Me.ProjectId.AutoSize = True
        Me.ProjectId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectId.Location = New System.Drawing.Point(110, 20)
        Me.ProjectId.Name = "ProjectId"
        Me.ProjectId.Size = New System.Drawing.Size(92, 25)
        Me.ProjectId.TabIndex = 4
        Me.ProjectId.Text = "Project Id"
        '
        'ProjectName
        '
        Me.ProjectName.AutoSize = True
        Me.ProjectName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectName.Location = New System.Drawing.Point(110, 51)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(126, 25)
        Me.ProjectName.TabIndex = 5
        Me.ProjectName.Text = "Project Name"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Count.Location = New System.Drawing.Point(110, 82)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(22, 25)
        Me.Count.TabIndex = 6
        Me.Count.Text = "2"
        '
        'Deadline
        '
        Me.Deadline.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Deadline.Enabled = False
        Me.Deadline.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Deadline.Location = New System.Drawing.Point(110, 110)
        Me.Deadline.Name = "Deadline"
        Me.Deadline.Size = New System.Drawing.Size(200, 32)
        Me.Deadline.TabIndex = 10
        '
        'ProjectDetails
        '
        Me.ProjectDetails.Controls.Add(Me.Count)
        Me.ProjectDetails.Controls.Add(Me.Label1)
        Me.ProjectDetails.Controls.Add(Me.Deadline)
        Me.ProjectDetails.Controls.Add(Me.Label2)
        Me.ProjectDetails.Controls.Add(Me.Label3)
        Me.ProjectDetails.Controls.Add(Me.Label4)
        Me.ProjectDetails.Controls.Add(Me.ProjectId)
        Me.ProjectDetails.Controls.Add(Me.ProjectName)
        Me.ProjectDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectDetails.Location = New System.Drawing.Point(12, 12)
        Me.ProjectDetails.Name = "ProjectDetails"
        Me.ProjectDetails.Size = New System.Drawing.Size(332, 161)
        Me.ProjectDetails.TabIndex = 11
        Me.ProjectDetails.TabStop = False
        Me.ProjectDetails.Text = "Project Details"
        '
        'Layout
        '
        Me.Layout.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Layout.Location = New System.Drawing.Point(12, 179)
        Me.Layout.Name = "Layout"
        Me.Layout.Size = New System.Drawing.Size(776, 313)
        Me.Layout.TabIndex = 12
        Me.Layout.TabStop = False
        Me.Layout.Text = "Plan Layout"
        '
        'Ok
        '
        Me.Ok.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ok.Location = New System.Drawing.Point(700, 21)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(88, 36)
        Me.Ok.TabIndex = 13
        Me.Ok.Text = "Okay"
        Me.Ok.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(700, 63)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(88, 36)
        Me.Edit.TabIndex = 14
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'EditProjectWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 504)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.Layout)
        Me.Controls.Add(Me.ProjectDetails)
        Me.Name = "EditProjectWizard"
        Me.Text = "EditProjectWizard"
        Me.ProjectDetails.ResumeLayout(False)
        Me.ProjectDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProjectId As Label
    Friend WithEvents ProjectName As Label
    Friend WithEvents Count As Label
    Friend WithEvents Deadline As DateTimePicker
    Friend WithEvents ProjectDetails As GroupBox
    Friend WithEvents Layout As GroupBox
    Friend WithEvents Ok As Button
    Friend WithEvents Edit As Button
End Class
