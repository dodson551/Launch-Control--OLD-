Public Class frmSettings

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtLCS_IP.Text = My.Settings.LCS_IP
        txtLCS_Port.Text = My.Settings.LCS_Port
        txtLCS_Hostname.Text = My.Settings.LCS_Hostname

        txtFCC_IP.Text = My.Settings.FCC_IP
        txtFCC_Port.Text = My.Settings.FCC_Port
        txtFCC_Hostname.Text = My.Settings.FCC_Hostname

        txtOpMode.Text = My.Settings.OpMode
        txtCountdownTimer.Text = My.Settings.Countdown

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        My.Settings.LCS_IP = txtLCS_IP.Text
        My.Settings.LCS_Port = txtLCS_Port.Text
        My.Settings.LCS_Hostname = txtLCS_Hostname.Text

        My.Settings.FCC_IP = txtFCC_IP.Text
        My.Settings.FCC_Port = txtFCC_Port.Text
        My.Settings.FCC_Hostname = txtFCC_Hostname.Text

        My.Settings.OpMode = txtOpMode.Text
        My.Settings.Countdown = txtCountdownTimer.Text

        My.Settings.Save()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        My.Settings.LCS_IP = txtLCS_IP.Text
        My.Settings.LCS_Port = txtLCS_Port.Text
        My.Settings.LCS_Hostname = txtLCS_Hostname.Text

        My.Settings.FCC_IP = txtFCC_IP.Text
        My.Settings.FCC_Port = txtFCC_Port.Text
        My.Settings.FCC_Hostname = txtFCC_Hostname.Text

        My.Settings.OpMode = txtOpMode.Text
        My.Settings.Countdown = txtCountdownTimer.Text

    End Sub

End Class