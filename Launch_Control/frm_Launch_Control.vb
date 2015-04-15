Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class frmMain

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Variable Declaration
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Dim Con As New cTCP_Connection
  Dim bSafety As Boolean = True
  Dim bSensor As Boolean = False
  Dim bRec As Boolean = False
  Dim dt As New DataTable
  Dim filename As String

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Page Events / Network Connection and Disconnection
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtIP.Text = My.Settings.IP.ToString
    txtPort.Text = My.Settings.Port.ToString
    Safety_Mode()
    dt.Columns.Add("Events")
    dt.Columns.Add("Timestamp")
    Me.Text = "Waiting to establish server connection..."
    btnTxtFileSave.Enabled = False
  End Sub

  Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    Timer1.Stop()
    Clear_Sensors()
    Con.DisConnect_TCP(txtIP.Text, Me)
  End Sub

  Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address that you wish to use to connect to.")
    ElseIf txtPort.Text = Nothing Then
      MsgBox("Please enter the board port that you wish to use to connect to.")
    Else
      Con.Connect_TCP(txtIP.Text, txtPort.Text, Me)
      dgvEvents.DataSource = dt
      dt.Rows.Add(Me.Text, Date.Now)
      adjust_clm_width()
      btnConnect.Enabled = False
      btnDisconnect.Enabled = True
      Timer1.Start()
      txtIP.Enabled = False
      txtPort.Enabled = False
      btnTxtFileSave.Enabled = True
    End If
  End Sub

  Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
    Timer1.Stop()
    Clear_Sensors()
    Con.DisConnect_TCP(txtIP.Text, Me)
    bRec = False
    btnCameraCtl.AutoScaleImage = My.Resources.toggle_video_no_capture
    dgvEvents.DataSource = dt
    dt.Rows.Add(Me.Text, Date.Now)
    adjust_clm_width()
    btnConnect.Enabled = True
    btnDisconnect.Enabled = False
    txtIP.Enabled = True
    txtPort.Enabled = False
    btnTxtFileSave.Enabled = False
  End Sub

  Private Sub Clear_Sensors()

    lblThermo.Text = "--"
    lblThermo.BackColor = Color.WhiteSmoke
    lblBwire.Text = "--"
    lblBwire.BackColor = Color.WhiteSmoke

    lblKeroValve.Text = "--"
    lblKeroValve.BackColor = Color.WhiteSmoke
    lblLOXValve.Text = "--"
    lblLOXValve.BackColor = Color.WhiteSmoke
    lblMainValves.Text = "--"
    lblMainValves.BackColor = Color.WhiteSmoke

    lblHePress.Text = "--"
    lblHePress.BackColor = Color.WhiteSmoke
    lblLOXPress.Text = "--"
    lblLOXPress.BackColor = Color.WhiteSmoke
    lblKeroPress.Text = "--"
    lblKeroPress.BackColor = Color.WhiteSmoke

  End Sub

  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
<<<<<<< HEAD
    Con.Send_Rec_Label("temp_status", lblThermo, dt)
    Con.Send_Rec_Label("bwire_status", lblBwire, dt)
    Con.Send_Rec_Label("kero_status", lblKeroValve, dt)
    Con.Send_Rec_Label("LOX_status", lblLOXValve, dt)
    Con.Send_Rec_Label("main_status", lblMainValves, dt)

    Dim good As Boolean = True
    Dim iThermo As Double
    Try
      iThermo = Convert.ToDouble(lblThermo.Text)
    Catch ex As Exception
      good = False
    End Try

    If good = True Then
      If iThermo > 200 Then
        lblThermo.BackColor = Color.DarkSeaGreen
      Else
        lblThermo.BackColor = Color.LightCoral
=======
    Send_Rec_Label("temp_status", lblThermo)
    Send_Rec_Label("bwire_status", lblBwire)
    Send_Rec_Label("kero_status", lblKeroValve)
    Send_Rec_Label("LOX_status", lblLOXValve)
    Send_Rec_Label("main_status", lblMainValves)

    If lblThermo.Text = "nan" Then
      lblThermo.Text = "1000"
      lblThermo.BackColor = Color.DarkSeaGreen
    Else
      Dim iThermo As Double = lblThermo.Text
      If iThermo <= "100" Then
        lblThermo.BackColor = Color.LightCoral
      ElseIf iThermo <= "150" And lblThermo.Text >= "101" Then
        lblThermo.BackColor = Color.Khaki
      ElseIf iThermo >= "151" Then
        lblThermo.BackColor = Color.DarkSeaGreen
