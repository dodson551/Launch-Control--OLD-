Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System
Imports System.IO
Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Gauge
Imports System.Math

Public Class frmLCS

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
    ' Variable Declaration
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    Dim bSafety As Boolean = True
    Dim bSensor As Boolean = False
    Dim bRec As Boolean = False
    Dim dt As New DataTable
    Dim filename As String
    Dim bConnected As Boolean = False
    Dim opMode As String

    Dim bytes(1024) As Byte
    Dim ipAddress As IPAddress = Nothing
    Dim hostname As String = Nothing
    Dim port As Integer = Nothing
    Dim soc As Socket


    Private Sub frmLCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Safety_Mode()
        updateTimer.Start()
        dt.Columns.Add("Events")
        dt.Columns.Add("Timestamp")
        txtConsole.Text = "Waiting to establish server connection..."
        txtIP.Text = My.Settings.LCS_IP
        txtPort.Text = My.Settings.LCS_Port
        txtCount.Text = My.Settings.Countdown
    End Sub

    Private Sub frmLCS_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        updateTimer.Stop()
        If bConnected = True Then
            Try
                soc.Shutdown(SocketShutdown.Both)
                Dim dis_result = soc.BeginDisconnect(True, Nothing, Nothing)
                Dim dis_success = dis_result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
                If Not dis_success Then
                    MsgBox("Client software was not able to disconnect successfully. Please try again.")
                Else
                    bConnected = False
                    txtConsole.Text = "Disconnected from board: " & txtIP.Text
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
                    bConnected = False
                Else
                    bConnected = True
                    txtConsole.Text &= Environment.NewLine & "Connected to board at: " & ipAddress.ToString
                    dgvEvents.DataSource = dt
                    dt.Rows.Add("Connected to board at: " & ipAddress.ToString, Date.Now)
                    adjust_clm_width()
                    btnConnect.Enabled = False
                    txtIP.Enabled = False
                    txtPort.Enabled = False
                    btnDisconnect.Enabled = True
                    btnPing.Enabled = True
                    My.Settings.LCS_IP = txtIP.Text
                    My.Settings.LCS_Port = txtPort.Text
                    My.Settings.Save()
                    If opMode = "Testing" Then
                        Debug.WriteLine("Sensors not started")
                        startSensors.Enabled = False
                        stopSensors.Enabled = False
                        resetSensors.Enabled = False
                    Else
                        sensorTimer.Start()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                bConnected = False
            End Try
        End If
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        If bConnected = True Then
            Try
                soc.Shutdown(SocketShutdown.Both)
                Dim dis_result = soc.BeginDisconnect(True, Nothing, Nothing)
                Dim dis_success = dis_result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
                If Not dis_success Then
                    MsgBox("Client software was not able to disconnect successfully. Please try again.")
                Else
                    bConnected = False
                    txtConsole.Text &= Environment.NewLine & "Disconnected from board: " & txtIP.Text
                    dgvEvents.DataSource = dt
                    dt.Rows.Add("Disconnected from board: " & txtIP.Text, Date.Now)
                    adjust_clm_width()
                    btnConnect.Enabled = True
                    btnDisconnect.Enabled = False
                    txtIP.Enabled = True
                    txtPort.Enabled = True
                    sensorTimer.Stop()
                    reset_sensors()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("No connection established.")
        End If
    End Sub

    Private Sub btnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        If txtIP.Text <> Nothing Then
            Try
                If My.Computer.Network.Ping(txtIP.Text) Then
                    txtConsole.Text &= Environment.NewLine & "Server pinged successfully."
                Else
                    txtConsole.Text &= Environment.NewLine & "Ping request timed out."
                End If
            Catch ex As Exception
                txtConsole.Text &= Environment.NewLine & ex.Message.ToString()
            End Try
        Else
            MsgBox("Please enter IP of server you wish to ping in the IP Address field.")
        End If
    End Sub

    Public Sub Safety_Mode()
        btnArm.BackColor = Color.Yellow
        btnArm.Text = "ARMED"
        btnArm.Enabled = False
        btnDisarm.Enabled = True
        btnDisarm.Text = "DISARM"
        btnDisarm.BackColor = SystemColors.Control

        btnLaunch.Enabled = False
        btnIgnite.Enabled = False
        btnAbort.Enabled = False
        btnCancel.Enabled = False
        btnOpenMain.Enabled = False

    End Sub

    Public Sub Launch_Mode()
        btnDisarm.BackColor = Color.Green
        btnDisarm.Text = "DISARMED"
        btnDisarm.Enabled = False
        btnArm.Enabled = True
        btnArm.Text = "ARM"
        btnArm.BackColor = SystemColors.Control

        btnLaunch.Enabled = True
        btnIgnite.Enabled = True
        btnAbort.Enabled = True
        btnCancel.Enabled = True
        btnOpenMain.Enabled = True
    End Sub

    Public Sub adjust_clm_width()
        Dim tWidth As Integer = dgvEvents.Size.Width
        Dim clm As DataGridViewColumn = dgvEvents.Columns(0)
        clm.Width = tWidth * 0.5
        Dim clm2 As DataGridViewColumn = dgvEvents.Columns(1)
        clm2.Width = tWidth * 0.4
    End Sub

    Public Function Send_Rec_DGV(ByVal sMess As String, ByRef dgv As DataGridView, ByRef dt As DataTable)
        Try
            Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
            Dim bytesSent As Integer = soc.Send(msg)
            Dim bytesRec As Integer = soc.Receive(bytes)
            dgv.DataSource = dt
            dt.Rows.Add(Encoding.ASCII.GetString(bytes, 0, bytesRec), Date.Now)
        Catch ex As Exception
            MessageBox.Show("Error processing request. Please check connection to server.")
        End Try
        Return bConnected
    End Function

    Private Sub btnArm_Click(sender As Object, e As EventArgs) Handles btnArm.Click
        Safety_Mode()
    End Sub

    Private Sub btnDisarm_Click(sender As Object, e As EventArgs) Handles btnDisarm.Click
        Launch_Mode()
    End Sub

    Private Sub FlightControlComputerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlightControlComputerToolStripMenuItem.Click
        Dim FCC As New Form
        FCC = frmFCC
        FCC.Show()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim settings As New Form
        settings = frmSettings
        settings.Show()
    End Sub

    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub btnOpenVents_Click(sender As Object, e As EventArgs) Handles btnOpenVents.Click
        Send_Rec_DGV("vents_open", dgvEvents, dt)
    End Sub

    Private Sub btnCloseVents_Click(sender As Object, e As EventArgs) Handles btnCloseVents.Click
        Send_Rec_DGV("vents_close", dgvEvents, dt)
    End Sub

    Private Sub btnOpenMain_Click(sender As Object, e As EventArgs) Handles btnOpenMain.Click
        Send_Rec_DGV("main_open", dgvEvents, dt)
    End Sub

    Private Sub btnCloseMain_Click(sender As Object, e As EventArgs) Handles btnCloseMain.Click
        Send_Rec_DGV("main_close", dgvEvents, dt)
    End Sub

    Private Sub btnIgnite_Click(sender As Object, e As EventArgs) Handles btnIgnite.Click
        Send_Rec_DGV("ign1_on", dgvEvents, dt)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Send_Rec_DGV("ign1_off", dgvEvents, dt)
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Send_Rec_DGV("launch", dgvEvents, dt)
    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        Send_Rec_DGV("abort", dgvEvents, dt)
    End Sub

    Public Function CheckIP(ByVal IP As String)
        Dim second_dig = IP.Chars(1)
        Dim addr As String = ""
        Try
            If second_dig = "0" Then
                addr = "10.240.232.31"
            Else
                addr = "192.168.1.1"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return addr
    End Function

    Private Sub btnNetworkInterface_Click(sender As Object, e As EventArgs) Handles btnNetworkInterface.Click
        Try
            Dim net_addr = CheckIP(txtIP.Text)
            Dim programName As String = "chrome.exe"
            Process.Start(programName, net_addr)
        Catch ex As Exception
            txtConsole.Text &= Environment.NewLine & ex.Message.ToString()
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim info As New Form
        info = frmAbout
        info.Show()
    End Sub

    Public Function Send_Rec_Label(ByVal sMess As String, ByRef lbl As Label, ByRef dt As DataTable)
        If bConnected = "True" Then
            Try
                Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
                Dim bytesSentlbl As Integer = soc.Send(msg)
                Dim bytesReclbl As Integer = soc.Receive(bytes)
                lbl.Text = Encoding.ASCII.GetString(bytes, 0, bytesReclbl)
            Catch ex As Exception
                gbVehicleStatus.Text = "Connection to vehicle lost"
                sensorTimer.Stop()
                reset_sensors()
            End Try
        Else
            bConnected = "False"
        End If
        Return bConnected
    End Function

    Public Function Send_Rec_LinearGuage(ByVal sMess As String, ByRef lg As LinearGauge, ByRef dt As DataTable)
        If bConnected = "True" Then
            Try
                Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
                Dim bytesSentlbl As Integer = soc.Send(msg)
                Dim bytesReclbl As Integer = soc.Receive(bytes)
                lg.Value = Encoding.ASCII.GetString(bytes, 0, bytesReclbl)
            Catch ex As Exception
                gbVehicleStatus.Text = "Connection to vehicle lost"
                sensorTimer.Stop()
                reset_sensors()
            End Try
        Else
            bConnected = "False"
        End If
        Return bConnected
    End Function

    Private Sub sensorTimer_Tick(sender As Object, e As EventArgs) Handles sensorTimer.Tick
        Try
            Send_Rec_Label("temp_status", lblThermo, dt)
            Send_Rec_Label("bwire_status", lblBwire, dt)
            Send_Rec_Label("kero_status", lblKero, dt)
            Send_Rec_Label("LOX_status", lblLOX, dt)
            Send_Rec_Label("main_status", lblMPV, dt)

            Dim good_val As Boolean = True
            Dim iThermo As Double
            Try
                iThermo = Convert.ToDouble(lblThermo.Text)
            Catch ex As Exception
                good_val = False
            End Try

            If good_val = True Then
                If iThermo > 200 Then
                    lblThermo.BackColor = Color.Green
                ElseIf iThermo < 200 Then
                    lblThermo.BackColor = Color.Red
                Else
                    lblThermo.BackColor = Color.Yellow
                End If
            End If

            If lblLOX.Text = "Open" Then
                lblLOX.BackColor = Color.Red
            Else
                lblLOX.BackColor = Color.Green
            End If

            If lblMPV.Text = "Open" Then
                lblMPV.BackColor = Color.Red
            Else
                lblMPV.BackColor = Color.Green
            End If

            If lblBwire.Text = "Open" Then
                lblBwire.BackColor = Color.Red
            Else
                lblBwire.BackColor = Color.Green
            End If

            If lblKero.Text = "Open" Then
                lblKero.BackColor = Color.Red
            Else
                lblKero.BackColor = Color.Green
            End If

            If lblThermo.Text = "Broken" Then
                lblThermo.BackColor = Color.Green
            Else
                lblThermo.BackColor = Color.Red
            End If

            gbVehicleStatus.Text = "Vehicle Sensors (Connected)"
        Catch ex As Exception
            gbVehicleStatus.Text = "Vehicle Sensors (Disconnected)"
        End Try
    End Sub

    Private Sub startSensors_Click(sender As Object, e As EventArgs) Handles startSensors.Click
        If bConnected = True Then
            Try
                sensorTimer.Start()
            Catch ex As Exception
                reset_sensors()
            End Try
        End If
    End Sub

    Private Sub stopSensors_Click(sender As Object, e As EventArgs) Handles stopSensors.Click
        If bConnected = True Then
            Try
                sensorTimer.Stop()
                reset_sensors()
            Catch ex As Exception
                reset_sensors()
            End Try
        End If
    End Sub

    Private Sub resetSensors_Click(sender As Object, e As EventArgs) Handles resetSensors.Click
        If bConnected = True Then
            Try
                sensorTimer.Stop()
                reset_sensors()
                sensorTimer.Start()
            Catch ex As Exception
                reset_sensors()
            End Try
        End If
    End Sub

    Public Sub reset_sensors()
        gbVehicleStatus.Text = "Vehicle Sensors (Disconnected)"

        lblLOX.BackColor = SystemColors.Control
        lblKero.BackColor = SystemColors.Control
        lblMPV.BackColor = SystemColors.Control
        lblBwire.BackColor = SystemColors.Control
        lblThermo.BackColor = SystemColors.Control

        lblLOX.Text = "--"
        lblMPV.Text = "--"
        lblBwire.Text = "--"
        lblKero.Text = "--"
        lblThermo.Text = "--"
    End Sub

    Private Sub StaticTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaticTestToolStripMenuItem.Click
        opMode = "Static"
        startSensors.Enabled = True
        stopSensors.Enabled = True
        resetSensors.Enabled = True
        My.Settings.OpMode = opMode
    End Sub

    Private Sub LaunchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchToolStripMenuItem.Click
        opMode = "Launch"
        startSensors.Enabled = True
        stopSensors.Enabled = True
        resetSensors.Enabled = True
        My.Settings.OpMode = opMode
    End Sub

    Private Sub loadCell_Click(sender As Object, e As EventArgs) Handles loadCell.Click
        Dim loadcell As New Form
        loadcell = frmLoadCell
        loadcell.Show()
    End Sub

    Private Sub TestingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestingToolStripMenuItem.Click
        opMode = "Testing"
        startSensors.Enabled = False
        stopSensors.Enabled = False
        resetSensors.Enabled = False
        My.Settings.OpMode = opMode
    End Sub

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        updateTimer.Stop()
        Dim t As Integer = txtCount.Text
        lblTime.Text = "T-minus: " + t.ToString()
        countdownTimer.Start()
        btnBegin.Enabled = False
        txtCount.Enabled = False
    End Sub

    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        Dim time As Integer = txtCount.Text
        Dim t As Integer
        If time > 0 Then
            time = time - 1
            txtCount.Text = time
            t = Abs(time)
            lblTime.Text = "T-minus: " + t.ToString()
        Else
            time = time - 1
            txtCount.Text = time
            t = Abs(time)
            lblTime.Text = "T-plus: " + t.ToString()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        countdownTimer.Stop()
        btnBegin.Enabled = True
        txtCount.Enabled = True
        txtCount.Text = "0"
        updateTimer.Start()
    End Sub

End Class