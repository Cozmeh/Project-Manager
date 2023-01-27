﻿Public Class EditProjectDetails
    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        Dim responce As String = MsgBox("Do you want to save Changes in " & ProjectName.Text, vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'update to database then close form
            EditProjectWizard.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim responce As String = MsgBox("Do you want to delete " & ProjectName.Text, vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'delete from database then close form
            EditProjectWizard.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim responce As String = MsgBox("Do you want to Cancel changes ", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'delete the row from database
            EditProjectWizard.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub EditProjectDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProjectName.Text = EditProjectWizard.ProjectName.Text
        DeadlineDuration.Value = EditProjectWizard.Deadline.Value
        PeopleCount.Value = EditProjectWizard.Count.Text
    End Sub
End Class