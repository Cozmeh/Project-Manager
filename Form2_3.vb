Public Class Form2_3
    Private Sub LogoutAdmin_Click(sender As Object, e As EventArgs) Handles LogoutAdmin.Click
        Form1.Show()
        Form1.sql.Close()
        Me.Close()
    End Sub
End Class