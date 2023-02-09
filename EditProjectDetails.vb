Imports System.Data.SqlClient

Public Class EditProjectDetails

    Private Sub EditProjectDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String
        If ManagerHomePage.pid = "new" Then
            responce = MsgBox("If you close this window, you won't be able to delete " + ProjectName.Text + " later.", vbYesNo, "Are You Sure?")
        Else
            responce = MsgBox("Do you want to close this window?", vbYesNo, "Are You Sure?")
        End If

        If responce = vbYes Then
            LoginForm.sql.Close()
            'this will change accordingly if delete is clicked
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click

        'reconfirms
        Dim responce As String = MsgBox("Do you want to save changes done in " & ProjectName.Text, vbYesNo, "Are You Sure?")
        If responce = vbYes Then

            'update to database then close form

            'creating a sql command statement 
            Dim form2command As SqlCommand = LoginForm.sql.CreateCommand()
            form2command.CommandText = "Update Projects SET Title = '" + ProjectName.Text + "', Deadline = '" + DeadlineDuration.Text + "', People ='" + PeopleCount.Text + "' Where PId ='" + EditProjectWizard.ProjectId.Text + "'"

            'sqladapter to handle the sql commands
            Dim form2sqlAdapter As New SqlDataAdapter With {
                .SelectCommand = form2command
            }

            'creates a table with the required data
            Dim form2data As New DataSet()
            form2sqlAdapter.Fill(form2data)

            EditProjectWizard.Refresh()
            EditProjectWizard.Enabled = True
            EditProjectWizard.Show()
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
            form2command.CommandText = "Delete * FROM Projects WHERE PId ='" + EditProjectWizard.ProjectId.Text + "'"

            'sqladapter to handle the sql commands 
            Dim form2sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = form2command
            }

            'creates a table with the required data
            Dim form2data As New DataSet()
            form2sqlAdapter.Fill(form2data)

            'closes rest of the forms between manager home page and the current page
            EditProjectWizard.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim responce As String = MsgBox("Do you want to Cancel changes?", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'doesnt do any changes
            EditProjectWizard.Enabled = True
            EditProjectWizard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub EditProjectDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'delete will only be visible if new project is seen for the first time
        If ManagerHomePage.pid <> "new" Then
            Delete.Visible = False
        End If

        ProjectId.Text = "Project Id: " + EditProjectWizard.ProjectId.Text

        'creating a sql command statement 
        Dim form2command As SqlCommand = LoginForm.sql.CreateCommand()
        form2command.CommandText = "SELECT * FROM Projects WHERE PId ='" + EditProjectWizard.ProjectId.Text + "'"

        'sqladapter to handle the sql commands 
        Dim form2sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = form2command
        }

        'creates a table with the required data
        Dim form2data As New DataSet()
        form2sqlAdapter.Fill(form2data)

        'fill the data in the required places
        ProjectName.Text = form2data.Tables(0).Rows(0)(1).ToString()
        DeadlineDuration.Value = form2data.Tables(0).Rows(0)(2).ToString()
        PeopleCount.Value = form2data.Tables(0).Rows(0)(3).ToString()
    End Sub
End Class