Imports System.Data.SqlClient

Public Class TaskContributor
    Private Sub TaskContributor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        projectName.Text = ProjectLayout.ProjectName.Text
        Task.Text = ProjectLayout.task
        projectId.Text = "Project Id:" + ProjectLayout.ProjectId.Text
        Dataload()
    End Sub

    Private Sub Dataload()

        'adds data to the task contributors
        Dim UpdateCommand As String = "SELECT Id, EmpID, Status, Complete, Comment FROM Contributors WHERE PID='" + ProjectLayout.ProjectId.Text + "' AND (Task='" + Task.Text + "' OR TASK='Un-Assigned')"

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

        ContributorDataGrid.DataSource = data.Tables(0)
    End Sub

    Private Sub TaskContributor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Are you done with the changes", vbYesNo, "Done?")
        If responce = vbNo Then
            Return
        End If
        ProjectLayout.Enabled = True
        ProjectLayout.Show()
    End Sub

    Private Sub UpdateComment_TextChanged(sender As Object, e As EventArgs) Handles UpdateComment.TextChanged
        Dim len As String
        len = UpdateComment.Text.Length

        usize.Text = len + "/50"

        If len > 50 Then
            MsgBox("Number of Characters: " & len & vbCrLf & "Maximum number of Character: 50")
            Return
        End If
    End Sub

    Private Sub AddComment_TextChanged(sender As Object, e As EventArgs) Handles AddComment.TextChanged
        Dim len As String
        len = AddComment.Text.Length

        asize.Text = len + "/50"

        If len > 50 Then
            MsgBox("Number of Characters: " & len & vbCrLf & "Maximum number of Character: 50")
            Return
        End If
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
                AddComment.Enabled = True
                'MsgBox("Employee with Id '" + ContId.Text + "' exists")
            ElseIf Consoledata.Tables(0).Rows(0)(1) = "M" Then
                MsgBox("Can not add Manager to the Project '" + projectName.Text)
            End If
        Else
            MsgBox("Employee with Id '" + ContId.Text + Text + "' was not found")
        End If
    End Sub

    Private Sub GetId_Click(sender As Object, e As EventArgs) Handles getId.Click
        If UContId.Text = Nothing Then
            MsgBox("Please mention correct Task ID!")
            Return
        End If

        For Each row In ContributorDataGrid.Rows
            If UContId.Text = row.Cells(0).Value.ToString Then
                UpdateComment.Text = row.Cells(4).Value.ToString

                UpdateRow.Enabled = True
                UpdateComment.Enabled = True
                Return
            End If
        Next
        MsgBox("Task ID not found!")
    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        Me.Close()
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
            If ContId.Text = value Or Integer.Parse(ProjectLayout.Count.Text) > Integer.Parse(uniqueValues.Count) Then
                limit = False
                Exit For
            End If
        Next

        'check if any task is assigned and the maximum limit reached
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
            If ContId.Text = row.Cells(1).Value.ToString Then
                MsgBox("Employee with id '" + ContId.Text + " and " + Task.Text + "' already exist")
                Return
            End If
        Next

        'confirmation
        Dim responce As String = vbNo
        responce = MsgBox("Add '" & ContId.Text & "' to the Project with the task " + Task.Text, vbYesNo, "Add new member?")

        If responce = vbNo Then
            Return
        End If

        'adds data to the table
        Dim AddCommand As String = "INSERT INTO Contributors (Id,EmpID,Task,PID,Comment) VALUES ('" + id + "','" + ContId.Text + "','" + Task.Text + "','" + ProjectLayout.ProjectId.Text + "','" + AddComment.Text + "')"

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

        Dataload()

        'empty the textboxes
        ContId.Text = Nothing
        AddComment.Text = Nothing
    End Sub

    Private Sub UpdateRow_Click(sender As Object, e As EventArgs) Handles UpdateRow.Click

        'conformation
        Dim responce As String = MsgBox("Update Comment?", vbYesNo, "Update comment for the Employee " + UContId.Text)
        If responce = vbNo Then
            Return
        End If

        If UContId.Text = Nothing Or UpdateComment.Text = Nothing Then
            MsgBox("Please fill all the details!")
            Return
        End If

        Dim UpdateCommand As String = "UPDATE Contributors SET Comment ='" + UpdateComment.Text + "', Task='" + Task.Text + "' Where Id ='" + UContId.Text + "'"
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

        Dataload()

        'reseting textbox
        UContId.Text = Nothing
        UpdateComment.Text = Nothing

        UpdateComment.Enabled = False
        UpdateRow.Enabled = False
    End Sub

    Private Sub Unassigned_Click(sender As Object, e As EventArgs) Handles Unassigned.Click

        'adds data to the task contributors
        Dim UpdateCommand As String = "SELECT ID FROM Contributors WHERE PID='" + ProjectLayout.ProjectId.Text + "' AND TASK='Un-Assigned'"

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

        Dim i As Integer = data.Tables(0).Rows.Count

        While (i)
            For Each row In ContributorDataGrid.Rows
                If row.Cells(0).Value.ToString = data.Tables(0).Rows(i - 1)(0) Then
                    row.Selected = True
                End If
            Next
            i -= 1
        End While
    End Sub

    Private Sub ContributorDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ContributorDataGrid.CellContentClick
        'take the text from the cell and display in id textbox of update and delete
        With ContributorDataGrid
            ContId.Text = .Rows(.CurrentCell.RowIndex).Cells(1).Value.ToString
            UContId.Text = .Rows(.CurrentCell.RowIndex).Cells(0).Value.ToString
        End With
    End Sub

    Private Sub ContId_MouseLeave(sender As Object, e As EventArgs) Handles ContId.MouseLeave
        If ContId.Text.Length = 0 Then
            AddComment.Enabled = False
        End If
    End Sub

End Class