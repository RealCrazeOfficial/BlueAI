Imports System.IO
Imports System.Text
Imports System.Web
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.Timer
Imports System.Collections.Specialized

Public Class frmMain

    Private Const currentVersion As String = "031"
    Private Const rawVersionURL As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/AI-Solution/master/version-raw"
    Private ReadOnly rawVersionText As New StreamReader(New WebClient().OpenRead(rawVersionURL))
    Private ReadOnly rawLatestVersion As Integer = rawVersionText.ReadToEnd
    Private updateNotified As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim buildVersionURL As String = "https://raw.githubusercontent.com/XGMCLOLCrazE/AI-Solution/master/build-version"

        Dim buildVersionText As New StreamReader(New WebClient().OpenRead(buildVersionURL))

        Dim latestVersion As String = buildVersionText.ReadToEnd

        Dim versionMatch As String = String.Compare(currentVersion, rawLatestVersion)

        If currentVersion = rawLatestVersion Then
            frmWhatsNew.lblVersionInfo.Text = "You are up to date"
            frmWhatsNew.lblVersionInfo.ForeColor = Color.Green
        Else
            frmWhatsNew.lblVersionInfo.Text = "An update is available"
            frmWhatsNew.lblVersionInfo.ForeColor = Color.Red
            pbUpdateIcon.Visible = True
            frmWhatsNew.btnUpdate.Enabled = True
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

    Private Sub btnChangelogs_Click(sender As Object, e As EventArgs) Handles btnChangelogs.Click

        frmWhatsNew.ShowDialog()

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

    Private Sub tmrFeedbackSubmissionSuccess_Tick(sender As Object, e As EventArgs) Handles tmrFeedbackSubmissionSuccess.Tick

        lblFeedbackSubmission.Visible = False

    End Sub

    Private Sub tmrFeedbackSubmissionFailed_Tick(sender As Object, e As EventArgs) Handles tmrFeedbackSubmissionFailed.Tick

        lblFeedbackSubmission.Visible = False

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
            "Did you say something?",
            "You left the text box blank."
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

        ' Format the input to lowercase letters so that the AI can easily interprete the input

        tbInputFormatted = tbInput.Text.ToLower()
        tbInputFormatted = Regex.Replace(tbInputFormatted, "[`~!@#$^&()_{}|;:'<.>?]", String.Empty)

        ' Main AI Function

        Dim output As String = "I ran into an unknown error with my response where I would've outputted nothing, please report this if you can. Sorry about that!"

        lblResponse.TextAlign = ContentAlignment.MiddleCenter
        lblResponse.Font = New Font("Arial", 12, FontStyle.Bold)

        If tbInputFormatted.Contains("what") Then
            If tbInputFormatted.Contains("time") Then
                output = timeResponse(Rnd.Next(0, 3))
                boolResponse = True
            End If
        ElseIf tbInputFormatted.Contains("can you") Then
            If Rnd.Next(0, 3) = 1 Then
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bcan you\b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bme\b", "y0u")
                If tbInputFormatted.Contains("you will") Or tbInputFormatted.Contains("you know") Then
                    tbInputFormatted = Regex.Replace(tbInputFormatted, "\byou\b", "I")
                Else
                    tbInputFormatted = Regex.Replace(tbInputFormatted, "\byoure\b", "I'm")
                    tbInputFormatted = Regex.Replace(tbInputFormatted, "\byou are\b", "I'm")
                End If
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\by0u\b", "you")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\barent\b", "not")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\b yet\b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\b are\b", String.Empty)
                output = abilityResponse(0) + tbInputFormatted + " yet."
                boolResponse = True
            Else
                output = abilityResponse(Rnd.Next(2, 3))
                boolResponse = True
            End If
        ElseIf tbInputFormatted.Contains("tell") And Not tbInputFormatted.StartsWith("/") Then

            ' ##### BETA FEATURE #####

            If My.Settings.betaTell = True Then

                Dim startPosition As Integer = tbInputFormatted.IndexOf(" ") + 1
                Dim inputName As String = tbInputFormatted.Substring(startPosition, tbInputFormatted.IndexOf(" ", startPosition) - startPosition)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\b" + inputName + " \b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\btell \b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bask \b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bthat \b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bto \b", String.Empty)
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bnot\b", "don't")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bme\b", "y0u")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\byou a\b", "me a")
                If tbInputFormatted.Contains("you will") Or tbInputFormatted.Contains("you know") Then
                    tbInputFormatted = Regex.Replace(tbInputFormatted, "\byou\b", "I")
                Else
                    tbInputFormatted = Regex.Replace(tbInputFormatted, "\byoure\b", "I'm")
                    tbInputFormatted = Regex.Replace(tbInputFormatted, "\byou are\b", "I'm")
                End If
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\by0u\b", "you")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bhe\b", "you")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bshe\b", "you")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bthey\b", "you")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bhim\b", "you")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bher\b", "you")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\barent\b", "not")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bisnt\b", "aren't")

                ' Grammar Fixes

                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bI'm are\b", "I am")
                tbInputFormatted = Regex.Replace(tbInputFormatted, "\bI'm said\b", "I said")

                output = inputName + ", " + tbInputFormatted + "."
                boolResponse = True

                ' ##### BETA FEATURE #####

            Else

                output = "That feature is currently in Beta, you can toggle whether or not it's enabled by saying ''/beta tell''."
                boolResponse = True

            End If
        ElseIf greetingInput.Contains(tbInputFormatted) Then
            output = greetingResponse(Rnd.Next(0, 2))
            boolResponse = True
        ElseIf tbInputFormatted.StartsWith("/") Then

            lblResponse.TextAlign = ContentAlignment.TopLeft
            lblResponse.Font = New Font("Arial", 8, FontStyle.Bold)

            If tbInputFormatted = "/beta tell" Then

                If My.Settings.betaTell = True Then

                    My.Settings.betaTell = False

                    output = "Tell Beta Feature has been Disabled."

                    boolResponse = True

                Else

                    My.Settings.betaTell = True

                    output = "Tell Beta Feature has been Enabled."

                    boolResponse = True

                End If
            ElseIf tbInputFormatted = "/help" Or tbInputFormatted = "/?" Then

                output = "List of Commands:" & Environment.NewLine &
                    "/beta tell - Toggle the Tell beta feature."

                boolResponse = True

            Else

                output = "Unknown Command. Please say ''/help'' for a list of available commands."

                boolResponse = True

            End If
        End If

        ' Responses for when the AI doesn't know the answer or when no input is given

        If boolResponse = False Then
            If tbInputFormatted = "" Then
                output = noInputResponse(Rnd.Next(0, 3))
            Else

                If My.Settings.feedbackSubmission = True And My.Computer.Network.IsAvailable Then

                    tmrFeedbackSubmissionSuccess.Interval = 2000
                    tmrFeedbackSubmissionFailed.Interval = 10000
                    Dim client As New WebClient
                    Dim keyValue As New NameValueCollection
                    Dim postdata As String
                    Dim displayError As Boolean = False

                    lblFeedbackSubmission.ForeColor = Color.ForestGreen
                    lblFeedbackSubmission.Text = "Sending..."
                    lblFeedbackSubmission.Visible = True

                    postdata = tbInput.Text.ToString()
                    keyValue.Add("entry.1619369433", postdata)

                    Try

                        client.UploadValues("https://docs.google.com/forms/u/0/d/e/1FAIpQLScxHsvLHAPHlK-jrth6OUcHmuxKQuSQ8soNulMh4o7XdP4RlQ/formResponse", "POST", keyValue)

                    Catch ex As WebException
                        lblFeedbackSubmission.ForeColor = Color.Red
                        lblFeedbackSubmission.Text = String.Format("Error: {0}", ex.Message)
                        tmrFeedbackSubmissionFailed.Start()
                        displayError = True
                    End Try

                    If displayError = False Then
                        lblFeedbackSubmission.Text = "Sent Successfully!"
                        tmrFeedbackSubmissionSuccess.Start()
                    End If

                End If

                output = unknownResponse(Rnd.Next(0, 4))

            End If

        End If

        ' The AI's response

        lblResponse.Text = output

        If currentVersion = rawLatestVersion Then

            updateNotified = True

        ElseIf updateNotified = False Then

            lblResponse.Text = output + " By the way, I have an update available. You can go to What's New in the bottom-right corner if you would like to update."
            updateNotified = True

        End If

        ' Put the last inputted string in the bottom-left corner of the UI

        lblReceivedInput.Text = tbInput.Text

            ' Clear the input box

            tbInput.ResetText()

            pbLoading.Visible = False

            Return True

    End Function

End Class
