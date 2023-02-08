Imports System.Data.SqlClient

Public Class EditProjectDetails

    Private Sub EditProjectDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String
        If NewProjectWizard.enable = 1 Then
            responce = MsgBox("If you close this window, you won't be able to delete " + ProjectName.Text + " later.", vbYesNo, "Are You Sure?")
        Else
            responce = MsgBox("You want to close this window ", vbYesNo, "Are You Sure?")
        End If

        If responce = vbYes Then
            LoginForm.sql.Close()
            'this will change accordingly if delete is clicked
            EditProjectWizard.Enabled = True
            EditProjectWizard.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click

        Dim form2command As SqlCommand = LoginForm.sql.CreateCommand()
        Dim form2sqlAdapter As New SqlDataAdapter
        Dim form2data As New DataSet()

        'creating a sql command statement 
        form2command.CommandText = "Update Projects SET Title = '" + ProjectName.Text + ", Deadline = '" + DeadlineDuration.Value.ToString() + ", People ='" + PeopleCount.Value.ToString() + " Where PId ='" + ProjectId.Text + "'"

        'reconfirms
        Dim responce As String = MsgBox("Do you want to save changes done in " & ProjectName.Text, vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'update to database then close form

            'sqladapter to handle the sql commands
            form2sqlAdapter.SelectCommand = form2command

            'creates a table with the required data
            form2sqlAdapter.Fill(form2data)

            Me.Close()
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        'reconfirms
        Dim responce As String = MsgBox("Do you want to delete " & ProjectName.Text + "?", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'delete from database then close form
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim responce As String = MsgBox("Do you want to Cancel changes?", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'doesnt do any changes
            Me.Close()
        End If
    End Sub

    Private Sub EditProjectDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If NewProjectWizard.enable = 1 Then
            Delete.Visible = False
        End If

        ProjectId.Text = "Project Id: " + EditProjectWizard.ProjectId.Text

        Dim form2command As SqlCommand = LoginForm.sql.CreateCommand()
        Dim form2sqlAdapter As New SqlDataAdapter
        Dim form2data As New DataSet()

        'creating a sql command statement 
        form2command.CommandText = "SELECT * FROM Projects WHERE PId ='" + EditProjectWizard.ProjectId.Text + "'"

        'sqladapter to handle the sql commands 
        form2sqlAdapter.SelectCommand = form2command

        'creates a table with the required data
        form2sqlAdapter.Fill(form2data)

        'fill the data in the required places
        ProjectName.Text = form2data.Tables(0).Rows(0)(1).ToString()
        DeadlineDuration.Value = form2data.Tables(0).Rows(0)(2).ToString()
        PeopleCount.Value = form2data.Tables(0).Rows(0)(3).ToString()

    End Sub
End Class