Imports System.Data.SqlClient

'Admin Home Page

Public Class AdminHomePage
    Private Sub LogoutAdmin_Click(sender As Object, e As EventArgs) Handles LogoutAdmin.Click
        LoginForm.sql.Close()
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub AdminHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'creating a sql command statement 
        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = "SELECT * FROM Employees WHERE Id ='" + LoginForm.UserIDBox.Text + "'"

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

    Private Sub AdminHomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Do you want to Logout", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            LoginForm.sql.Close()
            LoginForm.Show()
        End If
    End Sub
End Class