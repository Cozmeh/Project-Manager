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
        ProjectName = New TextBox()
        DeadlineDuration = New DateTimePicker()
        Lable1 = New Label()
        ProjectGrpBox = New GroupBox()
        PeopleCount = New NumericUpDown()
        Label2 = New Label()
        Label1 = New Label()
        Create = New Button()
        Cancel = New Button()
        ProjectGrpBox.SuspendLayout()
        CType(PeopleCount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProjectName
        ' 
        ProjectName.BorderStyle = BorderStyle.FixedSingle
        ProjectName.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectName.Location = New Point(68, 53)
        ProjectName.Name = "ProjectName"
        ProjectName.PlaceholderText = "Enter Project Title"
        ProjectName.Size = New Size(244, 34)
        ProjectName.TabIndex = 1
        ' 
        ' DeadlineDuration
        ' 
        DeadlineDuration.CalendarFont = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        DeadlineDuration.Cursor = Cursors.Hand
        DeadlineDuration.CustomFormat = "dd-mm-yyyy"
        DeadlineDuration.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DeadlineDuration.ImeMode = ImeMode.NoControl
        DeadlineDuration.Location = New Point(25, 60)
        DeadlineDuration.MinDate = New DateTime(2023, 1, 23, 0, 0, 0, 0)
        DeadlineDuration.Name = "DeadlineDuration"
        DeadlineDuration.Size = New Size(195, 25)
        DeadlineDuration.TabIndex = 2
        DeadlineDuration.Value = New DateTime(2023, 1, 23, 0, 0, 0, 0)
        ' 
        ' Lable1
        ' 
        Lable1.AutoSize = True
        Lable1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Lable1.Location = New Point(68, 33)
        Lable1.Name = "Lable1"
        Lable1.Size = New Size(79, 17)
        Lable1.TabIndex = 3
        Lable1.Text = "Project Title"' 
        ' ProjectGrpBox
        ' 
        ProjectGrpBox.Controls.Add(PeopleCount)
        ProjectGrpBox.Controls.Add(DeadlineDuration)
        ProjectGrpBox.Controls.Add(Label2)
        ProjectGrpBox.Controls.Add(Label1)
        ProjectGrpBox.Location = New Point(68, 119)
        ProjectGrpBox.Name = "ProjectGrpBox"
        ProjectGrpBox.Size = New Size(244, 187)
        ProjectGrpBox.TabIndex = 4
        ProjectGrpBox.TabStop = False
        ProjectGrpBox.Text = "Project Id:"' 
        ' PeopleCount
        ' 
        PeopleCount.BorderStyle = BorderStyle.FixedSingle
        PeopleCount.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        PeopleCount.Location = New Point(25, 136)
        PeopleCount.Minimum = New [Decimal](New Integer() {2, 0, 0, 0})
        PeopleCount.Name = "PeopleCount"
        PeopleCount.Size = New Size(195, 25)
        PeopleCount.TabIndex = 4
        PeopleCount.Value = New [Decimal](New Integer() {2, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(25, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 17)
        Label2.TabIndex = 3
        Label2.Text = "No of People"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(25, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 17)
        Label1.TabIndex = 3
        Label1.Text = "Project Deadline"' 
        ' Create
        ' 
        Create.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Create.Location = New Point(211, 349)
        Create.Name = "Create"
        Create.Size = New Size(101, 43)
        Create.TabIndex = 5
        Create.Text = "Create"
        Create.UseVisualStyleBackColor = True
        ' 
        ' Cancel
        ' 
        Cancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.Location = New Point(68, 349)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(101, 43)
        Cancel.TabIndex = 5
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' NewProjectWizard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        CancelButton = Cancel
        ClientSize = New Size(375, 415)
        Controls.Add(Cancel)
        Controls.Add(Create)
        Controls.Add(ProjectGrpBox)
        Controls.Add(Lable1)
        Controls.Add(ProjectName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewProjectWizard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New-Project wizard"
        ProjectGrpBox.ResumeLayout(False)
        ProjectGrpBox.PerformLayout()
        CType(PeopleCount, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
