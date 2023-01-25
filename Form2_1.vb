Imports System.Data.SqlClient

Public Class Form2_1
    Private Sub LogoutManager_Click(sender As Object, e As EventArgs) Handles LogoutManager.Click
        Form1.Show()
        Form1.sql.Close()
        Me.Close()
    End Sub

    Private Sub NewProject_Click(sender As Object, e As EventArgs) Handles NewProject.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManagerId.Text = Form1.UserIDBox.Text

        'creating a sql command statement 
        Dim form2command As SqlCommand = Form1.sql.CreateCommand()
        form2command.CommandText = "SELECT empName FROM Employees WHERE Id ='" + ManagerId.Text + "'"

        'sqladapter to handle the sql commands 
        Dim form2sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = form2command
        }
        'creates a table with the required data
        Dim form2data As New DataSet()
        form2sqlAdapter.Fill(form2data)

        Dim Name As String = form2data.Tables(0).Rows(0)(0).ToString()
        ManagerName.Text = Name

    End Sub

End Class