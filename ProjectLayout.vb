Public Class ProjectLayout
    Private Sub ProjectLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Filling all the fields when opened from clicking on Datagrid in ManagerHomePage
        If ManagerHomePage.pid <> "new" Then
            ProjectId.Text = ManagerHomePage.pid
            ProjectName.Text = ManagerHomePage.title
            StartDate.Value = ManagerHomePage.startdate
            Deadline.Value = ManagerHomePage.deadline
            Count.Text = ManagerHomePage.people
        Else
            'Filling all the fields when opened from NewProjectWizard
            ProjectId.Text = NewProjectWizard.id
            ProjectName.Text = NewProjectWizard.ProjectName.Text
            StartDate.Value = Today
            Deadline.Value = NewProjectWizard.DeadlineDuration.Value
            Count.Text = NewProjectWizard.PeopleCount.Value
        End If

        ''creating a sql command statement 
        'Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        'Consolecommand.CommandText = "SELECT PId, Title, Deadline,People FROM Projects WHERE PId = '" & ManagerHomePage.pid & "'"

        ''sqladapter to handle the sql commands 
        'Dim ConsolesqlAdapter As New SqlDataAdapter With {
        '    .SelectCommand = Consolecommand
        '}

        ''creates a table with the required data
        'Dim Consoledata As New DataSet()
        'ConsolesqlAdapter.Fill(Consoledata)

        'ProjectId.Text = Consoledata.Tables(0).Rows(0)(0)
        'ProjectName.Text = Consoledata.Tables(0).Rows(0)(1)
        'Deadline.Value = Consoledata.Tables(0).Rows(0)(2)
        'Count.Text = Consoledata.Tables(0).Rows(0)(3)
    End Sub

    'Project layout will be saved when Save button is clicked
    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        Dim responce As String = MsgBox("Do you want to save changes?", vbYesNo, "Are you sure?")
        If responce = vbYes Then
            'will store the project layout in the layout table
            Me.Close()
        End If
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        EditProjectDetails.Show()
        Me.Enabled = False
        Me.Hide()
    End Sub

    Private Sub addEmp_Click(sender As Object, e As EventArgs) Handles addEmp.Click
        Me.Enabled = False
        Contributors.Show()
    End Sub

    Private Sub ProjectLayout_FormClosing_1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ManagerHomePage.Enabled = True
        ManagerHomePage.Show()
        ManagerHomePage.Refresh()
        ManagerHomePage.ManagerDataGrid.Refresh()
    End Sub
End Class