Imports System.Data.Common
Imports System.Data.SqlClient

Public Class AdminHomePage
    'logout user
    Private Sub LogoutAdmin_Click(sender As Object, e As EventArgs) Handles LogoutAdmin.Click
        Me.Close()
    End Sub

    'when page loads
    Private Sub AdminHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Upd_Name.Enabled = False
        Upd_Designation.Enabled = False
        Upd_Password.Enabled = False
        UpdateRow.Enabled = False

        'creating a sql command statement 
        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = "SELECT * FROM Employees WHERE Id ='" + LoginForm.UserIDBox.Text + "'"

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = command
        }
        'creates a table with the required data
        Dim data As New DataSet()
        sqlAdapter.Fill(data)

        'fill the data in the required places
        AdminName.Text = data.Tables(0).Rows(0)(1).ToString()
        AdminId.Text = data.Tables(0).Rows(0)(0).ToString()

        DataLoader()
    End Sub

    Private Sub AdminHomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Do you want to Logout?", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            LoginForm.sql.Close()
            LoginForm.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub AddRow_Click(sender As Object, e As EventArgs) Handles AddRow.Click

        If Add_ID.Text = Nothing Or Add_EmpName.Text = Nothing Or Add_Designtion.Text = Nothing Or Add_Password.Text = Nothing Then
            MsgBox("Please fill all the details!")
            Return
        End If

        'designation validation
        'confirmation
        Dim responce As String = vbNo
        If Add_Designtion.Text = "A" Then
            responce = MsgBox("Add '" & Add_ID.Text & "' to the Company", vbYesNo, "Adding new Admin?")
        ElseIf Add_Designtion.Text = "M" Then
            responce = MsgBox("Add '" & Add_ID.Text & "' to the Company", vbYesNo, "Add Manager?")
        ElseIf Add_Designtion.Text = "E" Then
            responce = MsgBox("Add '" & Add_ID.Text & "' to the Company", vbYesNo, "Add Employee?")
        Else
            MsgBox("Invalid Designation!")
            Return
        End If

        If responce = vbNo Then
            Return
        End If

        For Each row In AdminDataGrid.Rows
            If Add_ID.Text = row.Cells(0).Value.ToString Then
                MsgBox("Employee with id '" + Add_ID.Text + "' already exist")
                Return
            End If
        Next

        'adds data to the table
        Dim AddCommand As String = "INSERT INTO EMPLOYEES (Id,empName,Designation,password) VALUES ('" + Add_ID.Text + "','" + Add_EmpName.Text + "','" + Add_Designtion.Text + "','" + Add_Password.Text + "')"

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
        Add_ID.Text = Nothing
        Add_EmpName.Text = Nothing
        Add_Designtion.Text = Nothing
        Add_Password.Text = Nothing
    End Sub

    Private Sub DataLoader()

        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT * FROM Employees WHERE Id <> '" & AdminId.Text & "'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        AdminDataGrid.DataSource = Consoledata.Tables(0)
    End Sub

    Private Sub DeleteRow_Click_1(sender As Object, e As EventArgs) Handles DeleteRow.Click
        If Del_ID.Text = Nothing Then
            MsgBox("Please mention the UserID ")
            Return
        End If

        'conformation
        Dim responce As String = MsgBox("Remove access to the Project Management System for '" & Del_ID.Text & "'", vbYesNo, "Remove User?")
        If responce = vbNo Then
            Return
        End If

        For Each row In AdminDataGrid.Rows
            If Del_ID.Text = row.Cells(0).Value.ToString Then
                'creating a sql command statement 
                Dim DelCommand As SqlCommand = LoginForm.sql.CreateCommand()
                DelCommand.CommandText = "DELETE FROM Employees WHERE Id ='" + Del_ID.Text + "'"

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
        MsgBox("User not found!")
    End Sub

    Private Sub UpdateRow_Click_1(sender As Object, e As EventArgs) Handles UpdateRow.Click

        If Upd_Designation.Text = "E" Or Upd_Designation.Text = "M" Then
            'conformation
            Dim responce As String = MsgBox("Update Employee?", vbYesNo, "Update " & Upd_ID.Text & " in the database")
            If responce = vbNo Then
                Return
            End If
        Else
            MsgBox("Invalid Designation!")
            Return
        End If

        If Upd_ID.Text = Nothing Or Upd_Name.Text = Nothing Or Upd_Designation.Text = Nothing Or Upd_Password.Text = Nothing Then
            MsgBox("Please fill all the details!")
            Return
        End If

        Dim UpdateCommand As String = "UPDATE Employees SET empName ='" + Upd_Name.Text + "',Designation ='" + Upd_Designation.Text + "',password='" + Upd_Password.Text + "' Where Id ='" + Upd_ID.Text + "'"
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
        Upd_Name.Text = Nothing
        Upd_Designation.Text = Nothing
        Upd_Password.Text = Nothing
        Upd_ID.Text = Nothing

        Upd_Name.Enabled = False
        Upd_Designation.Enabled = False
        Upd_Password.Enabled = False
        UpdateRow.Enabled = False
    End Sub

    Private Sub GetBtn_Click_1(sender As Object, e As EventArgs) Handles GetBtn.Click
        If Upd_ID.Text = Nothing Then
            MsgBox("Please mention correct UserID!")
            Return
        End If

        For Each row In AdminDataGrid.Rows
            If Upd_ID.Text = row.Cells(0).Value.ToString Then
                Upd_Name.Text = row.Cells(1).Value.ToString
                Upd_Designation.Text = row.Cells(2).Value.ToString
                Upd_Password.Text = row.Cells(3).Value.ToString

                Upd_Name.Enabled = True
                Upd_Designation.Enabled = True
                Upd_Password.Enabled = True
                UpdateRow.Enabled = True
                Return
            End If
        Next

        MsgBox("User not found!")
    End Sub

    Private Sub AdminDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminDataGrid.CellContentClick
        'take the text from the cell and display in idtextbox of update and delete
        With AdminDataGrid
            Upd_ID.Text = .Rows(.CurrentCell.RowIndex).Cells(0).Value.ToString
            Del_ID.Text = .Rows(.CurrentCell.RowIndex).Cells(0).Value.ToString
        End With
    End Sub
End Class