Public Class EditProjectDetails

    Private Sub EditProjectDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("You want to close this window ", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            EditProjectWizard.Enabled = True
            EditProjectWizard.Show()
        End If
    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        Dim responce As String = MsgBox("Do you want to save Changes in " & ProjectName.Text, vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'update to database then close form
            Me.Close()
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim responce As String = MsgBox("Do you want to delete " & ProjectName.Text, vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'delete from database then close form
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim responce As String = MsgBox("Do you want to Cancel changes ", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'doesnt do any changes
            Me.Close()
        End If
    End Sub

    Private Sub EditProjectDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProjectName.Text = EditProjectWizard.ProjectName.Text
        DeadlineDuration.Value = EditProjectWizard.Deadline.Value
        PeopleCount.Value = EditProjectWizard.Count.Text
    End Sub
End Class