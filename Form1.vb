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
        'Form2.Show()
        'If UserId.Text <> "" Then
        '    UserId.Text = ""
        'End If
        'If Password.Text <> "" Then
        '    Password.Text = ""
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

        Dim data As New DataSet()
        sqlAdapter.Fill(data)

        If data.Tables(0).Rows.Count <= 0 Then
            MsgBox("Check User Id or Password")
            Return
        End If

        MsgBox("Welcome " & UserIDBox.Text)
        Form2.Show()
        Me.Hide()

    End Sub

End Class