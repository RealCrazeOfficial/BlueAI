Imports System.IO
Imports System.Text
Imports System.Net

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim currentVersion As String = "0214"

        Dim address As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/AI-Solution/master/build-version"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))

        Dim latestVersion As Integer = reader.ReadToEnd

        Dim versionMatch As String = String.Compare(currentVersion, latestVersion)

        If currentVersion = latestVersion Then
            lblVersionInfo.Text = "Up to date"
            lblVersionInfo.ForeColor = Color.Green
        Else
            lblVersionInfo.Text = "Outdated"
            lblVersionInfo.ForeColor = Color.Red
            btnUpdate.Visible = True
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub tbInput_Enter(sender As Object, e As EventArgs) Handles tbInput.Enter

        lblPlaceholder.Visible = False

    End Sub

    Private Sub tbInput_Leave(sender As Object, e As EventArgs) Handles tbInput.Leave

        lblPlaceholder.Visible = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim webAddress As String = "https://github.com/XGMCLOLCrazE/AI-Solution/archive/refs/heads/master.zip"
        Process.Start(webAddress)
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        LoadResponse()

    End Sub

    Private Sub tbInput_KeyDown(sender As Object, e As KeyEventArgs) Handles tbInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadResponse()
        End If
    End Sub

    Function LoadResponse()

        pbLoading.Visible = True

        Dim unknownResponse() As String = {
            "I don't know the answer to that, sorry.",
            "I don't have the knowledge to answer that yet, sorry.",
            "I can't find the answer to that, sorry.",
            "That is beyond my limitations right now, sorry."
        }

        Dim timeResponse() As String = {
            "It's currently " + DateTime.Now.ToString("h:mm tt") + ".",
            "The time is " + DateTime.Now.ToString("h:mm tt") + ".",
            "It's " + DateTime.Now.ToString("h:mm tt") + " right now."
        }

        Dim tbInputFormatted As String

        Dim boolResponse As Boolean

        Dim Rnd As New Random

        boolResponse = False

        tbInputFormatted = tbInput.Text.ToLower()

        If tbInputFormatted.Contains("what") Then
            If tbInputFormatted.Contains("time") Then
                lblResponse.Text = timeResponse(Rnd.Next(0, 2))
                boolResponse = True
            End If
        End If

        If boolResponse = False Then

            lblResponse.Text = unknownResponse(Rnd.Next(0, 3))

        End If

        lblReceivedInput.Text = tbInput.Text

        tbInput.ResetText()

        pbLoading.Visible = False

        Return True

    End Function

End Class
