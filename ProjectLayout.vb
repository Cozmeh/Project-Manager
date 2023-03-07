Imports System.Data.SqlClient

Public Class ProjectLayout
    Private reqana, Design, Development, Testing As Date
    Private NoOfDays As Integer
    Private ReqNo, DesNo, DevNo, TesNo, DepNo As Integer
    Public task As String

    Private Sub ProjectLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'this will be inside the if block when the project is opened again from the manager home page
        'below code will change according to the date stored in layout database

        'starting stage sizes based on percentages 
        ReqPanel.Size = New Size(0.15 * DeploymentPanel.Size.Width, 50)
        DesPanel.Size = New Size(0.2 * DeploymentPanel.Size.Width, 50)
        DevelopmentPanel.Size = New Size(0.3 * DeploymentPanel.Size.Width, 50)
        TestingPanel.Size = New Size(0.25 * DeploymentPanel.Size.Width, 50)

        'starting stage positions based on sizes 
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size

        'store dates as the project loads and will be change when the SIZECHANGE function is called
        'startdate, reqana, Design, Development, Testing, Deadline

        ManagerHomePage.Hide()
        'Filling all the fields when opened from clicking on Datagrid in ManagerHomePage
        If ManagerHomePage.pid <> "new" Then
            ProjectId.Text = ManagerHomePage.pid
            ProjectName.Text = ManagerHomePage.title
            Start.Text = ManagerHomePage.startdate.ToString().Substring(0, 10)
            dead.Text = ManagerHomePage.deadline.ToString().Substring(0, 10)
            Count.Text = ManagerHomePage.people
            'reset width according to date
        Else
            'Filling all the fields when opened from NewProjectWizard
            ProjectId.Text = NewProjectWizard.id
            ProjectName.Text = NewProjectWizard.ProjectName.Text
            Start.Text = Today.ToString("dd-MM-yyyy")
            dead.Text = NewProjectWizard.DeadlineDuration.Value.ToString("dd-MM-yyyy")
            Count.Text = NewProjectWizard.PeopleCount.Value
            'reset according to idea value ratio
            'adds data to the layout table
            Dim que As String = "INSERT INTO Layout(PID, StartDate, Deadline) VALUES('" + NewProjectWizard.id + "','" + Today.ToString("dd-MM-yyyy") + "','" + NewProjectWizard.DeadlineDuration.Value.ToString("dd-MM-yyyy") + "')"

            'creating a sql command statement 
            Dim coma As SqlCommand = LoginForm.sql.CreateCommand()
            coma.CommandText = que

            'sqladapter to handle the sql commands 
            Dim Adapter As New SqlDataAdapter With {
             .SelectCommand = coma
            }

            'creates a table with the required data
            Dim da As New DataSet()
            Adapter.Fill(da)
        End If

        '-------------------------------------------------------------------
        'adds data to the layout table
        Dim Com As String = "Select Days from Projects where PId ='" + ProjectId.Text + "'"

        'creating a sql command statement 
        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = Com

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
             .SelectCommand = command
        }

        'creates a table with the required data
        Dim data As New DataSet()
        sqlAdapter.Fill(data)
        NoOfDays = Convert.ToInt32(data.Tables(0).Rows(0)(0).ToString)
        GetDays()
        GetEndDates()
        ProjectSpan.Text = "Project Span : " + NoOfDays.ToString + "Days"

        '----------------------------------------------------------------------
        'tooltips
        ToolTip()
        '----------------------------------------------

        'qurry for adding row in layout with only pid and deadline

    End Sub

    'Project layout will be saved when Save button is clicked
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        LayoutTable()
        Dim responce As String = MsgBox("The changes are saved" + vbLf + "Do you want to exit?", vbYesNo, "Are you sure?")
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

    Private Sub AddEmp_Click(sender As Object, e As EventArgs) Handles addEmp.Click
        Me.Enabled = False
        Contributors.Show()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        'starting stage sizes based on percentages 
        ReqPanel.Size = New Size(0.15 * DeploymentPanel.Size.Width, 50)
        DesPanel.Size = New Size(0.2 * DeploymentPanel.Size.Width, 50)
        DevelopmentPanel.Size = New Size(0.3 * DeploymentPanel.Size.Width, 50)
        TestingPanel.Size = New Size(0.25 * DeploymentPanel.Size.Width, 50)
        'starting stage positions based on sizes 
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size

    End Sub

    Private Sub ReqPanel_SizeChanged(sender As Object, e As EventArgs) Handles ReqPanel.SizeChanged
        GetDays()
        GetEndDates()
        ToolTip()
    End Sub

    Private Sub DesPanel_SizeChanged(sender As Object, e As EventArgs) Handles DesPanel.SizeChanged
        GetDays()
        GetEndDates()
        ToolTip()
    End Sub

    Private Sub DevelopmentPanel_SizeChanged(sender As Object, e As EventArgs) Handles DevelopmentPanel.SizeChanged
        GetDays()
        GetEndDates()
        ToolTip()
    End Sub

    Private Sub TestingPanel_SizeChanged(sender As Object, e As EventArgs) Handles TestingPanel.SizeChanged
        GetDays()
        GetEndDates()
        ToolTip()
    End Sub

    Private Sub ProjectLayout_FormClosing_1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'saves the dates in the table
        LayoutTable()
        MsgBox("The dates have been saved.")
        ManagerHomePage.Enabled = True
        ManagerHomePage.Show()
        ManagerHomePage.Refresh()
        ManagerHomePage.ManagerDataGrid.Refresh()
    End Sub

    Private Sub ReqSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles ReqSplitter.SplitterMoved
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size
    End Sub

    Private Sub RightDesSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RightDesSplitter.SplitterMoved
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size
    End Sub

    Private Sub RDevSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RDevSplitter.SplitterMoved
        TestingPanel.Size = RightDevPanel.Size
    End Sub

    Private Sub LayoutTable()
        'adds data to the layout table
        Dim UpdateCommand As String = "UPDATE Layout SET Requirement='" + reqana.ToString("yyyy-MM-dd") + "',Design='" + Design.ToString("yyyy-MM-dd") + "',Development='" + Development.ToString("yyyy-MM-dd") + "',Testing='" + Testing.ToString("yyyy-MM-dd") + "' Where PId ='" + ProjectId.Text + "'"

        'creating a sql command statement 
        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = UpdateCommand

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
             .SelectCommand = command
        }

        'creates a table with the required data
        Dim data As New DataSet()
        sqlAdapter.Fill(data)
    End Sub

    Private Sub GetDays()
        ReqNo = Math.Round((ReqPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
        DesNo = Math.Round((DesPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
        DevNo = Math.Round((DevelopmentPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
        TesNo = Math.Round((TestingPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
        DepNo = Math.Round((DeployPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
    End Sub

    Private Sub GetEndDates()
        If ManagerHomePage.pid <> "new" Then
            reqana = Convert.ToDateTime(ManagerHomePage.startdate.ToString().Substring(0, 10)).AddDays(ReqNo)
        Else
            reqana = Today.AddDays(ReqNo)
        End If
        Design = reqana.AddDays(DesNo)
        Development = Design.AddDays(DevNo)
        Testing = Development.AddDays(TesNo)
    End Sub

    Private Sub ToolTip()
        ReqTip.SetToolTip(Me.ReqBtn, reqana.ToString.Substring(0, 10) + " (" + ReqNo.ToString + " Days)")
        DesTip.SetToolTip(Me.DesignBtn, Design.ToString.Substring(0, 10) + " (" + DesNo.ToString + " Days)")
        DevTip.SetToolTip(Me.DevBtn, Development.ToString.Substring(0, 10) + " (" + DevNo.ToString + " Days)")
        TestTip.SetToolTip(Me.TestBtn, Testing.ToString.Substring(0, 10) + " (" + TesNo.ToString + " Days)")
        DepTip.SetToolTip(Me.DepBtn, dead.Text + " (" + DepNo.ToString + " Days)")
    End Sub

    Private Sub ReqBtn_Click(sender As Object, e As EventArgs) Handles ReqBtn.Click
        task = "Requirement Analysis"
        TaskContributor.Show()
        Me.Hide()
    End Sub

    Private Sub DesignBtn_Click(sender As Object, e As EventArgs) Handles DesignBtn.Click
        task = "Design"
        TaskContributor.Show()
        Me.Hide()
    End Sub

    Private Sub DevBtn_Click(sender As Object, e As EventArgs) Handles DevBtn.Click
        task = "Development"
        TaskContributor.Show()
        Me.Hide()
    End Sub

    Private Sub TestBtn_Click(sender As Object, e As EventArgs) Handles TestBtn.Click
        task = "Testing"
        TaskContributor.Show()
        Me.Hide()
    End Sub
End Class