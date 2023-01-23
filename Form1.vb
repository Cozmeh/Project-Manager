'Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        'Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rohan\OneDrive\Desktop\Work\VB\login-vb.xlsx; Extended Properties=Excel 8.0;")
        'Dim cmd As New OleDbCommand("Select UId,Pass from [sheet1$] where UId='" & UserId.Text & "' and Pass='" & Password.Text & "'", conn)
        'conn.Open()
        'Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        'If sdr.Read() <> True Then
        '    MessageBox.Show("Please Check User Id and Password")
        '    Return
        'End If

        'establishing sql database connection
        Dim sql As New SqlConnection With {
            .ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\COZMIC\DOCUMENTS\LOCALTESTDB.MDF"
        }
        sql.Open()

        'creating a sql command statement 
        Dim command As SqlCommand = sql.CreateCommand()
        command.CommandText = "SELECT * from LoginData Where LoginID='" + UserIDBox.Text + "' and Password = '" + PassBox.Text + "'"

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = command
        }

        'creates a table with the required data
        Dim data As New DataSet()
        sqlAdapter.Fill(data)

        'If there is no row present i.e. wrong userId and password
        If data.Tables(0).Rows.Count <= 0 Then
            MsgBox("Check User Id or Password")
            Return
        End If

        'Rows(0)(3) collects the first row at column 4
        Dim designation As String = data.Tables(0).Rows(0)(3).ToString()

        If designation = "M" Then
            'opens manager form if designation is manager(M)
            Form2.Show()
        ElseIf designation = "A" Then
            'opens Admin form if designation is Admin(A)
            Form2_3.Show()
        Else
            'opens employee form if designation is employee
            Form2_2.Show()
        End If

        'Message box shows the name of the user
        MsgBox("Welcome " & data.Tables(0).Columns.IndexOf("Name"))
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