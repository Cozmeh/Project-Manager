<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerHomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ManagerHomePage))
        LogoutManager = New Button()
        NewProject = New Button()
        Label1 = New Label()
        Label2 = New Label()
        ManagerId = New Label()
        ManagerName = New Label()
        UsergprBox = New GroupBox()
        ProjectBox = New GroupBox()
        ManagerDataGrid = New DataGridView()
        Label4 = New Label()
        UsergprBox.SuspendLayout()
        ProjectBox.SuspendLayout()
        CType(ManagerDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogoutManager
        ' 
        LogoutManager.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LogoutManager.Location = New Point(704, 43)
        LogoutManager.Name = "LogoutManager"
        LogoutManager.Size = New Size(85, 44)
        LogoutManager.TabIndex = 0
        LogoutManager.Text = "Logout"
        LogoutManager.UseVisualStyleBackColor = True
        ' 
        ' NewProject
        ' 
        NewProject.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        NewProject.Location = New Point(704, 402)
        NewProject.Name = "NewProject"
        NewProject.Size = New Size(84, 40)
        NewProject.TabIndex = 1
        NewProject.Text = "New +"
        NewProject.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(7, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 25)
        Label1.TabIndex = 2
        Label1.Text = "User Id:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(7, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 25)
        Label2.TabIndex = 3
        Label2.Text = "Name  :"' 
        ' ManagerId
        ' 
        ManagerId.AutoSize = True
        ManagerId.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ManagerId.Location = New Point(80, 19)
        ManagerId.Name = "ManagerId"
        ManagerId.Size = New Size(109, 25)
        ManagerId.TabIndex = 5
        ManagerId.Text = "Manager Id"' 
        ' ManagerName
        ' 
        ManagerName.AutoSize = True
        ManagerName.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ManagerName.Location = New Point(80, 59)
        ManagerName.Name = "ManagerName"
        ManagerName.Size = New Size(143, 25)
        ManagerName.TabIndex = 6
        ManagerName.Text = "Manager Name"' 
        ' UsergprBox
        ' 
        UsergprBox.Controls.Add(ManagerName)
        UsergprBox.Controls.Add(Label1)
        UsergprBox.Controls.Add(ManagerId)
        UsergprBox.Controls.Add(Label2)
        UsergprBox.Location = New Point(12, 12)
        UsergprBox.Name = "UsergprBox"
        UsergprBox.Size = New Size(234, 100)
        UsergprBox.TabIndex = 7
        UsergprBox.TabStop = False
        UsergprBox.Text = "Manager"' 
        ' ProjectBox
        ' 
        ProjectBox.Controls.Add(ManagerDataGrid)
        ProjectBox.Controls.Add(Label4)
        ProjectBox.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        ProjectBox.Location = New Point(12, 118)
        ProjectBox.Name = "ProjectBox"
        ProjectBox.Size = New Size(776, 278)
        ProjectBox.TabIndex = 15
        ProjectBox.TabStop = False
        ProjectBox.Text = "Projects:"' 
        ' ManagerDataGrid
        ' 
        ManagerDataGrid.AllowUserToAddRows = False
        ManagerDataGrid.AllowUserToDeleteRows = False
        ManagerDataGrid.AllowUserToResizeColumns = False
        ManagerDataGrid.AllowUserToResizeRows = False
        ManagerDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ManagerDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ManagerDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ManagerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ManagerDataGrid.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        ManagerDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        ManagerDataGrid.Location = New Point(7, 33)
        ManagerDataGrid.Name = "ManagerDataGrid"
        ManagerDataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        ManagerDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        ManagerDataGrid.RowHeadersWidth = 20
        ManagerDataGrid.RowTemplate.Height = 25
        ManagerDataGrid.ScrollBars = ScrollBars.Vertical
        ManagerDataGrid.Size = New Size(764, 239)
        ManagerDataGrid.TabIndex = 1
        ManagerDataGrid.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(51, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(685, 37)
        Label4.TabIndex = 17
        Label4.Text = "All of your past and ongoing projects will be shown here"' 
        ' ManagerHomePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ProjectBox)
        Controls.Add(UsergprBox)
        Controls.Add(NewProject)
        Controls.Add(LogoutManager)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ManagerHomePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manager Home Page"
        UsergprBox.ResumeLayout(False)
        UsergprBox.PerformLayout()
        ProjectBox.ResumeLayout(False)
        ProjectBox.PerformLayout()
        CType(ManagerDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LogoutManager As Button
    Friend WithEvents NewProject As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ManagerId As Label
    Friend WithEvents ManagerName As Label
    Friend WithEvents UsergprBox As GroupBox
    Friend WithEvents ProjectBox As GroupBox
    Friend WithEvents ManagerDataGrid As DataGridView
    Friend WithEvents Label4 As Label
End Class
