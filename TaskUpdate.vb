Imports System.Data.SqlClient

Public Class TaskUpdate

    Public state As Boolean

    Private Sub Task_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taskId.Text = EmployeeHomePage.id
        Pid.Text = EmployeeHomePage.pid
        title.Text = EmployeeHomePage.title
        Taskname.Text = EmployeeHomePage.task
        comments.Text = EmployeeHomePage.comment
        If EmployeeHomePage.status <> "Pending" Then
            Completed.Checked = True
        End If

        If Taskname.Text = "Un-Assigned" Then
            Completed.Enabled = False
        End If

        state = Completed.CheckState
    End Sub

    Private Sub Task_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        EmployeeHomePage.Enabled = True
        EmployeeHomePage.Show()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        If state <> Completed.CheckState Then
            If MsgBox("Do you want to cancel the changes done?", vbYesNo, "Are you sure?") = vbYes Then
                Me.Close()
            End If
        Else
            If MsgBox("Do you want to close the window?", vbYesNo, "Are you sure?") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If state <> Completed.CheckState Then
            If MsgBox("Do you want to Update the changes done?", vbYesNo, "Are you sure?") = vbNo Then
                Me.Close()
            End If
        Else
            MsgBox("No updates were performed")
            Return
        End If

        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        If Completed.Checked = True Then
            Consolecommand.CommandText = "UPDATE Contributors SET Complete = '" + Today.ToString("yyyy-MM-dd") + "', Status ='Completed' WHERE Id= '" + taskId.Text + "'"
        ElseIf Completed.Checked = False Then
            Consolecommand.CommandText = "UPDATE Contributors SET Complete = NULL, Status ='Pending' WHERE Id= '" + taskId.Text + "'"
        End If

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        EmployeeHomePage.DataLoader()
        EmployeeHomePage.Update()
        EmployeeHomePage.Refresh()
        Me.Close()
    End Sub
End Class