>>>>>>> a6bd82fddf28b606eaca65fb6f8e6e5fceaf8f1c
      End If
    End If
    lblThermo.Text = lblThermo.Text + " F"

    If lblBwire.Text = "Broken" Then
      lblBwire.BackColor = Color.DarkSeaGreen
    Else
      lblBwire.BackColor = Color.LightCoral
    End If

    If lblKeroValve.Text = "Open" Then
      lblKeroValve.BackColor = Color.LightCoral
    Else
      lblKeroValve.BackColor = Color.DarkSeaGreen
    End If

    If lblLOXValve.Text = "Open" Then
      lblLOXValve.BackColor = Color.LightCoral
    Else
      lblLOXValve.BackColor = Color.DarkSeaGreen
    End If

    If lblMainValves.Text = "Open" Then
      lblMainValves.BackColor = Color.LightCoral
    Else
      lblMainValves.BackColor = Color.DarkSeaGreen
    End If
  End Sub

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Program operating mode selection
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

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
    btnIgn1On.Enabled = True
    btnIgn1Off.Enabled = True
    btnMainOpen.Enabled = True
    btnMainClose.Enabled = True
    btnIgn2On.Enabled = True
    btnIgn2Off.Enabled = True
  End Sub

  Public Sub Safety_Mode()
    btnLaunch.Enabled = False
    btnAbort.Enabled = False
    btnIgn1On.Enabled = False
    btnIgn1Off.Enabled = False
    btnMainOpen.Enabled = False
    btnMainClose.Enabled = False
    btnIgn2On.Enabled = False
    btnIgn2Off.Enabled = False
  End Sub

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Functions to display data from TCP Connection
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Public Sub adjust_clm_width()
    Dim tWidth As Integer = dgvEvents.Size.Width
    Dim clm As DataGridViewColumn = dgvEvents.Columns(0)
    clm.Width = tWidth * 0.5
    Dim clm2 As DataGridViewColumn = dgvEvents.Columns(1)
    clm2.Width = tWidth * 0.5
  End Sub

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Actuation and Initialization of Systems
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

#Region "Actuation and Initializing"

  Private Sub btnIgnOn_Click(sender As Object, e As EventArgs) Handles btnIgn1On.Click
    Con.Send_Rec_DGV("ign1_on", dgvEvents, dt)
  End Sub

  Private Sub btnIgnOff_Click(sender As Object, e As EventArgs) Handles btnIgn1Off.Click
    Con.Send_Rec_DGV("ign1_off", dgvEvents, dt)
  End Sub

  Private Sub btnIgn2On_Click(sender As Object, e As EventArgs) Handles btnIgn2On.Click
    Con.Send_Rec_DGV("ign2_on", dgvEvents, dt)
  End Sub

  Private Sub btnIgn2Off_Click(sender As Object, e As EventArgs) Handles btnIgn2Off.Click
    Con.Send_Rec_DGV("ign2_off", dgvEvents, dt)
  End Sub

  Private Sub btnVentOpen_Click(sender As Object, e As EventArgs) Handles btnVentOpen.Click
    Con.Send_Rec_DGV("vents_open", dgvEvents, dt)
  End Sub

  Private Sub btnVentClose_Click(sender As Object, e As EventArgs) Handles btnVentClose.Click
    Con.Send_Rec_DGV("vents_close", dgvEvents, dt)
  End Sub

  Private Sub btnMainOpen_Click(sender As Object, e As EventArgs) Handles btnMainOpen.Click
    Con.Send_Rec_DGV("main_open", dgvEvents, dt)
  End Sub

  Private Sub btnMainClose_Click(sender As Object, e As EventArgs) Handles btnMainClose.Click
    Con.Send_Rec_DGV("main_close", dgvEvents, dt)
  End Sub

  Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
    Con.Send_Rec_DGV("launch", dgvEvents, dt)
  End Sub

  Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
    Con.Send_Rec_DGV("abort", dgvEvents, dt)
  End Sub

  Private Sub btnPoEOn_Click(sender As Object, e As EventArgs) Handles btnPoEOn.Click
    Con.Send_Rec_DGV("esb_power", dgvEvents, dt)
  End Sub

  Private Sub btnPoEOff_Click(sender As Object, e As EventArgs) Handles btnPoEOff.Click
    Con.Send_Rec_DGV("rocket_power", dgvEvents, dt)
  End Sub

  Private Sub btnCameraCtl_Click(sender As Object, e As EventArgs) Handles btnCameraCtl.Click
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If bRec = False Then
        btnCameraCtl.AutoScaleImage = My.Resources.toggle_video_recording
        bRec = True
        Con.Send_Rec_DGV("toggle_record", dgvEvents, dt)
      ElseIf bRec = True Then
        btnCameraCtl.AutoScaleImage = My.Resources.toggle_video_no_capture
        bRec = False
        Con.Send_Rec_DGV("toggle_record", dgvEvents, dt)
      End If
    End If
  End Sub

#End Region

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Settings Page
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    My.Settings.IP = txtIPSettings.Text
    My.Settings.Port = txtPortSettings.Text
    My.Settings.Save()
    txtIP.Text = My.Settings.IP.ToString
    txtPort.Text = My.Settings.Port.ToString
  End Sub

  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    txtIPSettings.Text = ""
    txtPortSettings.Text = ""
  End Sub

  Private Sub btnTxtFileSave_Click(sender As Object, e As EventArgs) Handles btnTxtFileSave.Click
    filename = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, txtFileLocation.Text)
    SaveGridData(dgvEvents, filename)
  End Sub

  Private Sub SaveGridData(ByVal thisgrid As DataGridView, ByVal FileName As String)
    thisgrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
    thisgrid.SelectAll()
    IO.File.WriteAllText(FileName, thisgrid.GetClipboardContent().GetText.TrimEnd)
    thisgrid.ClearSelection()
  End Sub

  Private Sub btnTxtFileNameClear_Click(sender As Object, e As EventArgs) Handles btnTxtFileNameClear.Click
    txtFileLocation.Text = ""
  End Sub

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' End of Program
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

End Class
