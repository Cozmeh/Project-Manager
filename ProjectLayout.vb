Public Class ProjectLayout
    Private Sub ProjectLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Filling all the fields when opened from clicking on Datagrid in ManagerHomePage
        If ManagerHomePage.pid <> "new" Then
            ProjectId.Text = ManagerHomePage.pid
            ProjectName.Text = ManagerHomePage.title
            StartDate.Value = ManagerHomePage.startdate
            Deadline.Value = ManagerHomePage.deadline
            Count.Text = ManagerHomePage.people
            Return
        End If

        'Filling all the fields when opened from NewProjectWizard
        ProjectId.Text = NewProjectWizard.id
        ProjectName.Text = NewProjectWizard.ProjectName.Text
        StartDate.Value = Today
        Deadline.Value = NewProjectWizard.DeadlineDuration.Value
        Count.Text = NewProjectWizard.PeopleCount.Value

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

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        Me.Close()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        EditProjectDetails.Show()
        Me.Enabled = False
    End Sub

    Private Sub ProjectLayout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ManagerHomePage.Enabled = True
        ManagerHomePage.Show()
        ManagerHomePage.Refresh()
    End Sub
End Class