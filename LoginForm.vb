Imports System.Data.SqlClient
Public Class LoginForm

    '----------GLOBAL VARIABLES----------------------

    'establishing sql database connection
    Public sql As New SqlConnection With {
            .ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=D:\Coding\Projects\Visual Studio\ProjectManager\Resources\employeeDB.mdf"
    }
    'Public sql As New SqlConnection With {
    '.ConnectionString = "data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Source\Repos\Cozmeh\Project-Manager\Resources\employeeDB.mdf"
    '}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

        'opening a connection to the database
        sql.Open()

        'creating a sql command statement 
        Dim command As SqlCommand = sql.CreateCommand()
        'creating a sql command statement 
        command.CommandText = "SELECT * from Employees Where Id= '" + UserIDBox.Text + "' and password = '" + PassBox.Text + "'"

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = command
        }

        'creates a table with the required data
        Dim data As New DataSet()


        'filling the dataset with data
        sqlAdapter.Fill(data)

        'If there is no row present i.e. wrong userId and password
        If data.Tables(0).Rows.Count <= 0 Then
            MsgBox("Check User Id or Password")
            sql.Close()
            Return
        End If

        'Rows(0)(2) collects the first row at column 3
        Dim designation As String = data.Tables(0).Rows(0)(2).ToString()

        If designation = "M" Then
            'opens manager form if designation is manager(M)
            ManagerHomePage.Show()
        ElseIf designation = "A" Then
            'opens Admin form if designation is Admin(A)
            AdminHomePage.Show()
        ElseIf designation = "E" Then
            'opens employee form if designation is employee
            EmployeeHomePage.Show()
        End If

        'hide the current LoginForm
        Me.Hide()

        'Empties both the text box in the form  on load
        If UserIDBox.Text <> "" Then
            UserIDBox.Text = ""
        End If
        If PassBox.Text <> "" Then
            PassBox.Text = ""
        End If
    End Sub


End Class