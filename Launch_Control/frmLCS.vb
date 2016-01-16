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
                    'dgvEvents.DataSource = dt
                    'dt.Rows.Add(Me.Text, Date.Now)
                    btnConnect.Enabled = False
                    txtIP.Enabled = False
                    txtPort.Enabled = False
                    btnDisconnect.Enabled = True
                    btnPing.Enabled = True
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
                    'dgvEvents.DataSource = dt
                    'dt.Rows.Add(Me.Text, Date.Now)
                    btnConnect.Enabled = True
                    btnDisconnect.Enabled = False
                    txtIP.Enabled = True
                    txtPort.Enabled = True
                    btnPing.Enabled = False
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
    End Sub

    Private Sub btnArm_Click(sender As Object, e As EventArgs) Handles btnArm.Click
        Safety_Mode()
    End Sub

    Private Sub btnDisarm_Click(sender As Object, e As EventArgs) Handles btnDisarm.Click
        Launch_Mode()
    End Sub







End Class