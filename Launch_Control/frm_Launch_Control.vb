Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class frmMain

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Variable Declaration
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Dim client As New TcpClient
  Dim bSafety As Boolean = True
  Dim bConnected As Boolean = False
  Dim bSensor As Boolean = False
  Dim bRec As Boolean = False
  Dim dt As New DataTable
  Dim bytes(1024) As Byte
  Dim ipAddress As IPAddress = Nothing
  Dim port As Integer = Nothing
  Dim soc As Socket

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Page Events / Network Connection and Disconnection
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    bSafety = True
    bConnected = False
    bRec = False
    txtIP.Text = My.Settings.IP.ToString
    txtPort.Text = My.Settings.Port.ToString
    Safety_Mode()
    dt.Columns.Add("Events")
    dt.Columns.Add("Timestamp")
    Me.Text = "San Diego State Launch Control"
  End Sub

  Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    If bConnected = True Then
      'soc.Shutdown(SocketShutdown.Both)
      Dim dis_result = soc.BeginDisconnect(True, Nothing, Nothing)
      Dim dis_success = dis_result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
      If Not dis_success Then
        MsgBox("Client software was not able to disconnect successfully. Please try again.")
      Else
        Me.Text = "Disconnected from board: " + soc.RemoteEndPoint.ToString()
        bConnected = False
        bRec = False
        btnCameraCtl.AutoScaleImage = My.Resources.camera_button2
        dgvEvents.DataSource = dt
        dt.Rows.Add(Me.Text, Date.Now)
        adjust_clm_width()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
        Timer1.Stop()
        Clear_Sensors()
      End If
    End If
  End Sub

  Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
    'ipAddress = ipAddress.Parse(txtIP.Text)
    soc = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    port = txtPort.Text
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address that you wish to use to connect to.")
    ElseIf txtPort.Text = Nothing Then
      MsgBox("Please enter the board port that you wish to use to connect to.")
    Else
      Try
        Dim result = soc.BeginConnect(txtIP.Text, port, Nothing, Nothing)
        Dim success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))

        If Not success Then
          MsgBox("Server is not running on Raspberry Pi. Load Putty and initialize the server before connecting.")
        Else
          Me.Text = "Connected to board: " + soc.RemoteEndPoint.ToString()
          bConnected = True
          dgvEvents.DataSource = dt
          dt.Rows.Add(Me.Text, Date.Now)
          adjust_clm_width()
          btnConnect.Enabled = False
          btnDisconnect.Enabled = True
          Timer1.Start()
        End If
      Catch ex As Exception
        MsgBox(ex.Message)
      End Try
    End If
  End Sub

  Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
    Timer1.Stop()
    bSensor = True
    btnSensorReads.AutoScaleImage = My.Resources.begin_sensors
    btnSensorReads.Enabled = True
    If bConnected = True Then
      'soc.Shutdown(SocketShutdown.Both)
      Dim dis_result = soc.BeginDisconnect(True, Nothing, Nothing)
      Dim dis_success = dis_result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
      If Not dis_success Then
        MsgBox("Client software was not able to disconnect successfully. Please try again.")
      Else
        Me.Text = "Disconnected from board: " + soc.RemoteEndPoint.ToString()
        bConnected = False
        bRec = False
        btnCameraCtl.AutoScaleImage = My.Resources.camera_button2
        dgvEvents.DataSource = dt
        dt.Rows.Add(Me.Text, Date.Now)
        adjust_clm_width()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
        Timer1.Stop()
        Clear_Sensors()
      End If
    End If
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
    Send_Rec_Label("temp_status", lblThermo)
    Send_Rec_Label("bwire_status", lblBwire)
    Send_Rec_Label("kero_status", lblKeroValve)
    Send_Rec_Label("LOX_status", lblLOXValve)
    Send_Rec_Label("main_status", lblMainValves)

    Dim iThermo As Integer = lblThermo.Text
    If iThermo <= "100" Then
      lblThermo.BackColor = Color.LightCoral
    ElseIf iThermo <= "200" And lblThermo.Text >= "101" Then
      lblThermo.BackColor = Color.Khaki
    ElseIf iThermo >= "201" Then
      lblThermo.BackColor = Color.DarkSeaGreen
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
  End Sub

  Public Sub Safety_Mode()
    btnLaunch.Enabled = False
    btnAbort.Enabled = False
    btnIgn1On.Enabled = False
    btnIgn1Off.Enabled = False
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

  Public Function Send_Rec_DGV(ByVal sMess As String, ByRef dgv As DataGridView)
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If bConnected = True Then
        Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
        Dim bytesSent As Integer = soc.Send(msg)
        Dim bytesRec As Integer = soc.Receive(bytes)
        dgv.DataSource = dt
        dt.Rows.Add(Encoding.ASCII.GetString(bytes, 0, bytesRec), Date.Now) 
        adjust_clm_width()
      Else
        MsgBox("Server is not running on Raspberry Pi. Load Putty and initialize the server before connecting.")
      End If
    End If
    Return Nothing
  End Function

  Public Function Send_Rec_Label(ByVal sMess As String, ByRef lbl As Label)
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If bConnected = True Then
        Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
        Dim bytesSentlbl As Integer = soc.Send(msg)
        Dim bytesReclbl As Integer = soc.Receive(bytes)
        lbl.Text = Encoding.ASCII.GetString(bytes, 0, bytesReclbl)
      Else
        MsgBox("Server is not running on Raspberry Pi. Load Putty and initialize the server before connecting.")
      End If
    End If
    Return Nothing
  End Function

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Actuation and Initialization of Systems
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

