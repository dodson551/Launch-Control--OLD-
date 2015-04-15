Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO

Public Class cTCP_Connection

  Dim client As New TcpClient
  Dim bytes(1024) As Byte
  Dim ipAddress As IPAddress = Nothing
  Dim port As Integer = Nothing
  Dim soc As Socket
  Dim bConnected As Boolean = False

  Public Function Connect_TCP(ByVal IP As String, ByVal PORT As Integer, ByRef FORM As Form)
    soc = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    Try
      Dim result = soc.BeginConnect(IP, PORT, Nothing, Nothing)
      Dim success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
      If Not success Then
        MsgBox("Connection attempt refused. Check IP, Port, and server status are all correct.")
      Else
        bConnected = True
        FORM.Text = "Connected to board at: " & IP
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
    Return bConnected
  End Function

  Public Function DisConnect_TCP(ByRef IP As String, ByRef FORM As Form)
    If bConnected = True Then
      Try
        soc.Shutdown(SocketShutdown.Both)
        Dim dis_result = soc.BeginDisconnect(True, Nothing, Nothing)
        Dim dis_success = dis_result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3))
        If Not dis_success Then
          MsgBox("Client software was not able to disconnect successfully. Please try again.")
        Else
          bConnected = False
          FORM.Text = "Disconnected from board: " & IP
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try
    End If
    Return bConnected
  End Function

  Public Function Send_Rec_DGV(ByVal sMess As String, ByRef dgv As DataGridView, ByRef dt As DataTable)
    If bConnected = True Then
      Try
        Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
        Dim bytesSent As Integer = soc.Send(msg)
        Dim bytesRec As Integer = soc.Receive(bytes)
        dgv.DataSource = dt
        dt.Rows.Add(Encoding.ASCII.GetString(bytes, 0, bytesRec), Date.Now)
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try
    Else
      MsgBox("Request not completed. Check server status.")
    End If
    Return bConnected
  End Function

  Public Function Send_Rec_Label(ByVal sMess As String, ByRef lbl As Label, ByRef dt As DataTable)
    If bConnected = True Then
      Try
        Dim msg As Byte() = Encoding.ASCII.GetBytes(sMess)
        Dim bytesSentlbl As Integer = soc.Send(msg)
        Dim bytesReclbl As Integer = soc.Receive(bytes)
        lbl.Text = Encoding.ASCII.GetString(bytes, 0, bytesReclbl)
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try
    Else
      MsgBox("Request not completed. Check server status.")
    End If
    Return bConnected
  End Function

End Class
