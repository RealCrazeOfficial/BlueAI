<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.lblPlaceholder = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblReceivedInput = New System.Windows.Forms.Label()
        Me.pbLoading = New System.Windows.Forms.ProgressBar()
        Me.btnChangelogs = New System.Windows.Forms.Button()
        Me.pbUpdateIcon = New System.Windows.Forms.PictureBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lblFeedbackSubmission = New System.Windows.Forms.Label()
        Me.tmrFeedbackSubmissionSuccess = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFeedbackSubmissionFailed = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbUpdateIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbInput
        '
        resources.ApplyResources(Me.tbInput, "tbInput")
        Me.tbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.tbInput.Name = "tbInput"
        '
        'lblPlaceholder
        '
        resources.ApplyResources(Me.lblPlaceholder, "lblPlaceholder")
        Me.lblPlaceholder.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblPlaceholder.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPlaceholder.Name = "lblPlaceholder"
        Me.lblPlaceholder.UseMnemonic = False
        '
        'lblResponse
        '
        resources.ApplyResources(Me.lblResponse, "lblResponse")
        Me.lblResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.UseMnemonic = False
        '
        'btnSend
        '
        resources.ApplyResources(Me.btnSend, "btnSend")
        Me.btnSend.Name = "btnSend"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lblReceivedInput
        '
        resources.ApplyResources(Me.lblReceivedInput, "lblReceivedInput")
        Me.lblReceivedInput.AutoEllipsis = True
        Me.lblReceivedInput.Name = "lblReceivedInput"
        Me.lblReceivedInput.UseMnemonic = False
        '
        'pbLoading
        '
        resources.ApplyResources(Me.pbLoading, "pbLoading")
        Me.pbLoading.MarqueeAnimationSpeed = 35
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Step = 1
        Me.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'btnChangelogs
        '
        resources.ApplyResources(Me.btnChangelogs, "btnChangelogs")
        Me.btnChangelogs.Name = "btnChangelogs"
        Me.btnChangelogs.UseVisualStyleBackColor = True
        '
        'pbUpdateIcon
        '
        resources.ApplyResources(Me.pbUpdateIcon, "pbUpdateIcon")
        Me.pbUpdateIcon.Image = Global.BlueAI.My.Resources.Resources.updateIcon
        Me.pbUpdateIcon.Name = "pbUpdateIcon"
        Me.pbUpdateIcon.TabStop = False
        '
        'btnSettings
        '
        resources.ApplyResources(Me.btnSettings, "btnSettings")
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'lblFeedbackSubmission
        '
        resources.ApplyResources(Me.lblFeedbackSubmission, "lblFeedbackSubmission")
        Me.lblFeedbackSubmission.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblFeedbackSubmission.Name = "lblFeedbackSubmission"
        '
        'tmrFeedbackSubmissionSuccess
        '
        Me.tmrFeedbackSubmissionSuccess.Interval = 2000
        '
        'tmrFeedbackSubmissionFailed
        '
        Me.tmrFeedbackSubmissionFailed.Interval = 10000
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.lblFeedbackSubmission)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.pbUpdateIcon)
        Me.Controls.Add(Me.btnChangelogs)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.lblReceivedInput)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.lblPlaceholder)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        CType(Me.pbUpdateIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents tbInput As TextBox
    Friend WithEvents lblPlaceholder As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents lblReceivedInput As Label
    Friend WithEvents pbLoading As ProgressBar
    Friend WithEvents btnChangelogs As Button
    Friend WithEvents pbUpdateIcon As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents lblFeedbackSubmission As Label
    Friend WithEvents tmrFeedbackSubmissionSuccess As Timer
    Friend WithEvents tmrFeedbackSubmissionFailed As Timer
End Class
