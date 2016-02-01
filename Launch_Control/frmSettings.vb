Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSettingsIP.Text = My.Settings.IP.ToString()
        txtSettingsPort.Text = My.Settings.Port.ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.IP = txtSettingsIP.Text
        My.Settings.Port = txtSettingsPort.Text
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSettingsIP.Text = My.Settings.IP.ToString()
        txtSettingsPort.Text = My.Settings.Port.ToString()
    End Sub

End Class