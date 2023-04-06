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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(EditProjectDetails))
        ProjectId = New GroupBox()
        PeopleCount = New NumericUpDown()
        DeadlineDuration = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        Lable1 = New Label()
        ProjectName = New TextBox()
        Apply = New Button()
        Delete = New Button()
        Cancel = New Button()
        ProjectId.SuspendLayout()
        CType(PeopleCount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProjectId
        ' 
        ProjectId.Controls.Add(PeopleCount)
        ProjectId.Controls.Add(DeadlineDuration)
        ProjectId.Controls.Add(Label2)
        ProjectId.Controls.Add(Label1)
        ProjectId.Location = New Point(68, 119)
        ProjectId.Name = "ProjectId"
        ProjectId.Size = New Size(244, 187)
        ProjectId.TabIndex = 15
        ProjectId.TabStop = False
        ProjectId.Text = "Project Id:"
        ' 
        ' PeopleCount
        ' 
        PeopleCount.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        PeopleCount.Location = New Point(25, 136)
        PeopleCount.Minimum = New [Decimal](New Integer() {2, 0, 0, 0})
        PeopleCount.Name = "PeopleCount"
        PeopleCount.Size = New Size(195, 25)
        PeopleCount.TabIndex = 4
        PeopleCount.Value = New [Decimal](New Integer() {2, 0, 0, 0})
        ' 
        ' DeadlineDuration
        ' 
        DeadlineDuration.CalendarFont = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        DeadlineDuration.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DeadlineDuration.Location = New Point(25, 60)
        DeadlineDuration.MinDate = New DateTime(2023, 1, 23, 0, 0, 0, 0)
        DeadlineDuration.Name = "DeadlineDuration"
        DeadlineDuration.Size = New Size(195, 25)
        DeadlineDuration.TabIndex = 2
        DeadlineDuration.Value = New DateTime(2023, 1, 23, 0, 0, 0, 0)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(25, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 17)
        Label2.TabIndex = 3
        Label2.Text = "No of People"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(25, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 17)
        Label1.TabIndex = 3
        Label1.Text = "Project Deadline"
        ' 
        ' Lable1
        ' 
        Lable1.AutoSize = True
        Lable1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Lable1.Location = New Point(68, 33)
        Lable1.Name = "Lable1"
        Lable1.Size = New Size(79, 17)
        Lable1.TabIndex = 14
        Lable1.Text = "Project Title"
        ' 
        ' ProjectName
        ' 
        ProjectName.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectName.Location = New Point(68, 53)
        ProjectName.Name = "ProjectName"
        ProjectName.PlaceholderText = "Enter Project Title"
        ProjectName.Size = New Size(244, 34)
        ProjectName.TabIndex = 13
        ' 
        ' Apply
        ' 
        Apply.BackColor = Color.Silver
        Apply.FlatAppearance.BorderSize = 0
        Apply.FlatStyle = FlatStyle.Flat
        Apply.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Apply.Location = New Point(50, 346)
        Apply.Name = "Apply"
        Apply.Size = New Size(88, 36)
        Apply.TabIndex = 16
        Apply.Text = "Apply"
        Apply.UseVisualStyleBackColor = False
        ' 
        ' Delete
        ' 
        Delete.BackColor = Color.Silver
        Delete.Enabled = False
        Delete.FlatAppearance.BorderSize = 0
        Delete.FlatStyle = FlatStyle.Flat
        Delete.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Delete.Location = New Point(148, 346)
        Delete.Name = "Delete"
        Delete.Size = New Size(88, 36)
        Delete.TabIndex = 17
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = Color.Silver
        Cancel.FlatAppearance.BorderSize = 0
        Cancel.FlatStyle = FlatStyle.Flat
        Cancel.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.Location = New Point(242, 346)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(88, 36)
        Cancel.TabIndex = 18
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' EditProjectDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 415)
        Controls.Add(Apply)
        Controls.Add(Delete)
        Controls.Add(Cancel)
        Controls.Add(ProjectId)
        Controls.Add(Lable1)
        Controls.Add(ProjectName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditProjectDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditProjectDetails"
        ProjectId.ResumeLayout(False)
        ProjectId.PerformLayout()
        CType(PeopleCount, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
