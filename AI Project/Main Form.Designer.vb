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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.lblPlaceholder = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblReceivedInput = New System.Windows.Forms.Label()
        Me.pbLoading = New System.Windows.Forms.ProgressBar()
        Me.lblVersionInfo = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
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
        'lblVersionInfo
        '
        Me.lblVersionInfo.ForeColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblVersionInfo, "lblVersionInfo")
        Me.lblVersionInfo.Name = "lblVersionInfo"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack
        resources.ApplyResources(Me.btnUpdate, "btnUpdate")
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblVersionInfo)
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
    Friend WithEvents lblVersionInfo As Label
    Friend WithEvents btnUpdate As Button
End Class
