Imports Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient

Public Class NewProjectWizard

    Dim id As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'Private Sub DeadlineDuration_ValueChanged(sender As Object, e As EventArgs) Handles DeadlineDuration.ValueChanged
    '    'store project name in grpbox legend
    '    If ProjectName.Text <> Nothing Then
    '        ProjectGrpBox.Text = ProjectName.Text
    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Create.Click

        'adds data to the table
        Dim AddCommand As String = "INSERT INTO Projects (PId,Title,Deadline,People,ManagerId) VALUES ('" & id.ToString & "','" + ProjectName.Text + "','" + DeadlineDuration.Text + "','" + PeopleCount.Value + "','" + ManagerHomePage.ManagerId.Text + "')"

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

        'check if the project details has been updated
        If ProjectName.Text = Nothing Then
            MsgBox("Please enter the project name")
            Return
        End If

        'opens the calender for further updation
        EditProjectWizard.Show()
        Me.Close()
    End Sub

    Private Sub NewProjectWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'diable manager HomePage
        ManagerHomePage.Enabled = False

        'this should add one month to minimum date threshold
        DeadlineDuration.MinDate = DateTime.Now.AddMonths(1)

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
        id = pId.Next(100000, 999999)
        For Each row In data.Tables(0).Rows()
            If id = row Then
                id = pId.Next(100000, 999999)
            End If
        Next
        ProjectGrpBox.Text = "Project Id: " & id.ToString
    End Sub

    Private Sub NewProjectWizard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Enable manager home page
        ManagerHomePage.Enabled = True
    End Sub

End Class