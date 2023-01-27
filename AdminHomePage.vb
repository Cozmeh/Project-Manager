Imports System.Data.SqlClient

'Admin Home Page

Public Class AdminHomePage
    Private Sub LogoutAdmin_Click(sender As Object, e As EventArgs) Handles LogoutAdmin.Click
        LoginForm.sql.Close()
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub AdminHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ElseIf responce = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub AddRow_Click(sender As Object, e As EventArgs) Handles AddRow.Click

        If Add_ID.Text = Nothing Or Add_EmpName.Text = Nothing Or Add_Designtion.Text = Nothing Or Add_Password.Text = Nothing Then
            MsgBox("Please fill all the details!")
        Else

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

            Add_ID.Text = Nothing
            Add_EmpName.Text = Nothing
            Add_Designtion.Text = Nothing
            Add_Password.Text = Nothing

        End If



    End Sub


    Private Sub DataLoader()
        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT * FROM Employees WHERE designation <> 'A'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }
        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        AdminDataGrid.DataSource = Consoledata.Tables(0)
    End Sub
End Class