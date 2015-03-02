Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class frmMain

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Variable Declaration
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Dim bSafety As Boolean = True
  Dim bSensor As Boolean = True
  Dim dt As New DataTable
  Dim bytes(1024) As Byte
  Dim ipAddress As IPAddress = Nothing
  Dim port As Integer = Nothing
  Dim soc As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Page Events / Network Connection and Disconnection
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    bSafety = True
    Safety_Mode()
    dt.Columns.Add("Events")
    dt.Columns.Add("Timestamp")
    Me.Text = "San Diego State Launch Control"
  End Sub

  Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
    'define connection parameters 
    ipAddress = ipAddress.Parse(txtIP.Text)
    port = txtPort.Text
    Dim remoteEP As New IPEndPoint(ipAddress, port)
    'connecting to socket
    soc.Connect(remoteEP)
    Me.Text = "Connected to board: " + soc.RemoteEndPoint.ToString()
    dgvEvents.DataSource = dt
    dt.Rows.Add(Me.Text, Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
    Timer1.Stop()
    bSensor = True
    btnSensorReads.AutoScaleImage = My.Resources.begin_sensors
    btnSensorReads.Enabled = True
    soc.Disconnect(False)
    Me.Text = "Disconnected from board: " + soc.RemoteEndPoint.ToString()
    dgvEvents.DataSource = dt
    dt.Rows.Add(Me.Text, Date.Now)
    adjust_clm_width()
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
      lblKeroValve.BackColor = Color.DarkSeaGreen
    Else
      lblKeroValve.BackColor = Color.LightCoral
    End If

    If lblLOXValve.Text = "Open" Then
      lblLOXValve.BackColor = Color.DarkSeaGreen
    Else
      lblLOXValve.BackColor = Color.LightCoral
    End If

    If lblMainValves.Text = "Open" Then
      lblMainValves.BackColor = Color.DarkSeaGreen
    Else
      lblMainValves.BackColor = Color.LightCoral
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
      If My.Computer.Network.Ping(txtIP.Text) = True Then
        Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
        Dim bytesSent As Integer = soc.Send(msg)
        Dim bytesRec As Integer = soc.Receive(bytes)
        dgv.DataSource = dt
        dt.Rows.Add(Encoding.ASCII.GetString(bytes, 0, bytesRec), Date.Now)
        adjust_clm_width()
      Else
        MsgBox("No board deteced on the network, please check physical connection.")
      End If
    End If
    Return Nothing
  End Function

  Public Function Send_Rec_Label(ByVal sMess As String, ByRef lbl As Label)
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If My.Computer.Network.Ping(txtIP.Text) = True Then
        Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
        Dim bytesSentlbl As Integer = soc.Send(msg)
        Dim bytesReclbl As Integer = soc.Receive(bytes)
        lbl.Text = Encoding.ASCII.GetString(bytes, 0, bytesReclbl)
      Else
        MsgBox("No board deteced on the network, please check physical connection.")
      End If
    End If
    Return Nothing
  End Function

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Actuation and Initialization of Systems
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

#Region "Actuation and Initializing"

  Private Sub btnIgnOn_Click(sender As Object, e As EventArgs) Handles btnIgnOn.Click
    Send_Rec_DGV("ign1_on", dgvEvents)
  End Sub

  Private Sub btnIgnOff_Click(sender As Object, e As EventArgs) Handles btnIgnOff.Click
    Send_Rec_DGV("ign1_off", dgvEvents)
  End Sub

  Private Sub btnVentOpen_Click(sender As Object, e As EventArgs) Handles btnVentOpen.Click
    Send_Rec_DGV("vents_open", dgvEvents)
  End Sub

  Private Sub btnVentClose_Click(sender As Object, e As EventArgs) Handles btnVentClose.Click
    Send_Rec_DGV("vents_close", dgvEvents)
  End Sub

  Private Sub btnMainOpen_Click(sender As Object, e As EventArgs) Handles btnMainOpen.Click
    Send_Rec_DGV("main_open", dgvEvents)
  End Sub

  Private Sub btnMainClose_Click(sender As Object, e As EventArgs) Handles btnMainClose.Click
    Send_Rec_DGV("main_close", dgvEvents)
  End Sub

  Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
    Send_Rec_DGV("launch", dgvEvents)
  End Sub

  Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
    Send_Rec_DGV("abort", dgvEvents)
  End Sub

  Private Sub btnCameraCtl_Click(sender As Object, e As EventArgs) Handles btnCameraCtl.Click
    Dim bRec As Boolean = False
    If bRec = False Then
      btnCameraCtl.AutoScaleImage = My.Resources.recording
      btnCameraCtl.Enabled = False
      bRec = True
      Send_Rec_DGV("record", dgvEvents)
    End If
  End Sub

  Private Sub btnSensorReads_Click(sender As Object, e As EventArgs) Handles btnSensorReads.Click
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If My.Computer.Network.Ping(txtIP.Text) = True Then
        bSensor = False
        Timer1.Start()
        If bSensor = False Then
          btnSensorReads.AutoScaleImage = My.Resources.reading_sensors
          btnSensorReads.Enabled = False
          bSensor = True
        End If
      Else
        MsgBox("No board deteced on the network, please check physical connection.")
      End If
    End If
  End Sub

#End Region

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' End of Program
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

End Class
