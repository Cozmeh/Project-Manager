'Imports Microsoft.VisualBasic.ApplicationServices
'Imports System.Data.OleDb

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
        'Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rohan\OneDrive\Desktop\Work\VB\login-vb.xlsx; Extended Properties=Excel 8.0;")
        'Dim cmd As New OleDbCommand("Select Name from [sheet1$] where UId='" & Form1.UserIDBox.Text & "'", conn)
        'conn.Open()
        'Dim sdr As OleDbDataReader = cmd.ExecuteReader(Name)
        'ManagerName.Text = sdr.Item(Name)


        ManagerId.Text = Form1.UserIDBox.Text


    End Sub

End Class