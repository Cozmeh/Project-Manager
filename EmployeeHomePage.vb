Imports System.Data.SqlClient

Public Class EmployeeHomePage

    Public id, title, task, pid, status, complete, comment As String

    Private Sub LogoutEmp_Click_1(sender As Object, e As EventArgs) Handles LogoutEmp.Click
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

    Public Sub DataLoader()
        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT Id, PId, Title, Task, ManagerId, Complete, Status, Comment FROM EmpTask WHERE EmpID = '" + EmpId.Text + "'"

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

    Private Sub TaskDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TaskDataGrid.CellContentClick
        'take the text from the cell and display in id textbox of update and delete
        With TaskDataGrid
            id = .Rows(.CurrentCell.RowIndex).Cells(0).Value.ToString
            pid = .Rows(.CurrentCell.RowIndex).Cells(1).Value.ToString
            title = .Rows(.CurrentCell.RowIndex).Cells(2).Value.ToString
            task = .Rows(.CurrentCell.RowIndex).Cells(3).Value.ToString
            complete = .Rows(.CurrentCell.RowIndex).Cells(5).Value.ToString
            status = .Rows(.CurrentCell.RowIndex).Cells(6).Value.ToString.Trim
            comment = .Rows(.CurrentCell.RowIndex).Cells(7).Value.ToString.Trim
        End With
        TaskUpdate.Show()
        Me.Enabled = False
    End Sub
End Class