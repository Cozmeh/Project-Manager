Imports System.Data.SqlClient

Public Class Contributors
    Private Sub Contributors_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Do you want to update contibutors", vbYesNo, "Update Contributors")
        ProjectLayout.Enabled = True
    End Sub

    Private Sub Contributors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        projectId.Text = "Project Id: " + ProjectLayout.ProjectId.Text
        projectName.Text = ProjectLayout.ProjectName.Text
        Count.Text = ProjectLayout.Count.Text

        DataLoader()
    End Sub

    Public Sub DataLoader()
        'change project id datatype
        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT * FROM Contributors WHERE PID = '" & ProjectLayout.ProjectId.Text & "'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        ContributorDataGrid.DataSource = Consoledata.Tables(0)
    End Sub

    Private Sub Validate_Click(sender As Object, e As EventArgs) Handles Validate.Click

        'validate Employee Id
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT ID, Designation FROM Employees WHERE ID = '" & ContId.Text & "'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)
        'Consolecommand.CommandText = "SELECT EmpID FROM Contributors WHERE EmpID = '" & ContId.Text & "'"

        If (Consoledata.Tables(0).Rows.Count) > 0 Then
            If Consoledata.Tables(0).Rows(0)(1) = "E" Then
                MsgBox("Employee with Id '" + ContId.Text + "' exists")
            ElseIf Consoledata.Tables(0).Rows(0)(1) = "M" Then
                MsgBox("Can not add Manager to the Project '" + ProjectLayout.ProjectName.Text)
            End If
        Else
            MsgBox("Employee with Id '" + ContId.Text + Text + "' was not found")
        End If
    End Sub

    Private Sub AddRow_Click(sender As Object, e As EventArgs) Handles AddRow.Click

        'create a hash set of all the unique values in the conributor datagrid
        Dim uniqueValues As New HashSet(Of String)()
        For Each row As DataGridViewRow In ContributorDataGrid.Rows
            If Not row.IsNewRow Then
                Dim value As String = row.Cells(1).Value.ToString()
                uniqueValues.Add(value)
            End If
        Next

        If ContId.Text = Nothing Then
            MsgBox("Please enter Contributor's Id!")
            Return
        End If

        'check if the given value already exist in the data grid
        Dim limit As Boolean = True
        For Each value In uniqueValues
            If ContId.Text = value Or Integer.Parse(Count.Text) > Integer.Parse(uniqueValues.Count) Then
                limit = False
                Exit For
            End If
        Next

        'check if the maximum limit reached
        If Integer.Parse(uniqueValues.Count) <> 0 And limit Then
            MsgBox("Maximum number of Contributors reached")
            Return
        End If

        'creating random task id
        Dim id As String
        Dim pId As New Random()
        id = pId.Next(100000, 999999).ToString
        For Each row In ContributorDataGrid.Rows
            If id = row.Cells(0).ToString Then
                id = pId.Next(100000, 999999).ToString
            End If
        Next

        'check if an employee with same task in the project already exists
        For Each row In ContributorDataGrid.Rows
            If ContId.Text = row.Cells(1).Value.ToString And Task.Text = row.Cells(2).value.ToString Then
                MsgBox("Employee with id '" + ContId.Text + " and " + Task.Text + "' already exist")
                Return
            End If
        Next

        'confirmation
        Dim responce As String = vbNo
        If Task.Text = Nothing Then
            responce = MsgBox("Add '" & ContId.Text & "' to the Project with unassigned task?", vbYesNo, "Add new member?")
        Else
            responce = MsgBox("Add '" & ContId.Text & "' to the Project with task of " + Task.Text, vbYesNo, "Add new member?")
        End If

        If responce = vbNo Then
            Return
        End If

        'adds data to the table
        Dim AddCommand As String = "INSERT INTO Contributors (Id,EmpID,Task,PID) VALUES ('" + id + "','" + ContId.Text + "','" + Task.Text + "','" + ProjectLayout.ProjectId.Text + "')"

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

        DataLoader()

        'empty the textboxes
        ContId.Text = Nothing
        Task.Text = Nothing
    End Sub

    Private Sub GetId_Click(sender As Object, e As EventArgs) Handles getId.Click
        If UCont.Text = Nothing Then
            MsgBox("Please mention correct Task ID!")
            Return
        End If

        For Each row In ContributorDataGrid.Rows
            If UCont.Text = row.Cells(0).Value.ToString Then
                UTask.Text = row.Cells(2).Value.ToString

                UTask.Enabled = True
                UpdateRow.Enabled = True
                Return
            End If
        Next
        MsgBox("Task ID not found!")
    End Sub

    Private Sub UpdateRow_Click(sender As Object, e As EventArgs) Handles UpdateRow.Click

        If UTask.Text = "Requirement Analysis" Or UTask.Text = "Design" Or UTask.Text = "Development" Or UTask.Text = "Testing" Then
            'conformation
            Dim responce As String = MsgBox("Update Task?", vbYesNo, "Update " & Task.Text & " for the Employee " + UCont.Text)
            If responce = vbNo Then
                Return
            End If
        Else
            MsgBox("Invalid Designation!")
            Return
        End If

        If UCont.Text = Nothing Or UTask.Text = Nothing Then
            MsgBox("Please fill all the details!")
            Return
        End If

        Dim UpdateCommand As String = "UPDATE Contributors SET Task ='" + UTask.Text + "' Where TaskId ='" + UCont.Text + "'"
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

        DataLoader()

        'reseting textbox
        UCont.Text = Nothing
        UTask.Text = Nothing

        UTask.Enabled = False
        UpdateRow.Enabled = False
    End Sub

    Private Sub DeleteRow_Click(sender As Object, e As EventArgs) Handles DeleteRow.Click
        If Del_ID.Text = Nothing Then
            MsgBox("Please mention the Contributor ID ")
            Return
        End If

        'conformation
        Dim responce As String = MsgBox("Remove all task of Employee " + Del_ID.Text + " from the Project '" & ProjectLayout.ProjectName.Text & "'", vbYesNo, "Remove User?")
        If responce = vbNo Then
            Return
        End If

        For Each row In ContributorDataGrid.Rows
            If Del_ID.Text = row.Cells(1).Value.ToString Then
                'creating a sql command statement 
                Dim DelCommand As SqlCommand = LoginForm.sql.CreateCommand()
                DelCommand.CommandText = "DELETE FROM Contributors WHERE EmpID ='" + Del_ID.Text + "'"

                'sqladapter to handle the sql commands 
                Dim sqlAdapter As New SqlDataAdapter With {
                .SelectCommand = DelCommand
                }

                'creates a table with the required data
                Dim data As New DataSet()
                sqlAdapter.Fill(data)
                DataLoader()

                'reseting textbox
                Del_ID.Text = Nothing
                Return
            End If
        Next
        MsgBox("Employee not found!")
    End Sub
End Class