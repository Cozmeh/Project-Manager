Imports System.Data.SqlClient

Public Class EmployeeHomePage
    Private Sub LogoutEmp_Click(sender As Object, e As EventArgs) Handles LogoutEmp.Click
        Me.Close()
    End Sub

    Private Sub EmployeeHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'creating a sql command statement 
        Dim form2command As SqlCommand = LoginForm.sql.CreateCommand()
        form2command.CommandText = "SELECT * FROM Employees WHERE Id ='" + LoginForm.UserIDBox.Text + "'"

        'sqladapter to handle the sql commands 
        Dim form2sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = form2command
        }

        'creates a table with the required data
        Dim form2data As New DataSet()
        form2sqlAdapter.Fill(form2data)

        'fill the data in the required places
        EmpName.Text = form2data.Tables(0).Rows(0)(1).ToString()
        EmpId.Text = form2data.Tables(0).Rows(0)(0).ToString()

        DataLoader()
    End Sub

    Private Sub EmployeeHomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Do you want to Logout?", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            LoginForm.sql.Close()
            LoginForm.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub DataLoader()
        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT EmpID, Task, PID, Status FROM Contributors WHERE EmpID = '" + LoginForm.UserIDBox.Text + "'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        'shows the table if the employee is assigned to any task
        If (Consoledata.Tables(0).Rows.Count) > 0 Then
            TaskDataGrid.Visible = True
            TaskDataGrid.DataSource = Consoledata.Tables(0)
        End If
    End Sub
End Class