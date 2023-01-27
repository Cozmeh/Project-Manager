Imports System.Data.SqlClient

'Manager Home Page

Public Class Form2_1
    Private Sub LogoutManager_Click(sender As Object, e As EventArgs) Handles LogoutManager.Click
        Form1.sql.Close()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub NewProject_Click(sender As Object, e As EventArgs) Handles NewProject.Click
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ManagerName.Text = form2data.Tables(0).Rows(0)(1).ToString()
        ManagerId.Text = form2data.Tables(0).Rows(0)(0).ToString()
    End Sub

    Private Sub Form2_1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Do you want to Logout", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            Form1.sql.Close()
            Form1.Show()
        End If
    End Sub
End Class