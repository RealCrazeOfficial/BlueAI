Public Class frmSettings

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.feedbackSubmission = True Then

            cbFeedbackSubmission.Checked = True

        Else

            cbFeedbackSubmission.Checked = False

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub cbFeedbackSubmission_CheckedChanged(sender As Object, e As EventArgs) Handles cbFeedbackSubmission.CheckedChanged

        If cbFeedbackSubmission.Checked = True Then

            My.Settings.feedbackSubmission = True

        Else

            My.Settings.feedbackSubmission = False

        End If

    End Sub

End Class