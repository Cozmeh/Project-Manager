Imports System.Data.SqlClient

Public Class EditProjectWizard

    Private Sub EditProjectWizard_closeing(sender As Object, e As EventArgs) Handles MyBase.Closing
        ManagerHomePage.Enabled = True
    End Sub

    Private Sub EditProjectWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Filling all the fields
        If ManagerHomePage.pid = "new" Then
            ProjectName.Text = NewProjectWizard.ProjectName.Text
            Deadline.Value = NewProjectWizard.DeadlineDuration.Value
            Count.Text = NewProjectWizard.PeopleCount.Value
            Return
        End If

        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT PId, Title, Deadline,People FROM Projects WHERE PId = '" & ManagerHomePage.pid & "'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        ProjectId.Text = Consoledata.Tables(0).Rows(0)(0)
        ProjectName.Text = Consoledata.Tables(0).Rows(0)(1)
        Deadline.Value = Consoledata.Tables(0).Rows(0)(2)
        Count.Text = Consoledata.Tables(0).Rows(0)(3)
    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        ManagerHomePage.Enabled = True
        Me.Close()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        EditProjectDetails.Show()
        Me.Enabled = False
    End Sub
End Class