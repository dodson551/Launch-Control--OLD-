'====================================================
'
' Things to do for flight control computer
'
'  Things to do next TIME::::
'    + Complete the GUI layout
'    + Find a way to loop the Listen() function so that we can receive live data readouts!
'    + Also Fix original Send_Receive Function to make sure it works for regular tests
'
'
'====================================================
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class frmFCC
    Dim ipAddr As IPAddress
    Dim port As Integer
    Dim fccSocket As Socket
    Dim fccTCP As TcpClient
    Dim dt As DataTable = New DataTable()
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_IPAddress.TextChanged

    End Sub

    Private Sub frmFCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_IPAddress.Text = My.Settings.FCC_IP
        tb_Port.Text = My.Settings.FCC_Port
        lb_ConnectionStatus.Items.Add("Waiting to connect to network...")
        'lb_ConnectionStatus.Enabled = False ' makes Connection status box read only

        dt.Columns.Add("Events")
        dt.Columns.Add("Time Stamp")
    End Sub

    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click
        ' copied most of the connection code from Jake's main LCS connection functions
        Try
            ' creates socket to make connection
            ipAddr = IPAddress.Parse(tb_IPAddress.Text)
            port = tb_Port.Text
            fccSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            Dim result = fccSocket.BeginConnect(ipAddr, port, Nothing, Nothing)
            Dim success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))

            ' if the connection isnt successful, notify the user via ConnectionStatus Box
            If Not success Then
                lb_ConnectionStatus.Items.Add("Error Connecting to " & tb_IPAddress.Text.ToString())

            Else
                'if the connection is successful then stop the user from changing the connection info
                tb_IPAddress.Enabled = False
                tb_Port.Enabled = False
                btn_Connect.Enabled = False

                ' notify user of connection success
                lb_ConnectionStatus.Items.Add("Connection Established. " & DateTime.Now.ToShortTimeString())

            End If


        Catch ex As Exception
            lb_ConnectionStatus.Items.Add("Error making the connection... Please Try Again.")

        End Try

    End Sub

    Private Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click

        Dim msg = "hi"
        Dim receiptStr = Send(msg)

        If receiptStr = "hello" Then
            lb_ConnectionStatus.Items.Add("Connection Test Successful!" & DateTime.Now.ToShortTimeString())
        Else
            lb_ConnectionStatus.Items.Add("Connection Test Failed... Did not receive a response" & DateTime.Now.ToShortTimeString())
        End If
    End Sub

    ''' <summary>
    ''' This function will serve as the basic send and receive for the socket connection. 
    ''' </summary>
    ''' <param name="sendThis"></param>
    ''' <returns> the message received from the server </returns>
    Public Function Send(sendThis As String) 'As String
        Try
            Dim message As Byte() = Encoding.ASCII.GetBytes(sendThis) ' converts string to ASCII bytes
            Dim returnedMsg As String = Nothing
            dgv_FCC.DataSource = dt ' make sure all data is printing to DGV
            fccSocket.Send(message) ' sends byte array over socket connection

            'Do
            '    returnedMsg = Listen()
            '    dt.Rows.Add(returnedMsg)
            'Loop Until returnedMsg = "Complete"


            ' AddRowsToDGV("Message Sent: ")

            'Dim receipt(1024) As Byte
            'Dim receivedMsgLength As Integer = fccSocket.Receive(receipt) ' gets size and bytes 

            'Dim receiptStr As String = Encoding.ASCII.GetString(receipt, 0, receivedMsgLength) ' converts message to string

            'dt.Rows.Add("Message Received: " & receiptStr & " " & DateTime.Now.ToShortTimeString())

            Return Nothing

        Catch ex As Exception
            AddRowsToDGV("Error sending the message.  Try again!")
            Return Nothing
        End Try

    End Function
    ''' <summary>
    ''' Tries to receive live stream from server
    ''' </summary>
    ''' <returns></returns>
    Public Function Listen() As String
        Try
            Dim receipt(1024) As Byte
            Dim receivedMsgLength As Integer = fccSocket.Receive(receipt) ' gets size and bytes of returned msg

            Dim receiptStr As String = Encoding.ASCII.GetString(receipt, 0, receivedMsgLength) ' converts message to string

            'AddRowsToDGV(receiptStr)

            Return receiptStr

        Catch ex As Exception
            AddRowsToDGV("Error Listening to Connection")
            Return Nothing
        End Try
    End Function

    Public Function Send_Receive(sendThis As String) As String
        Try
            Dim message As Byte() = Encoding.ASCII.GetBytes(sendThis) ' converts string to ASCII bytes
            Dim returnedMsg As String = Nothing
            dgv_FCC.DataSource = dt ' make sure all data is printing to DGV
            fccSocket.Send(message) ' sends byte array over socket connection

            Dim receipt(1024) As Byte
            Dim receivedMsgLength As Integer = fccSocket.Receive(receipt) ' gets size and bytes 

            Dim receiptStr As String = Encoding.ASCII.GetString(receipt, 0, receivedMsgLength) ' converts message to string

            AddRowsToDGV("Message Received: ")

            Return receiptStr
        Catch ex As Exception
            dt.Rows.Add("error sending the message.  try again {0}", DateTime.Now)
        End Try

    End Function

    Private Sub btn_Disconnect_Click(sender As Object, e As EventArgs) Handles btn_Disconnect.Click
        Try
            fccSocket.Shutdown(SocketShutdown.Both)
            Dim dis_result = fccSocket.BeginDisconnect(True, Nothing, Nothing)
            Dim dis_success = dis_result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
            If Not dis_success Then
                lb_ConnectionStatus.Items.Add("Client software was not able to disconnect successfully. Please try again." & DateTime.Now.ToShortTimeString())
            Else
                lb_ConnectionStatus.Items.Add("Connection Successfully Disconnected..." & DateTime.Now.ToShortTimeString())
                btn_Connect.Enabled = True
                tb_IPAddress.Enabled = True
                tb_Port.Enabled = True

            End If
        Catch ex As Exception
            lb_ConnectionStatus.Items.Add(ex.Message & DateTime.Now.ToShortTimeString())
        End Try
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btn_X_Click(sender As Object, e As EventArgs) Handles btn_X.Click
        Dim sendThisMsg As String = "x_pattern"
        Send(sendThisMsg)
        Dim returnedMsg As String = Listen()

        If returnedMsg = "X Function Started." Then
            AddRowsToDGV(returnedMsg)
        Else
            AddRowsToDGV("Error Receiving X Pattern return message.  Check X Pattern status on server.")
        End If
    End Sub

    Private Sub btn_Circle_Click(sender As Object, e As EventArgs) Handles btn_Circle.Click
        Dim sendThisMsg As String = "circle"
        Dim returnedMsg As String = Send(sendThisMsg)

        If returnedMsg = "Complete" Then
            AddRowsToDGV("Circle Pattern Complete")
        Else
            AddRowsToDGV("Error Receiving Circle Pattern return message.  Check Circle Pattern status on server.")

        End If
    End Sub

    Private Sub btn_PID_Click(sender As Object, e As EventArgs) Handles btn_PID.Click
        Dim sendThisMsg As String = "PID"
        Dim returnedMsg As String = Send(sendThisMsg)

        If returnedMsg = "PID Program started successfully." Then
            AddRowsToDGV(returnedMsg)
        Else
            AddRowsToDGV("Error Receiving PID return message.  Check PID status on server.")
        End If
    End Sub

    Private Sub btn_Center_Click(sender As Object, e As EventArgs) Handles btn_Center.Click
        Dim sendThisMsg As String = "center"
        Dim returnedMsg As String = Nothing
        Dim timeoutCounter As Int32 = 0
        Send(sendThisMsg) ' sends center command to server
        returnedMsg = Listen() ' waits for response
        AddRowsToDGV(returnedMsg) ' adds response to dgv

        ' if the returnedMsg is Center Pattern STring, then send "Clear To Send"
        If returnedMsg = "Center Pattern Starting" Then
            Send("CTS") ' lets server know to begin data transmission
            While True
                returnedMsg = Listen() ' gets response
                If returnedMsg = "Complete" Then ' if response is "Complete", Exit the loop
                    Exit While
                End If

                ' otherwise let's parse the data and display it in the gauge
                Dim temp As Int32
                Int32.TryParse(returnedMsg, temp)
                lg_Data.Value = temp
                lg_Data.RepaintControl()

                ' AddRowsToDGV(returnedMsg)

                ' send ACKnowledgement to server to get next transmission
                Send("ACK")

            End While

            If returnedMsg = Nothing Then
                AddRowsToDGV("Heard Nothing, Check Centering Status")
            Else
                AddRowsToDGV("Centering Complete")
            End If
        End If

    End Sub

    Private Sub btn_Abort_Click(sender As Object, e As EventArgs) Handles btn_Abort.Click
        Dim sendThisMsg As String = "abort"
        Dim returnedMsg As String = Send(sendThisMsg)

        If returnedMsg = "Aborting..." Then
            dt.Rows.Add(returnedMsg & DateTime.Now.ToShortTimeString())
            dgv_FCC.DataSource = dt
        Else
            dt.Rows.Add("Error Receiving Abort return message.  Check Abort status on server.")
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_OpenValve1_Click(sender As Object, e As EventArgs) Handles btn_OpenValve1.Click

    End Sub
    Public Sub AdjustDGV()
        Dim tWidth As Integer = dgv_FCC.Size.Width
        Dim clm As DataGridViewColumn = dgv_FCC.Columns(0)
        clm.Width = tWidth * 0.7
        Dim clm2 As DataGridViewColumn = dgv_FCC.Columns(1)
        clm2.Width = tWidth * 0.2

        ' follows most recent row in dgv
        dgv_FCC.FirstDisplayedScrollingRowIndex = dgv_FCC.RowCount - 1
    End Sub

    Public Sub AddRowsToDGV(message As String)
        Dim dtRow As DataRow = dt.NewRow()
        dtRow(0) = message
        dtRow(1) = DateTime.Now.ToShortTimeString()
        dt.Rows.Add(dtRow)
        dgv_FCC.DataSource = dt
        AdjustDGV()
    End Sub

    Private Sub lg_Data_Click(sender As Object, e As EventArgs) Handles lg_Data.Click

    End Sub
End Class