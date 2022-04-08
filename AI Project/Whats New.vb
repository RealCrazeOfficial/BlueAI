Imports System.IO
Imports System.Text
Imports System.Net

Public Class frmWhatsNew

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim webAddress As String = "https://github.com/XGMCLOLCrazE/AI-Solution/archive/refs/heads/master.zip"
        Process.Start(webAddress)

    End Sub

End Class