﻿Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class lblMainValves

  Dim bSafety As Boolean = True
  Dim dt As New DataTable
  'data buffer for incoming data as well as network settings
  Dim bytes(1024) As Byte
  Dim ipAddress As IPAddress = Nothing
  Dim port As Integer = Nothing
  Dim soc As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    bSafety = True
    Safety_Mode()
    dt.Columns.Add("Events")
    dt.Columns.Add("Timestamp")
  End Sub

#Region "Operational Mode"

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

#End Region

  Public Sub adjust_clm_width()
    Dim clm As DataGridViewColumn = dgvEvents.Columns(0)
    clm.Width = 520
    Dim clm2 As DataGridViewColumn = dgvEvents.Columns(1)
    clm2.Width = 520
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


#Region "Actuation and Initializing"

  Private Sub btnIgnOn_Click(sender As Object, e As EventArgs) Handles btnIgnOn.Click
    Send_Rec_DGV("1", dgvEvents)
  End Sub

  Private Sub btnIgnOff_Click(sender As Object, e As EventArgs) Handles btnIgnOff.Click
    Send_Rec_DGV("2", dgvEvents)
  End Sub

  Private Sub btnVentOpen_Click(sender As Object, e As EventArgs) Handles btnVentOpen.Click
    Send_Rec_DGV("3", dgvEvents)
  End Sub

  Private Sub btnVentClose_Click(sender As Object, e As EventArgs) Handles btnVentClose.Click
    Send_Rec_DGV("4", dgvEvents)
  End Sub

  Private Sub btnMainOpen_Click(sender As Object, e As EventArgs) Handles btnMainOpen.Click
    Send_Rec_DGV("5", dgvEvents)
  End Sub

  Private Sub btnMainClose_Click(sender As Object, e As EventArgs) Handles btnMainClose.Click
    Send_Rec_DGV("6", dgvEvents)
  End Sub

  Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
    Send_Rec_DGV("7", dgvEvents)
  End Sub

  Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
    Send_Rec_DGV("8", dgvEvents)
  End Sub

#End Region

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
    soc.Disconnect(False)
    Me.Text = "Disconnected from board: " + soc.RemoteEndPoint.ToString()
    dgvEvents.DataSource = dt
    dt.Rows.Add(Me.Text, Date.Now)
    adjust_clm_width()
  End Sub

  Private Sub btnSensorReads_Click(sender As Object, e As EventArgs) Handles btnSensorReads.Click
    If txtIP.Text = Nothing Then
      MsgBox("Please enter the board IP address and port that you wish to use to connect to.")
    Else
      If My.Computer.Network.Ping(txtIP.Text) = True Then
        Dim bSensor As Boolean = False
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

  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    Send_Rec_Label("temp_status", lblThermo)
    lblThermo.Text = lblThermo.Text + " F"
    'Threading.Thread.Sleep(100)
    Send_Rec_Label("bwire_status", lblBwire)
    'Threading.Thread.Sleep(100)
    Send_Rec_Label("reed_status", lblKeroValve)
    'Threading.Thread.Sleep(100)
  End Sub

  Private Sub btnCameraCtl_Click(sender As Object, e As EventArgs) Handles btnCameraCtl.Click
    Dim bRec As Boolean = False
    If bRec = False Then
      btnCameraCtl.AutoScaleImage = My.Resources.recording
      btnCameraCtl.Enabled = False
      bRec = True
    End If
  End Sub
End Class
