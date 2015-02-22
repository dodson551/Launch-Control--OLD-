Public Class Form1

  Dim bSafety As Boolean = True
  Dim dt As New DataTable

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    bSafety = True
    Safety_Mode()
    dt.Columns.Add("Events")
    dt.Columns.Add("Timestamp")
  End Sub

  Private Sub pbSafety_Click(sender As Object, e As EventArgs) Handles pbSafety.Click
    If bSafety = True Then
      pbSafety.Image = My.Resources.safety_off
      bSafety = False
      Launch_Mode()
    ElseIf bSafety = False Then
      pbSafety.Image = My.Resources.safety_on2
      bSafety = True
      Safety_Mode()
    End If
  End Sub

  Public Sub Launch_Mode()
    btnLaunch.Enabled = True
    btnAbort.Enabled = True
    btnIgnOn.Enabled = True
    btnIgnOff.Enabled = True
    btnMainOpen.Enabled = True
  End Sub

  Public Sub Safety_Mode()
    btnLaunch.Enabled = False
    btnAbort.Enabled = False
    btnIgnOn.Enabled = False
    btnIgnOff.Enabled = False
    btnMainOpen.Enabled = False
  End Sub

  Public Sub adjust_clm_width()
    Dim clm As DataGridViewColumn = dgvEvents.Columns(0)
    clm.Width = 520
    Dim clm2 As DataGridViewColumn = dgvEvents.Columns(1)
    clm2.Width = 520
  End Sub

  Private Sub btnIgnOn_Click(sender As Object, e As EventArgs) Handles btnIgnOn.Click
    dgvEvents.DataSource = dt
    dt.Rows.Add("Ignitor Lit", Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnIgnOff_Click(sender As Object, e As EventArgs) Handles btnIgnOff.Click
    dgvEvents.DataSource = dt
    dt.Rows.Add("Ignitor Off", Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnVentOpen_Click(sender As Object, e As EventArgs) Handles btnVentOpen.Click
    dgvEvents.DataSource = dt
    dt.Rows.Add("Vents Opened", Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnVentClose_Click(sender As Object, e As EventArgs) Handles btnVentClose.Click
    dgvEvents.DataSource = dt
    dt.Rows.Add("Vents Closed", Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnMainOpen_Click(sender As Object, e As EventArgs) Handles btnMainOpen.Click
    dgvEvents.DataSource = dt
    dt.Rows.Add("Main Valves Opened", Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnMainClose_Click(sender As Object, e As EventArgs) Handles btnMainClose.Click
    dgvEvents.DataSource = dt
    dt.Rows.Add("Main Valves Closed", Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
    dgvEvents.DataSource = dt
    dt.Rows.Add("Launch!", Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
    dgvEvents.DataSource = dt
    dt.Rows.Add("Launch Aborted", Date.Now)
    adjust_clm_width()
  End Sub
End Class
