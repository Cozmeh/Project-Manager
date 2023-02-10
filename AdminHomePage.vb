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
        Else

            'if designation is employee(E) or manager(M)
            If Add_Designtion.Text = "E" Or Add_Designtion.Text = "M" Then

                'conformation
                Dim responce As String = MsgBox("Add '" & Add_ID.Text & "' to the Company", vbYesNo, "Add Employee?")
                If responce = vbYes Then
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
                End If
            Else
                MsgBox("Invalid Designation!")
            End If
        End If
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
        Else
            'conformation
            Dim responce As String = MsgBox("Remove access to the Project Management System for '" & Del_ID.Text & "'", vbYesNo, "Remove User?")
            If responce = vbYes Then
                Dim DelCommand As String = "DELETE FROM Employees WHERE Id ='" + Del_ID.Text + "'"

                'creating a sql command statement 
                Dim command As SqlCommand = LoginForm.sql.CreateCommand()
                command.CommandText = "select * from Employees where Id ='" + Del_ID.Text + "'"

                'sqladapter to handle the sql commands 
                Dim sqlAdapter As New SqlDataAdapter With {
                .SelectCommand = command
                }

                'creates a table with the required data
                Dim data As New DataSet()
                sqlAdapter.Fill(data)

                If (data.Tables(0).Rows.Count) > 0 Then
                    command.CommandText = DelCommand
                    sqlAdapter.SelectCommand = command
                    sqlAdapter.Fill(data)
                    DataLoader()
                Else
                    MsgBox("User not found!")
                End If
                'reseting textbox
                Del_ID.Text = Nothing
            End If
        End If
    End Sub

    Private Sub UpdateRow_Click_1(sender As Object, e As EventArgs) Handles UpdateRow.Click
        If Upd_Name.Text = Nothing Or Upd_Designation.Text = Nothing Or Upd_Password.Text = Nothing Then
            MsgBox("Please fill all the details!")
        Else
            If Upd_Designation.Text = "E" Or Upd_Designation.Text = "M" Then

                'conformation
                Dim responce As String = MsgBox("Update Employee?", vbYesNo, "Update " & Upd_ID.Text & " in the database")
                If responce = vbYes Then

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
                End If
            Else
                MsgBox("Invalid Designation!")
            End If
        End If
    End Sub

    Private Sub GetBtn_Click_1(sender As Object, e As EventArgs) Handles GetBtn.Click
        If Upd_ID.Text = Nothing Then
            MsgBox("Please mention the UserID!")
        Else
            'creating a sql command statement 
            Dim command As SqlCommand = LoginForm.sql.CreateCommand()
            command.CommandText = "select empName,Designation,password from Employees where Id ='" + Upd_ID.Text + "'"

            'sqladapter to handle the sql commands 
            Dim sqlAdapter As New SqlDataAdapter With {
                .SelectCommand = command
            }
            'creates a table with the required data
            Dim data As New DataSet()
            sqlAdapter.Fill(data)

            If (data.Tables(0).Rows.Count) > 0 Then
                Upd_Name.Text = data.Tables(0).Rows(0)(0).ToString
                Upd_Designation.Text = data.Tables(0).Rows(0)(1).ToString
                Upd_Password.Text = data.Tables(0).Rows(0)(2).ToString

                Upd_Name.Enabled = True
                Upd_Designation.Enabled = True
                Upd_Password.Enabled = True
                UpdateRow.Enabled = True
            Else
                MsgBox("User not found!")
            End If
        End If
    End Sub

    Private Sub AdminDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminDataGrid.CellContentClick
        'take the text from the cell and display in idtextbox of update and delete
        With AdminDataGrid
            Upd_ID.Text = .Rows(.CurrentCell.RowIndex).Cells(0).Value.ToString
            Del_ID.Text = .Rows(.CurrentCell.RowIndex).Cells(0).Value.ToString
        End With
    End Sub
End Class