#Region "Actuation and Initializing"

  Private Sub btnIgnOn_Click(sender As Object, e As EventArgs) Handles btnIgn1On.Click
    Send_Rec_DGV("ign1_on", dgvEvents)
  End Sub

  Private Sub btnIgnOff_Click(sender As Object, e As EventArgs) Handles btnIgn1Off.Click
    Send_Rec_DGV("ign1_off", dgvEvents)
  End Sub

  Private Sub btnVentOpen_Click(sender As Object, e As EventArgs) Handles btnVentOpen.Click
    Send_Rec_DGV("vents_open", dgvEvents)
  End Sub

  Private Sub btnVentClose_Click(sender As Object, e As EventArgs) Handles btnVentClose.Click
    Send_Rec_DGV("vents_close", dgvEvents)
  End Sub

  Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
    Send_Rec_DGV("launch", dgvEvents)
  End Sub

  Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
    Send_Rec_DGV("abort", dgvEvents)
  End Sub

  Private Sub btnPoEOn_Click(sender As Object, e As EventArgs) Handles btnPoEOn.Click
    Send_Rec_DGV("esb_power", dgvEvents)
  End Sub

  Private Sub btnPoEOff_Click(sender As Object, e As EventArgs) Handles btnPoEOff.Click
    Send_Rec_DGV("rocket_power", dgvEvents)
  End Sub

  Private Sub btnCameraCtl_Click(sender As Object, e As EventArgs) Handles btnCameraCtl.Click
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If bConnected = True Then
        If bRec = False Then
          btnCameraCtl.AutoScaleImage = My.Resources.toggle_video_recording
          bRec = True
          Send_Rec_DGV("toggle_record", dgvEvents)
        ElseIf bRec = True Then
          btnCameraCtl.AutoScaleImage = My.Resources.toggle_video_no_capture
          bRec = False
          Send_Rec_DGV("toggle_record", dgvEvents)
        End If
      Else
        MsgBox("Server is not running on Raspberry Pi. Load Putty and initialize the server before connecting.")
      End If
    End If
  End Sub

  Private Sub btnSensorReads_Click(sender As Object, e As EventArgs) Handles btnSensorReads.Click
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If bConnected = True Then
        Timer1.Start()
        If bSensor = False Then
          btnSensorReads.AutoScaleImage = My.Resources.reading_sensors
          btnSensorReads.Enabled = False
          bSensor = True
        End If
      Else
        MsgBox("Server is not running on Raspberry Pi. Load Putty and initialize the server before connecting.")
      End If
    End If
  End Sub

#End Region

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' End of Program
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
End Class
