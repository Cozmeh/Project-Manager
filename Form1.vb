Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rohan\OneDrive\Desktop\Work\VB\login-vb.xlsx; Extended Properties=Excel 8.0;")
        Dim cmd As New OleDbCommand("Select UId,Pass from [sheet1$] where UId='" & UserId.Text & "' and Pass='" & Password.Text & "'", conn)
        conn.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If sdr.Read() <> True Then
            MessageBox.Show("Please Check User Id and Password")
            Return
        End If

        Form2.Show()

        If UserId.Text <> "" Then
            UserId.Text = ""
        End If
        If Password.Text <> "" Then
            Password.Text = ""
        End If

        Me.Hide()
    End Sub
End Class