<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFCC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFCC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_IPAddress = New System.Windows.Forms.TextBox()
        Me.gb_NetworkConnections = New System.Windows.Forms.GroupBox()
        Me.btn_Test = New System.Windows.Forms.Button()
        Me.btn_Disconnect = New System.Windows.Forms.Button()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.tb_Port = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Center = New System.Windows.Forms.Button()
        Me.btn_Abort = New System.Windows.Forms.Button()
        Me.btn_X = New System.Windows.Forms.Button()
        Me.btn_Circle = New System.Windows.Forms.Button()
        Me.btn_PID = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lb_ConnectionStatus = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgv_FCC = New System.Windows.Forms.DataGridView()
        Me.btn_OpenValve1 = New System.Windows.Forms.Button()
        Me.btn_OpenValve2 = New System.Windows.Forms.Button()
        Me.btn_CloseValve2 = New System.Windows.Forms.Button()
        Me.btn_CloseValve1 = New System.Windows.Forms.Button()
        Me.gb_NetworkConnections.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv_FCC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address:"
        '
        'tb_IPAddress
        '
        Me.tb_IPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.tb_IPAddress.Location = New System.Drawing.Point(149, 17)
        Me.tb_IPAddress.Name = "tb_IPAddress"
        Me.tb_IPAddress.Size = New System.Drawing.Size(257, 32)
        Me.tb_IPAddress.TabIndex = 1
        '
        'gb_NetworkConnections
        '
        Me.gb_NetworkConnections.Controls.Add(Me.btn_Test)
        Me.gb_NetworkConnections.Controls.Add(Me.btn_Disconnect)
        Me.gb_NetworkConnections.Controls.Add(Me.btn_Connect)
        Me.gb_NetworkConnections.Controls.Add(Me.tb_Port)
        Me.gb_NetworkConnections.Controls.Add(Me.Label2)
        Me.gb_NetworkConnections.Controls.Add(Me.Label1)
        Me.gb_NetworkConnections.Controls.Add(Me.tb_IPAddress)
        Me.gb_NetworkConnections.Location = New System.Drawing.Point(12, 12)
        Me.gb_NetworkConnections.Name = "gb_NetworkConnections"
        Me.gb_NetworkConnections.Size = New System.Drawing.Size(632, 106)
        Me.gb_NetworkConnections.TabIndex = 2
        Me.gb_NetworkConnections.TabStop = False
        Me.gb_NetworkConnections.Text = "Network Connections"
        '
        'btn_Test
        '
        Me.btn_Test.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Test.Location = New System.Drawing.Point(484, 55)
        Me.btn_Test.Name = "btn_Test"
        Me.btn_Test.Size = New System.Drawing.Size(95, 36)
        Me.btn_Test.TabIndex = 6
        Me.btn_Test.Text = "Test"
        Me.btn_Test.UseVisualStyleBackColor = True
        '
        'btn_Disconnect
        '
        Me.btn_Disconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Disconnect.Location = New System.Drawing.Point(275, 55)
        Me.btn_Disconnect.Name = "btn_Disconnect"
        Me.btn_Disconnect.Size = New System.Drawing.Size(131, 36)
        Me.btn_Disconnect.TabIndex = 5
        Me.btn_Disconnect.Text = "Disconnect"
        Me.btn_Disconnect.UseVisualStyleBackColor = True
        '
        'btn_Connect
        '
        Me.btn_Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Connect.Location = New System.Drawing.Point(149, 55)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(120, 36)
        Me.btn_Connect.TabIndex = 4
        Me.btn_Connect.Text = "Connect"
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'tb_Port
        '
        Me.tb_Port.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.tb_Port.Location = New System.Drawing.Point(484, 17)
        Me.tb_Port.Name = "tb_Port"
        Me.tb_Port.Size = New System.Drawing.Size(126, 32)
        Me.tb_Port.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(420, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_CloseValve2)
        Me.GroupBox1.Controls.Add(Me.btn_CloseValve1)
        Me.GroupBox1.Controls.Add(Me.btn_OpenValve2)
        Me.GroupBox1.Controls.Add(Me.btn_OpenValve1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(339, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 308)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RCS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_Center)
        Me.GroupBox3.Controls.Add(Me.btn_Abort)
        Me.GroupBox3.Controls.Add(Me.btn_X)
        Me.GroupBox3.Controls.Add(Me.btn_Circle)
        Me.GroupBox3.Controls.Add(Me.btn_PID)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 308)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Test Sequences"
        '
        'btn_Center
        '
        Me.btn_Center.Location = New System.Drawing.Point(166, 124)
        Me.btn_Center.Name = "btn_Center"
        Me.btn_Center.Size = New System.Drawing.Size(126, 63)
        Me.btn_Center.TabIndex = 3
        Me.btn_Center.Text = "Center"
        Me.btn_Center.UseVisualStyleBackColor = True
        '
        'btn_Abort
        '
        Me.btn_Abort.Location = New System.Drawing.Point(22, 214)
        Me.btn_Abort.Name = "btn_Abort"
        Me.btn_Abort.Size = New System.Drawing.Size(270, 63)
        Me.btn_Abort.TabIndex = 4
        Me.btn_Abort.Text = "ABORT"
        Me.btn_Abort.UseVisualStyleBackColor = True
        '
        'btn_X
        '
        Me.btn_X.Location = New System.Drawing.Point(22, 34)
        Me.btn_X.Name = "btn_X"
        Me.btn_X.Size = New System.Drawing.Size(126, 63)
        Me.btn_X.TabIndex = 0
        Me.btn_X.Text = "X"
        Me.btn_X.UseVisualStyleBackColor = True
        '
        'btn_Circle
        '
        Me.btn_Circle.Image = CType(resources.GetObject("btn_Circle.Image"), System.Drawing.Image)
        Me.btn_Circle.Location = New System.Drawing.Point(166, 34)
        Me.btn_Circle.Name = "btn_Circle"
        Me.btn_Circle.Size = New System.Drawing.Size(126, 63)
        Me.btn_Circle.TabIndex = 1
        Me.btn_Circle.UseVisualStyleBackColor = True
        '
        'btn_PID
        '
        Me.btn_PID.Location = New System.Drawing.Point(22, 124)
        Me.btn_PID.Name = "btn_PID"
        Me.btn_PID.Size = New System.Drawing.Size(126, 63)
        Me.btn_PID.TabIndex = 2
        Me.btn_PID.Text = "PID"
        Me.btn_PID.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lb_ConnectionStatus)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(632, 104)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Connection Status"
        '
        'lb_ConnectionStatus
        '
        Me.lb_ConnectionStatus.BackColor = System.Drawing.Color.Black
        Me.lb_ConnectionStatus.ForeColor = System.Drawing.Color.Lime
        Me.lb_ConnectionStatus.FormattingEnabled = True
        Me.lb_ConnectionStatus.Location = New System.Drawing.Point(6, 15)
        Me.lb_ConnectionStatus.Name = "lb_ConnectionStatus"
        Me.lb_ConnectionStatus.Size = New System.Drawing.Size(620, 82)
        Me.lb_ConnectionStatus.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgv_FCC)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 548)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(632, 308)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Test Sequence Status"
        '
        'dgv_FCC
        '
        Me.dgv_FCC.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgv_FCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_FCC.Location = New System.Drawing.Point(6, 31)
        Me.dgv_FCC.Name = "dgv_FCC"
        Me.dgv_FCC.Size = New System.Drawing.Size(620, 271)
        Me.dgv_FCC.TabIndex = 6
        '
        'btn_OpenValve1
        '
        Me.btn_OpenValve1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btn_OpenValve1.Location = New System.Drawing.Point(6, 34)
        Me.btn_OpenValve1.Name = "btn_OpenValve1"
        Me.btn_OpenValve1.Size = New System.Drawing.Size(145, 63)
        Me.btn_OpenValve1.TabIndex = 0
        Me.btn_OpenValve1.Text = "Open Valve 1"
        Me.btn_OpenValve1.UseVisualStyleBackColor = True
        '
        'btn_OpenValve2
        '
        Me.btn_OpenValve2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btn_OpenValve2.Location = New System.Drawing.Point(154, 34)
        Me.btn_OpenValve2.Name = "btn_OpenValve2"
        Me.btn_OpenValve2.Size = New System.Drawing.Size(145, 63)
        Me.btn_OpenValve2.TabIndex = 8
        Me.btn_OpenValve2.Text = "Open Valve 2"
        Me.btn_OpenValve2.UseVisualStyleBackColor = True
        '
        'btn_CloseValve2
        '
        Me.btn_CloseValve2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btn_CloseValve2.Location = New System.Drawing.Point(154, 124)
        Me.btn_CloseValve2.Name = "btn_CloseValve2"
        Me.btn_CloseValve2.Size = New System.Drawing.Size(145, 63)
        Me.btn_CloseValve2.TabIndex = 10
        Me.btn_CloseValve2.Text = "Close Valve 2"
        Me.btn_CloseValve2.UseVisualStyleBackColor = True
        '
        'btn_CloseValve1
        '
        Me.btn_CloseValve1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btn_CloseValve1.Location = New System.Drawing.Point(6, 124)
        Me.btn_CloseValve1.Name = "btn_CloseValve1"
        Me.btn_CloseValve1.Size = New System.Drawing.Size(145, 63)
        Me.btn_CloseValve1.TabIndex = 9
        Me.btn_CloseValve1.Text = "Close Valve 1"
        Me.btn_CloseValve1.UseVisualStyleBackColor = True
        '
        'frmFCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_NetworkConnections)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmFCC"
        Me.Text = "frmFCC"
        Me.gb_NetworkConnections.ResumeLayout(False)
        Me.gb_NetworkConnections.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgv_FCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_IPAddress As TextBox
    Friend WithEvents gb_NetworkConnections As GroupBox
    Friend WithEvents btn_Disconnect As Button
    Friend WithEvents btn_Connect As Button
    Friend WithEvents tb_Port As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Abort As Button
    Friend WithEvents btn_Center As Button
    Friend WithEvents btn_PID As Button
    Friend WithEvents btn_Circle As Button
    Friend WithEvents btn_X As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lb_ConnectionStatus As ListBox
    Friend WithEvents btn_Test As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgv_FCC As DataGridView
    Friend WithEvents btn_CloseValve2 As Button
    Friend WithEvents btn_CloseValve1 As Button
    Friend WithEvents btn_OpenValve2 As Button
    Friend WithEvents btn_OpenValve1 As Button
End Class
