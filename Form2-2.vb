Public Class Form2_2
    Private Sub LogoutEmp_Click(sender As Object, e As EventArgs) Handles LogoutEmp.Click
        Form1.Show()
        Form1.sql.Close()
        Me.Close()
    End Sub
End Class