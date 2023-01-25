Imports System.Data.SqlClient
Public Class Form1


    '----------GLOBAL VARIABLES----------------------

    'establishing sql database connection
    Public sql As New SqlConnection With {
            .ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=D:\Coding\Langs\Visual Studio\ProjectManager\Resources\employeeDB.mdf"
    }
    'Public Dim sql As New SqlConnection With {
    '.ConnectionString = "data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Source\Repos\Cozmeh\Project-Manager\Resources\employeeDB.mdf"
    '}




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        'Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rohan\OneDrive\Desktop\Work\VB\login-vb.xlsx; Extended Properties=Excel 8.0;")
        'Dim cmd As New OleDbCommand("Select UId,Pass from [sheet1$] where UId='" & UserId.Text & "' and Pass='" & Password.Text & "'", conn)
        'conn.Open()
        'Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        'If sdr.Read() <> True Then
        '    MessageBox.Show("Please Check User Id and Password")
        '    Return
        'End If
        'Dim sql As New SqlConnection With {
        '.ConnectionString = "data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Source\Repos\Cozmeh\Project-Manager\Resources\employeeDB.mdf"
        '}

        'Dim cmd As New OleDbCommand("Select UId,Pass from [sheet1$] where UId='" & UserId.Text & "' and Pass='" & Password.Text & "'", conn)
        'conn.Open()
        'Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        'If sdr.Read() <> True Then
        '    MessageBox.Show("Please Check User Id and Password")
        '    Return
        'End If
        'Dim sql As New SqlConnection With {
        '.ConnectionString = "data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Source\Repos\Cozmeh\Project-Manager\Resources\employeeDB.mdf"
        '}


        'opening a connection to the database
        sql.Open()

        'creating a sql command statement 
        Dim command As SqlCommand = sql.CreateCommand()
        'creating a sql command statement 
        command.CommandText = "SELECT * from Employees Where Id='" + UserIDBox.Text + "' and password = '" + PassBox.Text + "'"


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
            Return
        End If

        'Rows(0)(2) collects the first row at column 3
        Dim designation As String = data.Tables(0).Rows(0)(2).ToString()

        If designation = "M" Then
            'opens manager form if designation is manager(M)
            Form2_1.Show()
            'MsgBox("manager")
        ElseIf designation = "A" Then
            'opens Admin form if designation is Admin(A)
            Form2_3.Show()
            'MsgBox("admin")
        ElseIf designation = "E" Then
            'opens employee form if designation is employee
            Form2_2.Show()
            'MsgBox("employee")
        End If


        'Message box shows the name of the user
        'MsgBox("Welcome " & data.Tables(0).Columns.IndexOf("Name"))
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