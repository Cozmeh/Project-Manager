Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If UserId.Text <> "asd" Then
            MessageBox.Show("Please Enter valid User Id")
            Return
        End If

        If Password.Text <> "asd" Then
            MessageBox.Show("Please Enter valid Password")
            Return
        End If

        Form2.Show()
        Me.Hide()
    End Sub
End Class
