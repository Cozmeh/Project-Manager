Public Class Form4

    Private Sub Form4_closeing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form2_1.Enabled = True
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Filling all the fields
        Dim pId As New Random()
        ProjectId.Text = pId.Next(100000, 999999)
        ProjectName.Text = Form3.ProjectName.Text
        Deadline.Value = Form3.DeadlineDuration.Value
        Count.Text = Form3.PeopleCount.Value
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Form2_1.Enabled = True
        Me.Close()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim responce As String = MsgBox("Do you want to delete " & ProjectName.Text, vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'delete the row from database
            Me.Close()

        End If
    End Sub
End Class