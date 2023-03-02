Public Class ProjectLayout
    Private Sub ProjectLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'initial positions of panels
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size




        ManagerHomePage.Hide()
        'Filling all the fields when opened from clicking on Datagrid in ManagerHomePage
        If ManagerHomePage.pid <> "new" Then
            ProjectId.Text = ManagerHomePage.pid
            ProjectName.Text = ManagerHomePage.title
            Start.Text = ManagerHomePage.startdate.ToString()
            dead.Text = ManagerHomePage.deadline.ToString()
            Count.Text = ManagerHomePage.people
        Else
            'Filling all the fields when opened from NewProjectWizard
            ProjectId.Text = NewProjectWizard.id
            ProjectName.Text = NewProjectWizard.ProjectName.Text
            Start.Text = Today.ToString("dd-MM-yyyy")
            dead.Text = NewProjectWizard.DeadlineDuration.Value.ToString("dd-MM-yyyy")
            Count.Text = NewProjectWizard.PeopleCount.Value
        End If
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

    Private Sub ReqSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles ReqSplitter.SplitterMoved
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size
        DeployPanel.Size = RightTestPanel.Size
    End Sub

    Private Sub RightDesSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RightDesSplitter.SplitterMoved
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size
        DeployPanel.Size = RightTestPanel.Size
    End Sub

    Private Sub RDevSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RDevSplitter.SplitterMoved
        LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size
        DeployPanel.Size = RightTestPanel.Size
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size

    End Sub

    Private Sub EndLimit()
        MsgBox("RightTestPanelWidth" + RightTestPanel.Size.Width.ToString)
        MsgBox("DeployPanelWidth" + DeployPanel.Size.Width.ToString)

        If RightTestPanel.Size.Width < DeployPanel.Size.Width Then
            RightTestPanel.Size = DeployPanel.Size
            MsgBox("DeployPanelSize IF" + DeployPanel.Size.ToString)
            MsgBox("RightTestPanelSize If" + RightTestPanel.Size.ToString)
        End If
    End Sub

    Private Sub RightTestSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RightTestSplitter.SplitterMoved
        DeployPanel.Size = RightTestPanel.Size
    End Sub
End Class