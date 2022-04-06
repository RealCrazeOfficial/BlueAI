<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWhatsNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWhatsNew))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblVersionInfo = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblChangelogTitle = New System.Windows.Forms.Label()
        Me.lblChangelog = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(397, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblVersionInfo
        '
        Me.lblVersionInfo.AutoSize = True
        Me.lblVersionInfo.ForeColor = System.Drawing.Color.Red
        Me.lblVersionInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVersionInfo.Location = New System.Drawing.Point(279, 199)
        Me.lblVersionInfo.Name = "lblVersionInfo"
        Me.lblVersionInfo.Size = New System.Drawing.Size(111, 13)
        Me.lblVersionInfo.TabIndex = 7
        Me.lblVersionInfo.Text = "An update is available"
        Me.lblVersionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnUpdate.Location = New System.Drawing.Point(396, 194)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'lblChangelogTitle
        '
        Me.lblChangelogTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblChangelogTitle.Name = "lblChangelogTitle"
        Me.lblChangelogTitle.Size = New System.Drawing.Size(261, 13)
        Me.lblChangelogTitle.TabIndex = 10
        Me.lblChangelogTitle.Text = "ERROR"
        Me.lblChangelogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblChangelogTitle.UseMnemonic = False
        '
        'lblChangelog
        '
        Me.lblChangelog.Location = New System.Drawing.Point(12, 34)
        Me.lblChangelog.Name = "lblChangelog"
        Me.lblChangelog.Size = New System.Drawing.Size(261, 215)
        Me.lblChangelog.TabIndex = 11
        Me.lblChangelog.Text = resources.GetString("lblChangelog.Text")
        '
        'frmWhatsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.lblChangelog)
        Me.Controls.Add(Me.lblChangelogTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblVersionInfo)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmWhatsNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AI System Changelogs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents lblVersionInfo As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblChangelogTitle As Label
    Friend WithEvents lblChangelog As Label
End Class
