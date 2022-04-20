Public Class frmSettings

    Private guiColor As Color
    Private labelBackColor As Color
    Private labelResponseBackColor As Color
    Private labelForeColor As Color
    Private buttonBackColor As Color
    Private buttonBorderColor As Color
    Private menuStripBackColor As Color

    Function themeChange()

        If My.Settings.selectedTheme = "Classic" Then

            ' Global

            guiColor = Color.FromName("Control")
            labelBackColor = Color.FromName("Control")
            labelForeColor = Color.FromName("ControlText")
            buttonBackColor = Color.FromArgb(225, 225, 225)
            buttonBorderColor = Color.FromArgb(173, 173, 173)

            ' Main Interface

            labelResponseBackColor = Color.FromArgb(240, 240, 240)

            ' Settings Interface

            menuStripBackColor = Color.White

        ElseIf My.Settings.selectedTheme = "Dark" Then

            ' Global

            guiColor = Color.FromArgb(35, 35, 35)
            labelBackColor = Color.FromArgb(45, 45, 45)
            labelForeColor = Color.FromArgb(225, 225, 225)
            buttonBackColor = Color.FromArgb(65, 65, 75)
            buttonBorderColor = Color.FromArgb(60, 60, 70)

            ' Main Interface

            labelResponseBackColor = Color.FromArgb(45, 45, 45)

            ' Settings Interface

            menuStripBackColor = Color.FromArgb(45, 45, 45)

        End If

        ' Main Interface

        frmMain.BackColor = guiColor
        frmMain.lblResponse.BackColor = labelResponseBackColor
        frmMain.lblResponse.ForeColor = labelForeColor
        frmMain.lblReceivedInput.ForeColor = labelForeColor
        frmMain.btnSend.BackColor = buttonBackColor
        frmMain.btnSettings.BackColor = buttonBackColor
        frmMain.btnChangelogs.BackColor = buttonBackColor
        frmMain.btnExit.BackColor = buttonBackColor
        frmMain.btnSend.FlatAppearance.BorderColor = buttonBorderColor
        frmMain.btnSettings.FlatAppearance.BorderColor = buttonBorderColor
        frmMain.btnChangelogs.FlatAppearance.BorderColor = buttonBorderColor
        frmMain.btnExit.FlatAppearance.BorderColor = buttonBorderColor

        ' Settings Interface

        Me.BackColor = guiColor
        msSettings.BackColor = menuStripBackColor
        btnExit.BackColor = buttonBackColor
        btnExit.FlatAppearance.BorderColor = buttonBorderColor
        cbTheme.BackColor = buttonBackColor
        cbTheme.ForeColor = labelForeColor
        cbFeedbackSubmission.ForeColor = labelForeColor
        lblTheme.ForeColor = labelForeColor

        ' Changelogs Interface

        frmWhatsNew.BackColor = guiColor
        frmWhatsNew.lblChangelogTitle.ForeColor = labelForeColor
        frmWhatsNew.lblChangelog.BackColor = labelBackColor
        frmWhatsNew.lblChangelog.ForeColor = labelForeColor
        frmWhatsNew.btnUpdate.BackColor = buttonBackColor
        frmWhatsNew.btnUpdate.FlatAppearance.BorderColor = buttonBorderColor
        frmWhatsNew.btnExit.BackColor = buttonBackColor
        frmWhatsNew.btnExit.FlatAppearance.BorderColor = buttonBorderColor

        Return False

    End Function

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbFeedbackSubmission.Checked = My.Settings.feedbackSubmission

        cbTheme.Text = My.Settings.selectedTheme

        ' General Menu

        tsGeneral.BackColor = Color.FromName("MenuHighlight")
        tsGeneral.ForeColor = Color.FromName("HighlightText")

        ' Personalization Menu

        tsPersonalize.BackColor = menuStripBackColor
        tsPersonalize.ForeColor = labelForeColor

        ' General Settings

        cbFeedbackSubmission.Visible = True

        ' Personalization Settings

        cbTheme.Visible = False
        lblTheme.Visible = False

        themeChange()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnExit_GotFocus(sender As Object, e As EventArgs) Handles btnExit.GotFocus

        btnExit.FlatAppearance.BorderColor = Color.FromName("Highlight")

    End Sub

    Private Sub btnExit_LostFocus(sender As Object, e As EventArgs) Handles btnExit.LostFocus

        btnExit.FlatAppearance.BorderColor = buttonBorderColor

    End Sub

    Private Sub cbFeedbackSubmission_CheckedChanged(sender As Object, e As EventArgs) Handles cbFeedbackSubmission.CheckedChanged

        If cbFeedbackSubmission.Checked = True Then

            My.Settings.feedbackSubmission = True

        Else

            My.Settings.feedbackSubmission = False

        End If

    End Sub

    Private Sub cbTheme_TextChanged(sender As Object, e As EventArgs) Handles cbTheme.TextChanged

        My.Settings.selectedTheme = cbTheme.Text

        themeChange()

        tsGeneral.BackColor = menuStripBackColor
        tsGeneral.ForeColor = labelForeColor

    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsGeneral.Click

        ' General Menu

        tsGeneral.BackColor = Color.FromName("MenuHighlight")
        tsGeneral.ForeColor = Color.FromName("HighlightText")

        ' Personalization Menu

        tsPersonalize.BackColor = menuStripBackColor
        tsPersonalize.ForeColor = labelForeColor

        ' General Settings

        cbFeedbackSubmission.Visible = True

        ' Personalization Settings

        cbTheme.Visible = False
        lblTheme.Visible = False

    End Sub

    Private Sub PersonalizationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsPersonalize.Click

        ' General Settings

        tsGeneral.BackColor = menuStripBackColor
        tsGeneral.ForeColor = labelForeColor

        ' Personalization Settings

        tsPersonalize.BackColor = Color.FromName("MenuHighlight")
        tsPersonalize.ForeColor = Color.FromName("HighlightText")

        ' General Settings

        cbFeedbackSubmission.Visible = False

        ' Personalization Settings

        cbTheme.Visible = True
        lblTheme.Visible = True

    End Sub

End Class