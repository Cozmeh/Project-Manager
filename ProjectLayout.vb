Imports System.Data.SqlClient

Public Class ProjectLayout
    Private startdate, reqana, Design, Development, Testing, Deadline As Date

    Private Sub ProjectLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'initial positions of panels this block of code will go inside the else block... when the page open for the first time
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size '- RightTestPanel.Size
        'LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size




        'this will be inside the if block when the project is opened again from the manager home page
        'below code will change according to the date stored in layout database
        'LeftDesPanel.Size = ReqPanel.Size
        'LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        'LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size

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
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        'LayoutTable()

        Dim responce As String = MsgBox("The changes are saved.\n Do you want to exit?", vbYesNo, "Are you sure?")
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

    Private Sub ProjectLayout_FormClosing_1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'saves the dates in the table
        'LayoutTable()
        MsgBox("The dates have been saved.")

        ManagerHomePage.Enabled = True
        ManagerHomePage.Show()
        ManagerHomePage.Refresh()
        ManagerHomePage.ManagerDataGrid.Refresh()
    End Sub

    Private Sub ReqSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles ReqSplitter.SplitterMoved
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        'LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size
        TestingPanel.Size = RightDevPanel.Size '- RightTestPanel.Size
        '
    End Sub

    Private Sub RightDesSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RightDesSplitter.SplitterMoved
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        'LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size
        TestingPanel.Size = RightDevPanel.Size '- RightTestPanel.Size

    End Sub

    Private Sub RDevSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RDevSplitter.SplitterMoved
        'LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size
        TestingPanel.Size = RightDevPanel.Size '- RightTestPanel.Size

    End Sub

    Private Sub RightTestSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        ' LeftTestPanel.Size = LeftDevPanel.Size + DevelopmentPanel.Size
        TestingPanel.Size = RightDevPanel.Size - RightTestPanel.Size

    End Sub

    Private Sub LayoutTable()
        'adds data to the layout table
        Dim UpdateCommand As String = "UPDATE Layout SET StartDate ='" + startdate + "',Requirement Analysis ='" + reqana + "',Design='" + Design + "',Developmene='" + Development + "',Testing='" + Testing + "',Deadline='" + Deadline + "' Where PId ='" + ProjectId.Text + "'"

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

End Class