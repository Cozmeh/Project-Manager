Imports System.Data.SqlClient

Public Class Form2_2
    Private Sub LogoutEmp_Click(sender As Object, e As EventArgs) Handles LogoutEmp.Click
        Form1.Show()
        Form1.sql.Close()
        Me.Close()
    End Sub

    Private Sub Form2_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpId.Text = Form1.UserIDBox.Text

        'creating a sql command statement 
        Dim form2command As SqlCommand = Form1.sql.CreateCommand()
        form2command.CommandText = "SELECT empName FROM Employees WHERE Id ='" + EmpId.Text + "'"

        'sqladapter to handle the sql commands 
        Dim form2sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = form2command
        }
        'creates a table with the required data
        Dim form2data As New DataSet()
        form2sqlAdapter.Fill(form2data)

        Dim Name As String = form2data.Tables(0).Rows(0)(0).ToString()
        EmpName.Text = Name
    End Sub
End Class