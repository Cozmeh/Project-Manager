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
        Form1.command.CommandText = "SELECT empName FROM Employees WHERE Id ='" + Form1.UserIDBox.Text + "'"
        Form1.sqlAdapter.SelectCommand = Form1.command
        Form1.sqlAdapter.Fill(Form1.data)
        Dim Name As String = Form1.data.Tables(0).Rows(0)(1).ToString()
        ManagerName.Text = Name

    End Sub


End Class