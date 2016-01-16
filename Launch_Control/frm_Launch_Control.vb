Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class frmMain

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Variable Declaration
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

  Dim bSafety As Boolean = True
  Dim bSensor As Boolean = False
  Dim bRec As Boolean = False
  Dim dt As New DataTable
  Dim filename As String
  Dim bConnection As Boolean = False

  Dim bytes(1024) As Byte
  Dim ipAddress As IPAddress = Nothing
  Dim port As Integer = Nothing
  Dim soc As Socket

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
    If bConnection = True Then
      Try
        soc.Shutdown(SocketShutdown.Both)
        Dim dis_result = soc.BeginDisconnect(True, Nothing, Nothing)
        Dim dis_success = dis_result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
        If Not dis_success Then
          MsgBox("Client software was not able to disconnect successfully. Please try again.")
        Else
          bConnection = False
          Me.Text = "Disconnected from board: " & txtIP.Text
          Timer1.Stop()
          Clear_Sensors()
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try
    End If
  End Sub

  Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address that you wish to use to connect to.")
    ElseIf txtPort.Text = Nothing Then
      MsgBox("Please enter the board port that you wish to use to connect to.")
    Else
      Try
        ipAddress = System.Net.IPAddress.Parse(txtIP.Text)
        port = txtPort.Text
        soc = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim result = soc.BeginConnect(ipAddress, port, Nothing, Nothing)
        Dim success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
        If Not success Then
          MsgBox("Connection attempt refused. Check IP, Port, and server status are all correct.")
          bConnection = False
        Else
          bConnection = True
          Me.Text = "Connected to board at: " & ipAddress.ToString
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
      Catch ex As Exception
        MessageBox.Show(ex.Message)
        bConnection = False
      End Try
    End If
  End Sub

  Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
    If bConnection = True Then
      Try
        soc.Shutdown(SocketShutdown.Both)
        Dim dis_result = soc.BeginDisconnect(True, Nothing, Nothing)
        Dim dis_success = dis_result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
        If Not dis_success Then
          MsgBox("Client software was not able to disconnect successfully. Please try again.")
        Else
          bConnection = False
          Me.Text = "Disconnected from board: " & txtIP.Text
          Timer1.Stop()
          Clear_Sensors()
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
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try
    Else
      MsgBox("No connection established.")
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
    Send_Rec_Label("temp_status", lblThermo, dt)
    Send_Rec_Label("bwire_status", lblBwire, dt)
    Send_Rec_Label("kero_status", lblKeroValve, dt)
    Send_Rec_Label("LOX_status", lblLOXValve, dt)
    Send_Rec_Label("main_status", lblMainValves, dt)

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
      dgvEvents.DataSource = dt
      dt.Rows.Add("Safety Off", Date.Now)
      adjust_clm_width()
    ElseIf bSafety = False Then
      pbSafety.Image = My.Resources.safety_on2
      bSafety = True
      Safety_Mode()
      dgvEvents.DataSource = dt
      dt.Rows.Add("Safety On", Date.Now)
      adjust_clm_width()
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

  Public Function Send_Rec_DGV(ByVal sMess As String, ByRef dgv As DataGridView, ByRef dt As DataTable)
    Try
      Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
      Dim bytesSent As Integer = soc.Send(msg)
      Dim bytesRec As Integer = soc.Receive(bytes)
      dgv.DataSource = dt
      dt.Rows.Add(Encoding.ASCII.GetString(bytes, 0, bytesRec), Date.Now)
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
    Return bConnection
  End Function

  Public Function Send_Rec_Label(ByVal sMess As String, ByRef lbl As Label, ByRef dt As DataTable)
    Try
      Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
      Dim bytesSentlbl As Integer = soc.Send(msg)
      Dim bytesReclbl As Integer = soc.Receive(bytes)
      lbl.Text = Encoding.ASCII.GetString(bytes, 0, bytesReclbl)
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
    Return bConnection
  End Function

  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
  ' Actuation and Initialization of Systems
  '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

#Region "Actuation and Initializing"

  Private Sub btnIgnOn_Click(sender As Object, e As EventArgs) Handles btnIgn1On.Click
    Send_Rec_DGV("ign1_on", dgvEvents, dt)
  End Sub

  Private Sub btnIgnOff_Click(sender As Object, e As EventArgs) Handles btnIgn1Off.Click
    Send_Rec_DGV("ign1_off", dgvEvents, dt)
  End Sub

  Private Sub btnIgn2On_Click(sender As Object, e As EventArgs) Handles btnIgn2On.Click
    Send_Rec_DGV("ign2_on", dgvEvents, dt)
  End Sub

  Private Sub btnIgn2Off_Click(sender As Object, e As EventArgs) Handles btnIgn2Off.Click
    Send_Rec_DGV("ign2_off", dgvEvents, dt)
  End Sub

  Private Sub btnVentOpen_Click(sender As Object, e As EventArgs) Handles btnVentOpen.Click
    Send_Rec_DGV("vents_open", dgvEvents, dt)
  End Sub

  Private Sub btnVentClose_Click(sender As Object, e As EventArgs) Handles btnVentClose.Click
    Send_Rec_DGV("vents_close", dgvEvents, dt)
  End Sub

  Private Sub btnMainOpen_Click(sender As Object, e As EventArgs) Handles btnMainOpen.Click
    Send_Rec_DGV("main_open", dgvEvents, dt)
  End Sub

  Private Sub btnMainClose_Click(sender As Object, e As EventArgs) Handles btnMainClose.Click
    Send_Rec_DGV("main_close", dgvEvents, dt)
  End Sub

  Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
    Send_Rec_DGV("launch", dgvEvents, dt)
  End Sub

  Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
    Send_Rec_DGV("abort", dgvEvents, dt)
  End Sub

  Private Sub btnPoEOn_Click(sender As Object, e As EventArgs) Handles btnPoEOn.Click
    Send_Rec_DGV("esb_power", dgvEvents, dt)
  End Sub

  Private Sub btnPoEOff_Click(sender As Object, e As EventArgs) Handles btnPoEOff.Click
    Send_Rec_DGV("rocket_power", dgvEvents, dt)
  End Sub

  Private Sub btnCameraCtl_Click(sender As Object, e As EventArgs) Handles btnCameraCtl.Click
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If bRec = False Then
        btnCameraCtl.AutoScaleImage = My.Resources.toggle_video_recording
        bRec = True
        Send_Rec_DGV("toggle_record", dgvEvents, dt)
      ElseIf bRec = True Then
        btnCameraCtl.AutoScaleImage = My.Resources.toggle_video_no_capture
        bRec = False
        Send_Rec_DGV("toggle_record", dgvEvents, dt)
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
