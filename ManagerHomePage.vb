Imports System.Data.SqlClient

'Manager Home Page

Public Class ManagerHomePage

    Public pid As String = "new"

    Private Sub LogoutManager_Click(sender As Object, e As EventArgs) Handles LogoutManager.Click
        LoginForm.sql.Close()
        Me.Close()
    End Sub

    Private Sub NewProject_Click(sender As Object, e As EventArgs) Handles NewProject.Click
        NewProjectWizard.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ManagerName.Text = form2data.Tables(0).Rows(0)(1).ToString()
        ManagerId.Text = form2data.Tables(0).Rows(0)(0).ToString()

        'fetch all the projects under current manager
        DataLoader()
    End Sub

    Private Sub DataLoader()

        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT PId, Title, Deadline,People FROM Projects WHERE ManagerId = '" & ManagerId.Text & "'"
        'Consolecommand.CommandText = "SELECT * FROM Employees WHERE designation <> 'A'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        ManagerDataGrid.DataSource = Consoledata.Tables(0)
    End Sub

    Private Sub ManagerHomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Do you want to Logout?", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            LoginForm.sql.Close()
            LoginForm.Show()
        ElseIf responce = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ManagerDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ManagerDataGrid.CellContentClick
        'take the text from the cell and display in idtextbox of update and delete
        pid = ManagerDataGrid.Rows(ManagerDataGrid.CurrentCell.RowIndex).Cells(0).Value.ToString
        EditProjectWizard.Show()
        Me.Enabled = False
    End Sub
End Class