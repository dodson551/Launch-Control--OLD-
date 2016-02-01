Imports System.Net
Imports System.Net.Sockets
Imports System.Text

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

    Dim bytes(1024) As Byte
    Dim ipAddress As IPAddress = Nothing
    Dim port As Integer = Nothing
    Dim soc As Socket


    Private Sub frmLCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Safety_Mode()
        updateTimer.Start()
        dt.Columns.Add("Events")
        dt.Columns.Add("Timestamp")
        txtConsole.Text = "Waiting to establish server connection..."
        txtIP.Text = My.Settings.IP.ToString()
        txtPort.Text = My.Settings.Port.ToString()
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
                    My.Settings.IP = txtIP.Text
                    My.Settings.Port = txtPort.Text
                    My.Settings.Save()
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
            If My.Computer.Network.Ping(txtIP.Text) Then
                txtConsole.Text &= Environment.NewLine & "Server pinged successfully."
            Else
                txtConsole.Text &= Environment.NewLine & "Ping request timed out."
            End If
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
        lblTime.Text = DateTime.Now.ToString()
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


End Class