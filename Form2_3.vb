Imports System.Data.SqlClient

'Admin Home Page

Public Class Form2_3
    Private Sub LogoutAdmin_Click(sender As Object, e As EventArgs) Handles LogoutAdmin.Click
        Form1.sql.Close()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'creating a sql command statement 
        Dim command As SqlCommand = Form1.sql.CreateCommand()
        command.CommandText = "SELECT * FROM Employees WHERE Id ='" + Form1.UserIDBox.Text + "'"

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = command
        }
        'creates a table with the required data
        Dim form2data As New DataSet()
        sqlAdapter.Fill(form2data)

        'fill the data in the required places
        AdminName.Text = form2data.Tables(0).Rows(0)(1).ToString()
        AdminId.Text = form2data.Tables(0).Rows(0)(0).ToString()
    End Sub
End Class