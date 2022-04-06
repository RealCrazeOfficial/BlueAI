<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbFeedbackSubmission = New System.Windows.Forms.CheckBox()
        Me.ttFeedbackSubmission = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(397, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cbFeedbackSubmission
        '
        Me.cbFeedbackSubmission.Location = New System.Drawing.Point(12, 12)
        Me.cbFeedbackSubmission.Name = "cbFeedbackSubmission"
        Me.cbFeedbackSubmission.Size = New System.Drawing.Size(460, 17)
        Me.cbFeedbackSubmission.TabIndex = 1
        Me.cbFeedbackSubmission.Text = "Automatically Submit Feedback"
        Me.ttFeedbackSubmission.SetToolTip(Me.cbFeedbackSubmission, "When the A.I. doesn't know the answer to your question, it'll automatically be se" &
        "nt for review so that the A.I. can gain knowledge of the question.")
        Me.cbFeedbackSubmission.UseVisualStyleBackColor = True
        '
        'ttFeedbackSubmission
        '
        Me.ttFeedbackSubmission.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttFeedbackSubmission.ToolTipTitle = "Automatically Submit Feedback"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 245)
        Me.Controls.Add(Me.cbFeedbackSubmission)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents cbFeedbackSubmission As CheckBox
    Friend WithEvents ttFeedbackSubmission As ToolTip
End Class
