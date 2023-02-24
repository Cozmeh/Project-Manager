Imports System.Data.SqlClient

Public Class NewProjectWizard

    Public id As String
    Public enable As Integer = 0


    Private Sub NewProjectWizard_Load(sender As Object, e As EventArgs)

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
        For Each row In data.Tables(0).Rows().ToString
            If id = row Then
                id = pId.Next(100000, 999999).ToString
            End If
        Next
        ProjectGrpBox.Text = "Project Id: " & id.ToString
    End Sub

    Private Sub NewProjectWizard_FormClosing(sender As Object, e As FormClosingEventArgs)
        'reload manager home page data grid view
        ManagerHomePage.Update()
        'Enable manager home page
        If enable = 0 Then
            ManagerHomePage.Enabled = True
            ManagerHomePage.Show()
        End If
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click

        'check if the project details has been updated
        If ProjectName.Text = Nothing Then
            MsgBox("Please enter the project name")
            Return
        End If

        Dim create As String = MsgBox("Project Name: '" + ProjectName.Text + "' with Deadline: '" + DeadlineDuration.Text + "' and number of members: " + PeopleCount.Value.ToString + " will be created", vbYesNo, "Are you sure you want to create new Project?")

        If create = vbNo Then
            Return
        End If

        'adds data to the table
        Dim AddCommand As String = "INSERT INTO Projects (PId,Title,StartDate,Deadline,People,ManagerId) VALUES ('" + id.ToString + "','" + ProjectName.Text + "','" + Today.ToString + "','" + DeadlineDuration.Text + "','" + PeopleCount.Value.ToString + "','" + ManagerHomePage.ManagerId.Text + "')"

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

        'opens the calender for further updation
        enable = 1
        EditProjectWizard.Show()
        ManagerHomePage.ManagerDataGrid.Refresh()
        ManagerHomePage.DataLoader()
        ManagerHomePage.Visible = False
        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        ManagerHomePage.Enabled = True
        ManagerHomePage.Show()
        Me.Close()
    End Sub
End Class