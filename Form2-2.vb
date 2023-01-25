Imports System.Data.SqlClient

'Employee Home Page

Public Class Form2_2
    Private Sub LogoutEmp_Click(sender As Object, e As EventArgs) Handles LogoutEmp.Click
        Form1.sql.Close()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'creating a sql command statement 
        Dim form2command As SqlCommand = Form1.sql.CreateCommand()
        form2command.CommandText = "SELECT * FROM Employees WHERE Id ='" + Form1.UserIDBox.Text + "'"

        'sqladapter to handle the sql commands 
        Dim form2sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = form2command
        }

        'creates a table with the required data
        Dim form2data As New DataSet()
        form2sqlAdapter.Fill(form2data)

        'fill the data in the required places
        EmpName.Text = form2data.Tables(0).Rows(0)(1).ToString()
        EmpId.Text = form2data.Tables(0).Rows(0)(0).ToString()
    End Sub
End Class