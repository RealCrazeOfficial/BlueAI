Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub tbInput_Enter(sender As Object, e As EventArgs) Handles tbInput.Enter

        lblPlaceholder.Visible = False

    End Sub

    Private Sub tbInput_Leave(sender As Object, e As EventArgs) Handles tbInput.Leave

        lblPlaceholder.Visible = True

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

        tbInput.ResetText()

        pbLoading.Visible = False

        lblReceivedInput.Text = tbInput.Text

        Return True

    End Function

End Class
