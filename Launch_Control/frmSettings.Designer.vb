<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtOpMode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCountdownTimer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFCC_IP = New System.Windows.Forms.TextBox()
        Me.txtFCC_Port = New System.Windows.Forms.TextBox()
        Me.txtFCC_Hostname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLCS_IP = New System.Windows.Forms.TextBox()
        Me.txtLCS_Port = New System.Windows.Forms.TextBox()
        Me.txtLCS_Hostname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(434, 611)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 369)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(428, 177)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Other Settings"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txtOpMode, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txtCountdownTimer, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.txtFileName, 1, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 26)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(422, 148)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'txtOpMode
        '
        Me.txtOpMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpMode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpMode.Location = New System.Drawing.Point(150, 3)
        Me.txtOpMode.Name = "txtOpMode"
        Me.txtOpMode.Size = New System.Drawing.Size(269, 26)
        Me.txtOpMode.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 37)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "OpMode:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 37)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Countdown:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCountdownTimer
        '
        Me.txtCountdownTimer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCountdownTimer.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountdownTimer.Location = New System.Drawing.Point(150, 40)
        Me.txtCountdownTimer.Name = "txtCountdownTimer"
        Me.txtCountdownTimer.Size = New System.Drawing.Size(269, 26)
        Me.txtCountdownTimer.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 37)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Filename:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFileName
        '
        Me.txtFileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFileName.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(150, 77)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(269, 26)
        Me.txtFileName.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 177)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flight Control Computer Settings"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtFCC_IP, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtFCC_Port, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtFCC_Hostname, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 26)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(422, 148)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 37)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "FCC Hostname:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 37)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "FCC Port:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFCC_IP
        '
        Me.txtFCC_IP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFCC_IP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFCC_IP.Location = New System.Drawing.Point(150, 3)
        Me.txtFCC_IP.Name = "txtFCC_IP"
        Me.txtFCC_IP.Size = New System.Drawing.Size(269, 26)
        Me.txtFCC_IP.TabIndex = 0
        '
        'txtFCC_Port
        '
        Me.txtFCC_Port.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFCC_Port.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFCC_Port.Location = New System.Drawing.Point(150, 40)
        Me.txtFCC_Port.Name = "txtFCC_Port"
        Me.txtFCC_Port.Size = New System.Drawing.Size(269, 26)
        Me.txtFCC_Port.TabIndex = 1
        '
        'txtFCC_Hostname
        '
        Me.txtFCC_Hostname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFCC_Hostname.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFCC_Hostname.Location = New System.Drawing.Point(150, 77)
        Me.txtFCC_Hostname.Name = "txtFCC_Hostname"
        Me.txtFCC_Hostname.Size = New System.Drawing.Size(269, 26)
        Me.txtFCC_Hostname.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 37)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "FCC IP:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 552)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(428, 56)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(217, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(208, 50)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset Fields"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(208, 50)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 177)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Launch Control Connection Settings"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtLCS_IP, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtLCS_Port, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtLCS_Hostname, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 26)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(422, 148)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LCS Hostname:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "LCS Port:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLCS_IP
        '
        Me.txtLCS_IP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLCS_IP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLCS_IP.Location = New System.Drawing.Point(150, 3)
        Me.txtLCS_IP.Name = "txtLCS_IP"
        Me.txtLCS_IP.Size = New System.Drawing.Size(269, 26)
        Me.txtLCS_IP.TabIndex = 0
        '
        'txtLCS_Port
        '
        Me.txtLCS_Port.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLCS_Port.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLCS_Port.Location = New System.Drawing.Point(150, 40)
        Me.txtLCS_Port.Name = "txtLCS_Port"
        Me.txtLCS_Port.Size = New System.Drawing.Size(269, 26)
        Me.txtLCS_Port.TabIndex = 1
        '
        'txtLCS_Hostname
        '
        Me.txtLCS_Hostname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLCS_Hostname.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLCS_Hostname.Location = New System.Drawing.Point(150, 77)
        Me.txtLCS_Hostname.Name = "txtLCS_Hostname"
        Me.txtLCS_Hostname.Size = New System.Drawing.Size(269, 26)
        Me.txtLCS_Hostname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LCS IP:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 611)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(450, 650)
        Me.MinimumSize = New System.Drawing.Size(450, 650)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLCS_IP As TextBox
    Friend WithEvents txtLCS_Port As TextBox
    Friend WithEvents txtLCS_Hostname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFCC_IP As TextBox
    Friend WithEvents txtFCC_Port As TextBox
    Friend WithEvents txtFCC_Hostname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txtOpMode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCountdownTimer As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFileName As TextBox
End Class
