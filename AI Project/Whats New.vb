Imports System.IO
Imports System.Text
Imports System.Net

Public Class frmWhatsNew

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.selectedTheme = "Dark" Then

            Me.BackColor = Color.FromArgb(35, 35, 35)
            lblChangelogTitle.ForeColor = Color.FromArgb(225, 225, 225)
            lblChangelog.BackColor = Color.FromArgb(45, 45, 45)
            lblChangelog.ForeColor = Color.FromArgb(225, 225, 225)
            btnUpdate.BackColor = Color.FromArgb(65, 65, 75)
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 70)
            btnExit.BackColor = Color.FromArgb(65, 65, 75)
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 70)
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 70)

        Else

            Me.BackColor = Color.FromName("Control")
            lblChangelogTitle.ForeColor = Color.FromName("ControlText")
            lblChangelog.BackColor = Color.FromName("Control")
            lblChangelog.ForeColor = Color.FromName("ControlText")
            btnUpdate.BackColor = Color.FromArgb(225, 225, 225)
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(173, 173, 173)
            btnExit.BackColor = Color.FromArgb(225, 225, 225)
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(173, 173, 173)

        End If

        Dim changelogURL As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/BlueAI/master/changelog"
        Dim buildVersionURL As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/BlueAI/master/build-version"

        Dim changelogText As New StreamReader(New WebClient().OpenRead(changelogURL))
        Dim buildVersionText As New StreamReader(New WebClient().OpenRead(buildVersionURL))

        Dim changelog As String = changelogText.ReadToEnd
        Dim buildVersion As String = buildVersionText.ReadToEnd

        Dim buildVersionFormatted As String = buildVersion.Replace(vbCr, "").Replace(vbLf, "")

        lblChangelogTitle.Text = "What's New in " + buildVersionFormatted + ":"
        lblChangelog.Text = changelog


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnExit_GotFocus(sender As Object, e As EventArgs) Handles btnExit.GotFocus

        btnExit.FlatAppearance.BorderColor = Color.FromName("Highlight")

    End Sub

    Private Sub btnExit_LostFocus(sender As Object, e As EventArgs) Handles btnExit.LostFocus

        If My.Settings.selectedTheme = "Dark" Then

            btnExit.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 70)

        Else

            btnExit.FlatAppearance.BorderColor = Color.FromArgb(173, 173, 173)

        End If

    End Sub

    Private Sub btnUpdate_GotFocus(sender As Object, e As EventArgs) Handles btnUpdate.GotFocus

        btnUpdate.FlatAppearance.BorderColor = Color.FromName("Highlight")

    End Sub

    Private Sub btnUpdate_LostFocus(sender As Object, e As EventArgs) Handles btnUpdate.LostFocus

        If My.Settings.selectedTheme = "Dark" Then

            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 70)

        Else

            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(173, 173, 173)

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim webAddress As String = "https://github.com/XGMCLOLCrazE/AI-Solution/archive/refs/heads/master.zip"
        Process.Start(webAddress)

    End Sub

End Class