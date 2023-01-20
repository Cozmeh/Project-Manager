<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackToManHome = New System.Windows.Forms.PictureBox()
        CType(Me.BackToManHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackToManHome
        '
        Me.BackToManHome.Image = Global.ProjectManager.My.Resources.Resources.back
        Me.BackToManHome.Location = New System.Drawing.Point(12, 12)
        Me.BackToManHome.Name = "BackToManHome"
        Me.BackToManHome.Size = New System.Drawing.Size(38, 40)
        Me.BackToManHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackToManHome.TabIndex = 0
        Me.BackToManHome.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackToManHome)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.BackToManHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackToManHome As PictureBox
End Class
