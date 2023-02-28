Imports System.Data.SqlClient

Public Class TaskUpdate

    Public state As Boolean

    Private Sub TaskUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taskId.Text = EmployeeHomePage.id
        Pid.Text = EmployeeHomePage.pid
        title.Text = EmployeeHomePage.title
        task.Text = EmployeeHomePage.task
        If EmployeeHomePage.status <> "Pending" Then
            Completed.Checked = True
        End If
        state = Completed.CheckState
    End Sub

    Private Sub TaskUpdate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
        Consolecommand.CommandText = "UPDATE Contributors SET Complete = '" + Today.ToString("yyyy-MM-dd") + "', Status ='Completed' WHERE EmpID = '" + EmployeeHomePage.EmpId.Text.ToString + "' AND Task = '" + EmployeeHomePage.task.ToString + "' AND PID = '" + EmployeeHomePage.pid.ToString + "'"

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