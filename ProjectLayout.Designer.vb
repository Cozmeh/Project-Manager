<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectLayout
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
        Layout = New GroupBox()
        ProjectDetails = New GroupBox()
        StartDate = New DateTimePicker()
        lable4 = New Label()
        Count = New Label()
        Label1 = New Label()
        Deadline = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ProjectId = New Label()
        ProjectName = New Label()
        Edit = New Button()
        Ok = New Button()
        ProjectDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Layout
        ' 
        Layout.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Layout.Location = New Point(12, 146)
        Layout.Name = "Layout"
        Layout.Size = New Size(776, 346)
        Layout.TabIndex = 14
        Layout.TabStop = False
        Layout.Text = "Plan Layout"' 
        ' ProjectDetails
        ' 
        ProjectDetails.Controls.Add(StartDate)
        ProjectDetails.Controls.Add(lable4)
        ProjectDetails.Controls.Add(Count)
        ProjectDetails.Controls.Add(Label1)
        ProjectDetails.Controls.Add(Deadline)
        ProjectDetails.Controls.Add(Label2)
        ProjectDetails.Controls.Add(Label3)
        ProjectDetails.Controls.Add(Label4)
        ProjectDetails.Controls.Add(ProjectId)
        ProjectDetails.Controls.Add(ProjectName)
        ProjectDetails.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectDetails.Location = New Point(12, 12)
        ProjectDetails.Name = "ProjectDetails"
        ProjectDetails.Size = New Size(611, 116)
        ProjectDetails.TabIndex = 13
        ProjectDetails.TabStop = False
        ProjectDetails.Text = "Project Details"' 
        ' StartDate
        ' 
        StartDate.CalendarFont = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        StartDate.Enabled = False
        StartDate.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        StartDate.Location = New Point(393, 25)
        StartDate.Name = "StartDate"
        StartDate.Size = New Size(200, 32)
        StartDate.TabIndex = 12
        ' 
        ' lable4
        ' 
        lable4.AutoSize = True
        lable4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lable4.Location = New Point(284, 28)
        lable4.Name = "lable4"
        lable4.Size = New Size(103, 25)
        lable4.TabIndex = 11
        lable4.Text = "Start Date :"' 
        ' Count
        ' 
        Count.AutoSize = True
        Count.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Count.Location = New Point(110, 82)
        Count.Name = "Count"
        Count.Size = New Size(22, 25)
        Count.TabIndex = 6
        Count.Text = "2"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(11, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 0
        Label1.Text = "Project Id:"' 
        ' Deadline
        ' 
        Deadline.CalendarFont = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Deadline.Enabled = False
        Deadline.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Deadline.Location = New Point(393, 66)
        Deadline.Name = "Deadline"
        Deadline.Size = New Size(200, 32)
        Deadline.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(11, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 1
        Label2.Text = "Name      :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(8, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 25)
        Label3.TabIndex = 2
        Label3.Text = "People     :"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(291, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 25)
        Label4.TabIndex = 3
        Label4.Text = "Deadline :"' 
        ' ProjectId
        ' 
        ProjectId.AutoSize = True
        ProjectId.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectId.Location = New Point(110, 20)
        ProjectId.Name = "ProjectId"
        ProjectId.Size = New Size(92, 25)
        ProjectId.TabIndex = 4
        ProjectId.Text = "Project Id"' 
        ' ProjectName
        ' 
        ProjectName.AutoSize = True
        ProjectName.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ProjectName.Location = New Point(110, 51)
        ProjectName.Name = "ProjectName"
        ProjectName.Size = New Size(126, 25)
        ProjectName.TabIndex = 5
        ProjectName.Text = "Project Name"' 
        ' Edit
        ' 
        Edit.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Edit.Location = New Point(700, 67)
        Edit.Name = "Edit"
        Edit.Size = New Size(88, 36)
        Edit.TabIndex = 16
        Edit.Text = "Edit"
        Edit.UseVisualStyleBackColor = True
        ' 
        ' Ok
        ' 
        Ok.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Ok.Location = New Point(700, 25)
        Ok.Name = "Ok"
        Ok.Size = New Size(88, 36)
        Ok.TabIndex = 15
        Ok.Text = "Okay"
        Ok.UseVisualStyleBackColor = True
        ' 
        ' ProjectLayout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(803, 504)
        Controls.Add(Edit)
        Controls.Add(Ok)
        Controls.Add(Layout)
        Controls.Add(ProjectDetails)
        Name = "ProjectLayout"
        Text = "ProjectLayout"
        ProjectDetails.ResumeLayout(False)
        ProjectDetails.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Layout As GroupBox
    Friend WithEvents ProjectDetails As GroupBox
    Friend WithEvents Count As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Deadline As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProjectId As Label
    Friend WithEvents ProjectName As Label
    Friend WithEvents Edit As Button
    Friend WithEvents Ok As Button
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents lable4 As Label
End Class
