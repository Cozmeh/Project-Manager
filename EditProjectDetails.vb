Imports System.Data.SqlClient

Public Class EditProjectDetails

    Dim res As String = vbNo
    Public deleted As Boolean = False

    Private Sub EditProjectDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String
        If res <> vbYes Then
            If ManagerHomePage.pid = "new" And deleted = False Then
                responce = MsgBox("If you close this window, you won't be able to delete " + ProjectName.Text + " later.", vbYesNo, "Are You Sure?")
            Else
                responce = MsgBox("Do you want to close this window?", vbYesNo, "Are You Sure?")
            End If

            If responce = vbYes Then
                LoginForm.sql.Close()
                'ManagerHomePage.Enabled = True
                ManagerHomePage.ManagerDataGrid.Refresh()
                ProjectLayout.Enabled = True
                ProjectLayout.Show()
                If deleted Then
                    'closes rest of the forms between manager home page and the current page
                    ProjectLayout.Close()
                End If
                'this will change accordingly if delete is clicked
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click

        'reconfirms
        Dim responce As String = MsgBox("Do you want to save changes done in Project Id: " & ProjectLayout.ProjectId.Text + "?", vbYesNo, "Are You Sure?")
        'update to database then close form
        If responce = vbYes Then
            'creating a sql command statement 
            Dim form2command As SqlCommand = LoginForm.sql.CreateCommand()
            form2command.CommandText = "Update Projects SET Title = '" + ProjectName.Text + "', Deadline = '" + DeadlineDuration.Text + "', People ='" + PeopleCount.Text + "' Where PId ='" + ProjectLayout.ProjectId.Text + "'"

            'sqladapter to handle the sql commands
            Dim form2sqlAdapter As New SqlDataAdapter With {
                .SelectCommand = form2command
            }

            'creates a table with the required data
            Dim form2data As New DataSet()
            form2sqlAdapter.Fill(form2data)

            ProjectLayout.Refresh()
            Me.Close()
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        'reconfirms
        Dim responce As String = MsgBox("Do you want to delete " & ProjectName.Text + "?", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'delete from database then close form
            'creating a sql command statement 
            Dim form2command As SqlCommand = LoginForm.sql.CreateCommand()
            form2command.CommandText = "Delete FROM Projects WHERE PId ='" + ProjectLayout.ProjectId.Text + "'"

            'sqladapter to handle the sql commands 
            Dim form2sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = form2command
            }

            'creates a table with the required data
            Dim form2data As New DataSet()
            form2sqlAdapter.Fill(form2data)

            deleted = True
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        res = MsgBox("Do you want to Cancel changes?", vbYesNo, "Are You Sure?")
        If res = vbYes Then
            'doesn't do any changes
            ProjectLayout.Enabled = True
            ProjectLayout.Show()
            Me.Close()
        End If
    End Sub

    Private Sub EditProjectDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'delete will only be visible if new project is seen for the first time
        If ManagerHomePage.pid = "new" Then
            Delete.Enabled = True
        End If

        'fill the data in the required places
        ProjectName.Text = ProjectLayout.ProjectName.Text
        ProjectId.Text = "Project Id:" + ProjectLayout.ProjectId.Text
        DeadlineDuration.Value = ProjectLayout.dead.Text
        PeopleCount.Value = ProjectLayout.Count.Text
    End Sub
End Class