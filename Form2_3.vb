Imports System.Data.SqlClient

Public Class Form2_3
    Private Sub LogoutAdmin_Click(sender As Object, e As EventArgs) Handles LogoutAdmin.Click
        Form1.Show()
        Form1.sql.Close()
        Me.Close()
    End Sub

    Private Sub Form2_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminId.Text = Form1.UserIDBox.Text

        'creating a sql command statement 
        Dim command As SqlCommand = Form1.sql.CreateCommand()
        command.CommandText = "SELECT empName FROM Employees WHERE Id ='" + AdminId.Text + "'"

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = command
        }
        'creates a table with the required data
        Dim form2data As New DataSet()
        sqlAdapter.Fill(form2data)

        Dim Name As String = form2data.Tables(0).Rows(0)(0).ToString()
        AdminName.Text = Name
    End Sub
End Class