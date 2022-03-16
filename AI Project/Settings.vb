Imports System.IO
Imports System.Text
Imports System.Net

Public Class frmSettings

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim changelogURL As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/AI-Solution/master/changelog"
        Dim buildVersionURL As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/AI-Solution/master/build-version"
        Dim client As WebClient = New WebClient()

        Dim changelogText As StreamReader = New StreamReader(client.OpenRead(changelogURL))
        Dim buildVersionText As StreamReader = New StreamReader(client.OpenRead(buildVersionURL))

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