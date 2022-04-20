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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbFeedbackSubmission = New System.Windows.Forms.CheckBox()
        Me.ttFeedbackSubmission = New System.Windows.Forms.ToolTip(Me.components)
        Me.msSettings = New System.Windows.Forms.MenuStrip()
        Me.tsGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPersonalize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttInterfaceTheme = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbTheme = New System.Windows.Forms.ComboBox()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.msSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(397, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cbFeedbackSubmission
        '
        Me.cbFeedbackSubmission.Location = New System.Drawing.Point(143, 11)
        Me.cbFeedbackSubmission.Name = "cbFeedbackSubmission"
        Me.cbFeedbackSubmission.Size = New System.Drawing.Size(200, 17)
        Me.cbFeedbackSubmission.TabIndex = 1
        Me.cbFeedbackSubmission.Text = "Automatically Submit Feedback"
        Me.ttFeedbackSubmission.SetToolTip(Me.cbFeedbackSubmission, "When the A.I. doesn't know the answer to your question, it'll automatically be se" &
        "nt for review so that the A.I. can gain knowledge of the question.")
        Me.cbFeedbackSubmission.UseVisualStyleBackColor = True
        '
        'ttFeedbackSubmission
        '
        Me.ttFeedbackSubmission.AutoPopDelay = 10000
        Me.ttFeedbackSubmission.InitialDelay = 500
        Me.ttFeedbackSubmission.ReshowDelay = 100
        Me.ttFeedbackSubmission.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttFeedbackSubmission.ToolTipTitle = "Automatically Submit Feedback"
        '
        'msSettings
        '
        Me.msSettings.AutoSize = False
        Me.msSettings.BackColor = System.Drawing.Color.White
        Me.msSettings.Dock = System.Windows.Forms.DockStyle.Left
        Me.msSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsGeneral, Me.tsPersonalize})
        Me.msSettings.Location = New System.Drawing.Point(0, 0)
        Me.msSettings.Name = "msSettings"
        Me.msSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msSettings.Size = New System.Drawing.Size(126, 245)
        Me.msSettings.TabIndex = 2
        Me.msSettings.Text = "Settings"
        '
        'tsGeneral
        '
        Me.tsGeneral.AutoSize = False
        Me.tsGeneral.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tsGeneral.Checked = True
        Me.tsGeneral.CheckOnClick = True
        Me.tsGeneral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsGeneral.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsGeneral.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.tsGeneral.Name = "tsGeneral"
        Me.tsGeneral.ShortcutKeyDisplayString = ""
        Me.tsGeneral.Size = New System.Drawing.Size(119, 22)
        Me.tsGeneral.Text = "&General"
        '
        'tsPersonalize
        '
        Me.tsPersonalize.AutoSize = False
        Me.tsPersonalize.CheckOnClick = True
        Me.tsPersonalize.Name = "tsPersonalize"
        Me.tsPersonalize.Size = New System.Drawing.Size(119, 22)
        Me.tsPersonalize.Text = "&Personalize"
        '
        'ttInterfaceTheme
        '
        Me.ttInterfaceTheme.AutoPopDelay = 10000
        Me.ttInterfaceTheme.InitialDelay = 500
        Me.ttInterfaceTheme.ReshowDelay = 100
        Me.ttInterfaceTheme.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttInterfaceTheme.ToolTipTitle = "Interface Theme"
        '
        'cbTheme
        '
        Me.cbTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTheme.FormattingEnabled = True
        Me.cbTheme.Items.AddRange(New Object() {"Classic", "Dark"})
        Me.cbTheme.Location = New System.Drawing.Point(140, 29)
        Me.cbTheme.Name = "cbTheme"
        Me.cbTheme.Size = New System.Drawing.Size(121, 21)
        Me.cbTheme.TabIndex = 4
        Me.ttInterfaceTheme.SetToolTip(Me.cbTheme, "Changes the visual appearance of BlueAI interfaces to your preferred theme.")
        Me.cbTheme.Visible = False
        '
        'lblTheme
        '
        Me.lblTheme.Location = New System.Drawing.Point(140, 11)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(121, 15)
        Me.lblTheme.TabIndex = 5
        Me.lblTheme.Text = "Interface Theme"
        Me.lblTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttInterfaceTheme.SetToolTip(Me.lblTheme, "Changes the visual appearance of BlueAI interfaces to your preferred theme.")
        Me.lblTheme.Visible = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 245)
        Me.Controls.Add(Me.lblTheme)
        Me.Controls.Add(Me.cbTheme)
        Me.Controls.Add(Me.msSettings)
        Me.Controls.Add(Me.cbFeedbackSubmission)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlueAI Settings"
        Me.msSettings.ResumeLayout(False)
        Me.msSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents cbFeedbackSubmission As CheckBox
    Friend WithEvents ttFeedbackSubmission As ToolTip
    Friend WithEvents msSettings As MenuStrip
    Friend WithEvents tsGeneral As ToolStripMenuItem
    Friend WithEvents tsPersonalize As ToolStripMenuItem
    Friend WithEvents ttInterfaceTheme As ToolTip
    Friend WithEvents cbTheme As ComboBox
    Friend WithEvents lblTheme As Label
End Class
