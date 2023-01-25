'Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Form1
    'establishing sql database connection
    'Public Dim sql As New SqlConnection With {
    '    .ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\COZMIC\DOCUMENTS\LOCALTESTDB.MDF"
    '}
    Public sql As New SqlConnection With {
        .ConnectionString = "data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Source\Repos\Cozmeh\Project-Manager\Resources\employeeDB.mdf"
        }

    Public command As SqlCommand = sql.CreateCommand()

    'sqladapter to handle the sql commands 
    Public sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = command
        }


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click


        sql.Open()

        'creating a sql command statement 
        command.CommandText = "SELECT * from Employees Where Id='" + UserIDBox.Text + "' and password = '" + PassBox.Text + "'"

        'creates a table with the required data
        Dim data As New DataSet()
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
        ElseIf designation = "A" Then
            'opens Admin form if designation is Admin(A)
            Form2_3.Show()
        ElseIf designation = "E" Then
            'opens employee form if designation is employee
            Form2_2.Show()
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