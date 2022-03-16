Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Text.RegularExpressions

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim currentVersion As String = "024"

        Dim rawVersionURL As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/AI-Solution/master/version-raw"
        Dim buildVersionURL As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/AI-Solution/master/build-version"

        Dim rawVersionText As StreamReader = New StreamReader(New WebClient().OpenRead(rawVersionURL))
        Dim buildVersionText As StreamReader = New StreamReader(New WebClient().OpenRead(buildVersionURL))

        Dim rawLatestVersion As Integer = rawVersionText.ReadToEnd
        Dim latestVersion As String = buildVersionText.ReadToEnd

        Dim versionMatch As String = String.Compare(currentVersion, rawLatestVersion)

        If currentVersion = rawLatestVersion Then
            frmSettings.lblVersionInfo.Text = "You are up to date"
            frmSettings.lblVersionInfo.ForeColor = Color.Green
        Else
            frmSettings.lblVersionInfo.Text = "An update is available"
            frmSettings.lblVersionInfo.ForeColor = Color.Red
            pbUpdateIcon.Visible = True
            frmSettings.btnUpdate.Enabled = True
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

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        frmSettings.ShowDialog()

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        LoadResponse()

    End Sub

    Private Sub tbInput_KeyDown(sender As Object, e As KeyEventArgs) Handles tbInput.KeyDown

        If e.KeyCode = Keys.Enter Then

            LoadResponse()

        End If

        If e.KeyCode = Keys.Up Then

            tbInput.Text = lblReceivedInput.Text
            My.Computer.Keyboard.SendKeys("{END}")

        End If

    End Sub

    Function LoadResponse()

        pbLoading.Visible = True

        ' Multi-Response

        Dim unknownResponse() As String = {
            "I don't know the answer to that, sorry.",
            "I don't have the knowledge to answer that yet, sorry.",
            "I can't find the answer to that, sorry.",
            "That is beyond my limitations right now, sorry."
        }

        Dim noInputResponse() As String = {
            "You didn't say anything.",
            "You didn't type anything.",
            "Did you say something?"
        }

        Dim timeResponse() As String = {
            "It's currently " + DateTime.Now.ToString("h:mm tt") + ".",
            "The time is " + DateTime.Now.ToString("h:mm tt") + ".",
            "It's " + DateTime.Now.ToString("h:mm tt") + " right now."
        }

        Dim greetingResponse() As String = {
            "Hello, is there anything I can do for you?",
            "Hi, is there anything I can help you with?"
        }

        Dim abilityResponse() As String = {
            "I'm still limited on what I can do, so unfortunately, I can't",
            "I'm still learning, so unfortunately I can't do that yet.",
            "I can't do that yet, but I might be able to in the future."
        }

        ' Array Input Checks

        Dim greetingInput() As String = {
            "hi",
            "hello",
            "hey"
        }

        Dim tbInputFormatted As String

        Dim boolResponse As Boolean

        Dim Rnd As New Random

        boolResponse = False

        tbInputFormatted = tbInput.Text.ToLower()

        If tbInputFormatted.Contains("what") Then
            If tbInputFormatted.Contains("time") Then
                lblResponse.Text = timeResponse(Rnd.Next(0, 3))
                boolResponse = True
            End If
        ElseIf tbInputFormatted.Contains("can you") Then
            If Rnd.Next(0, 3) = 1 Then
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bcan you\b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bme\b", "y0u")
                If tbInputFormatted.Contains("you will") Then
                    tbInputFormatted = Regex.Replace(tbInputFormatted, "\byou\b", "I")
                Else
                    tbInputFormatted = Regex.Replace(tbInputFormatted, "\byou\b", "I'm")
                End If
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\by0u\b", "you")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\baren't\b", "not")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\b yet\b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\b are\b", String.Empty)
                lblResponse.Text = abilityResponse(0) + tbInputFormatted + " yet."
                boolResponse = True
            Else
                lblResponse.Text = abilityResponse(Rnd.Next(2, 3))
                boolResponse = True
            End If
        ElseIf greetingInput.Contains(tbInputFormatted) Then
            lblResponse.Text = greetingResponse(Rnd.Next(0, 2))
            boolResponse = True
        End If

        If boolResponse = False Then
            If tbInputFormatted = "" Then
                lblResponse.Text = noInputResponse(Rnd.Next(0, 3))
            Else
                lblResponse.Text = unknownResponse(Rnd.Next(0, 4))
            End If
        End If

        lblReceivedInput.Text = tbInput.Text

        tbInput.ResetText()

        pbLoading.Visible = False

        Return True

    End Function

End Class
