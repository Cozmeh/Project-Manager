Imports System.Data.SqlClient

Public Class NewProjectWizard

    Public id As String

    Private Sub NewProjectWizard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'reload manager home page data grid view
        ManagerHomePage.Update()
        ManagerHomePage.Enabled = True
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click

        'check if the project details has been updated
        If ProjectName.Text = Nothing Then
            MsgBox("Please enter the project name")
            Return
        End If

        Dim NoOfDays As Integer
        NoOfDays = DateDiff("d", Today, DeadlineDuration.Value)


        Dim create As String = MsgBox("Project Name : " + ProjectName.Text + vbLf + vbLf + "Deadline : " + DeadlineDuration.Text + "' (" + NoOfDays.ToString + " Days from today)" + vbLf + vbLf + "Number of members : " + PeopleCount.Value.ToString + vbLf + vbLf + "Project with following details will be created", vbYesNo, "Are you sure ?")

        If create = vbNo Then
            Return
        End If

        'adds data to the table
        Dim AddCommand As String = "INSERT INTO Projects (PId, Title, Startdate, Deadline, People, ManagerId , Days) VALUES ('" + id.ToString + "', '" + ProjectName.Text + "', '" + Today.ToString("MM-dd-yyyy") + "', '" + DeadlineDuration.Value.ToString("MM-dd-yyyy") + "', '" + PeopleCount.Value.ToString + "', '" + ManagerHomePage.ManagerId.Text + "', '" + NoOfDays.ToString + "')"

        'creating a sql command statement 
        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = AddCommand

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
        .SelectCommand = command
        }
        'creates a table with the required data
        Dim data As New DataSet()
        sqlAdapter.Fill(data)

        'opens the project layout for further updation
        ProjectLayout.Show()
        ManagerHomePage.ManagerDataGrid.Refresh()
        ManagerHomePage.DataLoader()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        ManagerHomePage.Enabled = True
        ManagerHomePage.Show()
        Me.Close()
    End Sub

    Private Sub NewProjectWizard_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        'this adds one month to minimum date thresh hold
        DeadlineDuration.MinDate = Date.Now.AddMonths(1)

        'creating a sql command statement 
        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = "SELECT PId FROM Projects"

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = command
        }
        'creates a table with the required data
        Dim data As New DataSet()
        sqlAdapter.Fill(data)

        'creating random project id
        Dim pId As New Random()
        id = pId.Next(100000, 999999).ToString
        For Each row In data.Tables(0).Rows()
            If id = row.ToString Then
                id = pId.Next(100000, 999999).ToString
            End If
        Next
        ProjectGrpBox.Text = "Project Id: " & id
    End Sub
End Class