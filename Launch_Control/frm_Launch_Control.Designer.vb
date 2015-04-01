<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
    Me.tlpBackground = New System.Windows.Forms.TableLayoutPanel()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.tlpmain = New System.Windows.Forms.TableLayoutPanel()
    Me.tlpCmd = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnLaunch = New AutoScaleButton.AutoScaleButton()
    Me.btnAbort = New AutoScaleButton.AutoScaleButton()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnIgn1On = New AutoScaleButton.AutoScaleButton()
    Me.btnIgn1Off = New AutoScaleButton.AutoScaleButton()
    Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    Me.pbSafety = New System.Windows.Forms.PictureBox()
    Me.btnVentClose = New AutoScaleButton.AutoScaleButton()
    Me.btnIgn2Off = New AutoScaleButton.AutoScaleButton()
    Me.btnVentOpen = New AutoScaleButton.AutoScaleButton()
    Me.btnIgn2On = New AutoScaleButton.AutoScaleButton()
    Me.PictureBox3 = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.txtPort = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtIP = New System.Windows.Forms.TextBox()
    Me.btnDisconnect = New AutoScaleButton.AutoScaleButton()
    Me.btnConnect = New AutoScaleButton.AutoScaleButton()
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
    Me.dgvEvents = New System.Windows.Forms.DataGridView()
    Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnCameraCtl = New AutoScaleButton.AutoScaleButton()
    Me.btnSensorReads = New AutoScaleButton.AutoScaleButton()
    Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
    Me.PictureBox5 = New System.Windows.Forms.PictureBox()
    Me.PictureBox7 = New System.Windows.Forms.PictureBox()
    Me.lblKeroValve = New System.Windows.Forms.Label()
    Me.PictureBox6 = New System.Windows.Forms.PictureBox()
    Me.PictureBox9 = New System.Windows.Forms.PictureBox()
    Me.PictureBox10 = New System.Windows.Forms.PictureBox()
    Me.PictureBox11 = New System.Windows.Forms.PictureBox()
    Me.lblThermo = New System.Windows.Forms.Label()
    Me.lblLOXValve = New System.Windows.Forms.Label()
    Me.lblBwire = New System.Windows.Forms.Label()
    Me.lblMainValves = New System.Windows.Forms.Label()
    Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnPoEOff = New AutoScaleButton.AutoScaleButton()
    Me.btnPoEOn = New AutoScaleButton.AutoScaleButton()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.tlpBackground.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tlpmain.SuspendLayout()
    Me.tlpCmd.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pbSafety, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel4.SuspendLayout()
    CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel5.SuspendLayout()
    Me.TableLayoutPanel6.SuspendLayout()
    CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel8.SuspendLayout()
    Me.SuspendLayout()
    '
    'tlpBackground
    '
    Me.tlpBackground.BackColor = System.Drawing.Color.Black
    Me.tlpBackground.ColumnCount = 1
    Me.tlpBackground.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tlpBackground.Controls.Add(Me.PictureBox1, 0, 0)
    Me.tlpBackground.Controls.Add(Me.tlpmain, 0, 1)
    Me.tlpBackground.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tlpBackground.Location = New System.Drawing.Point(0, 0)
    Me.tlpBackground.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.tlpBackground.Name = "tlpBackground"
    Me.tlpBackground.RowCount = 2
    Me.tlpBackground.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
    Me.tlpBackground.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
    Me.tlpBackground.Size = New System.Drawing.Size(1898, 1024)
    Me.tlpBackground.TabIndex = 0
    '
    'PictureBox1
    '
    Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox1.Image = Global.Launch_Control.My.Resources.Resources.title_2
    Me.PictureBox1.Location = New System.Drawing.Point(4, 5)
    Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(1890, 143)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'tlpmain
    '
    Me.tlpmain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.tlpmain.ColumnCount = 2
    Me.tlpmain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
    Me.tlpmain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.0!))
    Me.tlpmain.Controls.Add(Me.tlpCmd, 0, 1)
    Me.tlpmain.Controls.Add(Me.PictureBox3, 0, 0)
    Me.tlpmain.Controls.Add(Me.TableLayoutPanel3, 1, 0)
    Me.tlpmain.Controls.Add(Me.TableLayoutPanel4, 1, 1)
    Me.tlpmain.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tlpmain.Location = New System.Drawing.Point(4, 158)
    Me.tlpmain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.tlpmain.Name = "tlpmain"
    Me.tlpmain.RowCount = 2
    Me.tlpmain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
    Me.tlpmain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tlpmain.Size = New System.Drawing.Size(1890, 861)
    Me.tlpmain.TabIndex = 1
    '
    'tlpCmd
    '
    Me.tlpCmd.ColumnCount = 1
    Me.tlpCmd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tlpCmd.Controls.Add(Me.TableLayoutPanel1, 0, 1)
    Me.tlpCmd.Controls.Add(Me.TableLayoutPanel2, 0, 0)
    Me.tlpCmd.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tlpCmd.Location = New System.Drawing.Point(5, 84)
    Me.tlpCmd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.tlpCmd.Name = "tlpCmd"
    Me.tlpCmd.RowCount = 2
    Me.tlpCmd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
    Me.tlpCmd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.tlpCmd.Size = New System.Drawing.Size(407, 771)
    Me.tlpCmd.TabIndex = 0
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.btnLaunch, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnAbort, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 544)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(399, 222)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'btnLaunch
    '
    Me.btnLaunch.AutoScaleBorder = 0
    Me.btnLaunch.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.launch51
    Me.btnLaunch.BackColor = System.Drawing.Color.DarkSeaGreen
    Me.btnLaunch.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnLaunch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.btnLaunch.FlatAppearance.BorderSize = 2
    Me.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLaunch.Location = New System.Drawing.Point(4, 5)
    Me.btnLaunch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnLaunch.Name = "btnLaunch"
    Me.btnLaunch.Size = New System.Drawing.Size(391, 101)
    Me.btnLaunch.TabIndex = 0
    Me.btnLaunch.UseVisualStyleBackColor = False
    '
    'btnAbort
    '
    Me.btnAbort.AutoScaleBorder = 0
    Me.btnAbort.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.abort1
    Me.btnAbort.BackColor = System.Drawing.Color.Firebrick
    Me.btnAbort.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnAbort.FlatAppearance.BorderColor = System.Drawing.Color.Red
    Me.btnAbort.FlatAppearance.BorderSize = 2
    Me.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnAbort.Location = New System.Drawing.Point(4, 116)
    Me.btnAbort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnAbort.Name = "btnAbort"
    Me.btnAbort.Size = New System.Drawing.Size(391, 101)
    Me.btnAbort.TabIndex = 1
    Me.btnAbort.UseVisualStyleBackColor = False
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.btnIgn1On, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.btnIgn1Off, 1, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.PictureBox2, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.pbSafety, 1, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.btnVentClose, 1, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.btnIgn2Off, 1, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.btnVentOpen, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.btnIgn2On, 0, 2)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 5)
    Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 4
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(399, 529)
    Me.TableLayoutPanel2.TabIndex = 1
    '
    'btnIgn1On
    '
    Me.btnIgn1On.AutoScaleBorder = 0
    Me.btnIgn1On.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.ignitor_one_on
    Me.btnIgn1On.BackColor = System.Drawing.SystemColors.ControlDark
    Me.btnIgn1On.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnIgn1On.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.btnIgn1On.FlatAppearance.BorderSize = 2
    Me.btnIgn1On.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnIgn1On.Location = New System.Drawing.Point(4, 105)
    Me.btnIgn1On.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnIgn1On.Name = "btnIgn1On"
    Me.btnIgn1On.Size = New System.Drawing.Size(191, 132)
    Me.btnIgn1On.TabIndex = 0
    Me.btnIgn1On.UseVisualStyleBackColor = False
    '
    'btnIgn1Off
    '
    Me.btnIgn1Off.AutoScaleBorder = 0
    Me.btnIgn1Off.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.ignitor_one_off
    Me.btnIgn1Off.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.btnIgn1Off.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnIgn1Off.FlatAppearance.BorderColor = System.Drawing.Color.Red
    Me.btnIgn1Off.FlatAppearance.BorderSize = 2
    Me.btnIgn1Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnIgn1Off.Location = New System.Drawing.Point(203, 105)
    Me.btnIgn1Off.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnIgn1Off.Name = "btnIgn1Off"
    Me.btnIgn1Off.Size = New System.Drawing.Size(192, 132)
    Me.btnIgn1Off.TabIndex = 3
    Me.btnIgn1Off.UseVisualStyleBackColor = False
    '
    'PictureBox2
    '
    Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox2.Image = Global.Launch_Control.My.Resources.Resources.safety
    Me.PictureBox2.Location = New System.Drawing.Point(4, 5)
    Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(191, 90)
    Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox2.TabIndex = 6
    Me.PictureBox2.TabStop = False
    '
    'pbSafety
    '
    Me.pbSafety.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pbSafety.Image = Global.Launch_Control.My.Resources.Resources.safety_on2
    Me.pbSafety.Location = New System.Drawing.Point(203, 5)
    Me.pbSafety.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.pbSafety.Name = "pbSafety"
    Me.pbSafety.Size = New System.Drawing.Size(192, 90)
    Me.pbSafety.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pbSafety.TabIndex = 7
    Me.pbSafety.TabStop = False
    '
    'btnVentClose
    '
    Me.btnVentClose.AutoScaleBorder = 0
    Me.btnVentClose.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.vents_closed1
    Me.btnVentClose.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.btnVentClose.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnVentClose.FlatAppearance.BorderColor = System.Drawing.Color.Red
    Me.btnVentClose.FlatAppearance.BorderSize = 2
    Me.btnVentClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVentClose.Location = New System.Drawing.Point(203, 389)
    Me.btnVentClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnVentClose.Name = "btnVentClose"
    Me.btnVentClose.Size = New System.Drawing.Size(192, 135)
    Me.btnVentClose.TabIndex = 4
    Me.btnVentClose.UseVisualStyleBackColor = False
    '
    'btnIgn2Off
    '
    Me.btnIgn2Off.AutoScaleBorder = 0
    Me.btnIgn2Off.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.ignitor_two_off
    Me.btnIgn2Off.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.btnIgn2Off.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnIgn2Off.FlatAppearance.BorderColor = System.Drawing.Color.Red
    Me.btnIgn2Off.FlatAppearance.BorderSize = 2
    Me.btnIgn2Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnIgn2Off.Location = New System.Drawing.Point(203, 247)
    Me.btnIgn2Off.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnIgn2Off.Name = "btnIgn2Off"
    Me.btnIgn2Off.Size = New System.Drawing.Size(192, 132)
    Me.btnIgn2Off.TabIndex = 5
    Me.btnIgn2Off.UseVisualStyleBackColor = False
    '
    'btnVentOpen
    '
    Me.btnVentOpen.AutoScaleBorder = 0
    Me.btnVentOpen.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.vents_opened1
    Me.btnVentOpen.BackColor = System.Drawing.SystemColors.ControlDark
    Me.btnVentOpen.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnVentOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.btnVentOpen.FlatAppearance.BorderSize = 2
    Me.btnVentOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVentOpen.Location = New System.Drawing.Point(4, 389)
    Me.btnVentOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnVentOpen.Name = "btnVentOpen"
    Me.btnVentOpen.Size = New System.Drawing.Size(191, 135)
    Me.btnVentOpen.TabIndex = 1
    Me.btnVentOpen.UseVisualStyleBackColor = False
    '
    'btnIgn2On
    '
    Me.btnIgn2On.AutoScaleBorder = 0
    Me.btnIgn2On.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.ignitor_two_on
    Me.btnIgn2On.BackColor = System.Drawing.SystemColors.ControlDark
    Me.btnIgn2On.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnIgn2On.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.btnIgn2On.FlatAppearance.BorderSize = 2
    Me.btnIgn2On.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnIgn2On.Location = New System.Drawing.Point(4, 247)
    Me.btnIgn2On.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnIgn2On.Name = "btnIgn2On"
    Me.btnIgn2On.Size = New System.Drawing.Size(191, 132)
    Me.btnIgn2On.TabIndex = 2
    Me.btnIgn2On.UseVisualStyleBackColor = False
    '
    'PictureBox3
    '
    Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox3.Image = Global.Launch_Control.My.Resources.Resources.no_go_for_launch
    Me.PictureBox3.Location = New System.Drawing.Point(5, 6)
    Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox3.Name = "PictureBox3"
    Me.PictureBox3.Size = New System.Drawing.Size(407, 67)
    Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox3.TabIndex = 1
    Me.PictureBox3.TabStop = False
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanel3.ColumnCount = 6
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.42857!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.09524!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.txtPort, 3, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.Label2, 2, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.txtIP, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.btnDisconnect, 5, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.btnConnect, 4, 0)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(421, 6)
    Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(1464, 67)
    Me.TableLayoutPanel3.TabIndex = 2
    '
    'txtPort
    '
    Me.txtPort.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtPort.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPort.Location = New System.Drawing.Point(736, 6)
    Me.txtPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtPort.Name = "txtPort"
    Me.txtPort.Size = New System.Drawing.Size(182, 55)
    Me.txtPort.TabIndex = 3
    Me.txtPort.Text = "5555"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Black
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.Lime
    Me.Label1.Location = New System.Drawing.Point(5, 1)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(200, 65)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Board IP:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Black
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.Lime
    Me.Label2.Location = New System.Drawing.Point(527, 1)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(200, 65)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Board Port:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtIP
    '
    Me.txtIP.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtIP.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtIP.Location = New System.Drawing.Point(214, 6)
    Me.txtIP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtIP.Name = "txtIP"
    Me.txtIP.Size = New System.Drawing.Size(304, 55)
    Me.txtIP.TabIndex = 2
    Me.txtIP.Text = "launch1.local"
    '
    'btnDisconnect
    '
    Me.btnDisconnect.AutoScaleBorder = 0
    Me.btnDisconnect.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.disconnect
    Me.btnDisconnect.BackColor = System.Drawing.SystemColors.ControlLight
    Me.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnDisconnect.Location = New System.Drawing.Point(1205, 6)
    Me.btnDisconnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnDisconnect.Name = "btnDisconnect"
    Me.btnDisconnect.Size = New System.Drawing.Size(254, 55)
    Me.btnDisconnect.TabIndex = 5
    Me.btnDisconnect.UseVisualStyleBackColor = False
    '
    'btnConnect
    '
    Me.btnConnect.AutoScaleBorder = 0
    Me.btnConnect.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.connect1
    Me.btnConnect.BackColor = System.Drawing.SystemColors.ControlLight
    Me.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnConnect.Location = New System.Drawing.Point(927, 6)
    Me.btnConnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnConnect.Name = "btnConnect"
    Me.btnConnect.Size = New System.Drawing.Size(269, 55)
    Me.btnConnect.TabIndex = 4
    Me.btnConnect.UseVisualStyleBackColor = False
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanel4.ColumnCount = 2
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.TableLayoutPanel4.Controls.Add(Me.dgvEvents, 0, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 0)
    Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(421, 84)
    Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
    Me.TableLayoutPanel4.RowCount = 1
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(1464, 771)
    Me.TableLayoutPanel4.TabIndex = 3
    '
    'dgvEvents
    '
    Me.dgvEvents.AllowUserToAddRows = False
    Me.dgvEvents.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dgvEvents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvEvents.BackgroundColor = System.Drawing.SystemColors.GrayText
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvEvents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
    Me.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvEvents.DefaultCellStyle = DataGridViewCellStyle3
    Me.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvEvents.Location = New System.Drawing.Point(5, 6)
    Me.dgvEvents.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.dgvEvents.Name = "dgvEvents"
    Me.dgvEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgvEvents.Size = New System.Drawing.Size(1014, 759)
    Me.dgvEvents.TabIndex = 0
    '
    'TableLayoutPanel5
    '
    Me.TableLayoutPanel5.ColumnCount = 1
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel5.Controls.Add(Me.btnCameraCtl, 0, 2)
    Me.TableLayoutPanel5.Controls.Add(Me.btnSensorReads, 0, 1)
    Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
    Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel8, 0, 3)
    Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel5.Location = New System.Drawing.Point(1028, 6)
    Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
    Me.TableLayoutPanel5.RowCount = 4
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
    Me.TableLayoutPanel5.Size = New System.Drawing.Size(431, 759)
    Me.TableLayoutPanel5.TabIndex = 1
    '
    'btnCameraCtl
    '
    Me.btnCameraCtl.AutoScaleBorder = 0
    Me.btnCameraCtl.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.camera_button2
    Me.btnCameraCtl.BackColor = System.Drawing.Color.LightGray
    Me.btnCameraCtl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnCameraCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCameraCtl.Location = New System.Drawing.Point(4, 558)
    Me.btnCameraCtl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnCameraCtl.Name = "btnCameraCtl"
    Me.btnCameraCtl.Size = New System.Drawing.Size(423, 88)
    Me.btnCameraCtl.TabIndex = 0
    Me.btnCameraCtl.UseVisualStyleBackColor = False
    '
    'btnSensorReads
    '
    Me.btnSensorReads.AutoScaleBorder = 0
    Me.btnSensorReads.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.begin_sensors
    Me.btnSensorReads.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.btnSensorReads.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnSensorReads.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSensorReads.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSensorReads.Location = New System.Drawing.Point(4, 460)
    Me.btnSensorReads.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnSensorReads.Name = "btnSensorReads"
    Me.btnSensorReads.Size = New System.Drawing.Size(423, 88)
    Me.btnSensorReads.TabIndex = 3
    Me.btnSensorReads.UseVisualStyleBackColor = False
    '
    'TableLayoutPanel6
    '
    Me.TableLayoutPanel6.BackColor = System.Drawing.SystemColors.MenuBar
    Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanel6.ColumnCount = 2
    Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel6.Controls.Add(Me.PictureBox5, 0, 1)
    Me.TableLayoutPanel6.Controls.Add(Me.PictureBox7, 0, 0)
    Me.TableLayoutPanel6.Controls.Add(Me.lblKeroValve, 1, 1)
    Me.TableLayoutPanel6.Controls.Add(Me.PictureBox6, 0, 2)
    Me.TableLayoutPanel6.Controls.Add(Me.PictureBox9, 0, 3)
    Me.TableLayoutPanel6.Controls.Add(Me.PictureBox10, 0, 4)
    Me.TableLayoutPanel6.Controls.Add(Me.PictureBox11, 0, 5)
    Me.TableLayoutPanel6.Controls.Add(Me.lblThermo, 1, 4)
    Me.TableLayoutPanel6.Controls.Add(Me.lblLOXValve, 1, 2)
    Me.TableLayoutPanel6.Controls.Add(Me.lblBwire, 1, 5)
    Me.TableLayoutPanel6.Controls.Add(Me.lblMainValves, 1, 3)
    Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 5)
    Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
    Me.TableLayoutPanel6.RowCount = 6
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
    Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
    Me.TableLayoutPanel6.Size = New System.Drawing.Size(423, 445)
    Me.TableLayoutPanel6.TabIndex = 5
    '
    'PictureBox5
    '
    Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox5.Image = Global.Launch_Control.My.Resources.Resources.kero_valve1
    Me.PictureBox5.Location = New System.Drawing.Point(5, 80)
    Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox5.Name = "PictureBox5"
    Me.PictureBox5.Size = New System.Drawing.Size(202, 63)
    Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox5.TabIndex = 14
    Me.PictureBox5.TabStop = False
    '
    'PictureBox7
    '
    Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox7.Image = Global.Launch_Control.My.Resources.Resources.Kero_pressure
    Me.PictureBox7.Location = New System.Drawing.Point(5, 6)
    Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox7.Name = "PictureBox7"
    Me.PictureBox7.Size = New System.Drawing.Size(202, 63)
    Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox7.TabIndex = 11
    Me.PictureBox7.TabStop = False
    '
    'lblKeroValve
    '
    Me.lblKeroValve.AutoSize = True
    Me.lblKeroValve.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblKeroValve.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblKeroValve.Location = New System.Drawing.Point(216, 75)
    Me.lblKeroValve.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblKeroValve.Name = "lblKeroValve"
    Me.lblKeroValve.Size = New System.Drawing.Size(202, 73)
    Me.lblKeroValve.TabIndex = 1
    Me.lblKeroValve.Text = "--"
    Me.lblKeroValve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'PictureBox6
    '
    Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox6.Image = Global.Launch_Control.My.Resources.Resources.LOX_valve1
    Me.PictureBox6.Location = New System.Drawing.Point(5, 154)
    Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox6.Name = "PictureBox6"
    Me.PictureBox6.Size = New System.Drawing.Size(202, 63)
    Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox6.TabIndex = 15
    Me.PictureBox6.TabStop = False
    '
    'PictureBox9
    '
    Me.PictureBox9.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox9.Image = Global.Launch_Control.My.Resources.Resources.Main_valves1
    Me.PictureBox9.Location = New System.Drawing.Point(5, 228)
    Me.PictureBox9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox9.Name = "PictureBox9"
    Me.PictureBox9.Size = New System.Drawing.Size(202, 63)
    Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox9.TabIndex = 16
    Me.PictureBox9.TabStop = False
    '
    'PictureBox10
    '
    Me.PictureBox10.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox10.Image = Global.Launch_Control.My.Resources.Resources.thermocouple_read1
    Me.PictureBox10.Location = New System.Drawing.Point(5, 302)
    Me.PictureBox10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox10.Name = "PictureBox10"
    Me.PictureBox10.Size = New System.Drawing.Size(202, 63)
    Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox10.TabIndex = 17
    Me.PictureBox10.TabStop = False
    '
    'PictureBox11
    '
    Me.PictureBox11.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox11.Image = Global.Launch_Control.My.Resources.Resources.bwire1
    Me.PictureBox11.Location = New System.Drawing.Point(5, 376)
    Me.PictureBox11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.PictureBox11.Name = "PictureBox11"
    Me.PictureBox11.Size = New System.Drawing.Size(202, 63)
    Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox11.TabIndex = 18
    Me.PictureBox11.TabStop = False
    '
    'lblThermo
    '
    Me.lblThermo.AutoSize = True
    Me.lblThermo.BackColor = System.Drawing.SystemColors.Menu
    Me.lblThermo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblThermo.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblThermo.Location = New System.Drawing.Point(216, 297)
    Me.lblThermo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblThermo.Name = "lblThermo"
    Me.lblThermo.Size = New System.Drawing.Size(202, 73)
    Me.lblThermo.TabIndex = 19
    Me.lblThermo.Text = "--"
    Me.lblThermo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblLOXValve
    '
    Me.lblLOXValve.AutoSize = True
    Me.lblLOXValve.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblLOXValve.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLOXValve.Location = New System.Drawing.Point(216, 149)
    Me.lblLOXValve.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblLOXValve.Name = "lblLOXValve"
    Me.lblLOXValve.Size = New System.Drawing.Size(202, 73)
    Me.lblLOXValve.TabIndex = 3
    Me.lblLOXValve.Text = "--"
    Me.lblLOXValve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblBwire
    '
    Me.lblBwire.AutoSize = True
    Me.lblBwire.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblBwire.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBwire.Location = New System.Drawing.Point(216, 371)
    Me.lblBwire.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblBwire.Name = "lblBwire"
    Me.lblBwire.Size = New System.Drawing.Size(202, 73)
    Me.lblBwire.TabIndex = 7
    Me.lblBwire.Text = "--"
    Me.lblBwire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblMainValves
    '
    Me.lblMainValves.AutoSize = True
    Me.lblMainValves.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblMainValves.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMainValves.Location = New System.Drawing.Point(216, 223)
    Me.lblMainValves.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblMainValves.Name = "lblMainValves"
    Me.lblMainValves.Size = New System.Drawing.Size(202, 73)
    Me.lblMainValves.TabIndex = 5
    Me.lblMainValves.Text = "--"
    Me.lblMainValves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'TableLayoutPanel8
    '
    Me.TableLayoutPanel8.ColumnCount = 2
    Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel8.Controls.Add(Me.btnPoEOff, 1, 0)
    Me.TableLayoutPanel8.Controls.Add(Me.btnPoEOn, 0, 0)
    Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 654)
    Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
    Me.TableLayoutPanel8.RowCount = 1
    Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel8.Size = New System.Drawing.Size(425, 102)
    Me.TableLayoutPanel8.TabIndex = 7
    '
    'btnPoEOff
    '
    Me.btnPoEOff.AutoScaleBorder = 0
    Me.btnPoEOff.AutoScaleImage = Nothing
    Me.btnPoEOff.BackColor = System.Drawing.Color.LightGray
    Me.btnPoEOff.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnPoEOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnPoEOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnPoEOff.Location = New System.Drawing.Point(215, 3)
    Me.btnPoEOff.Name = "btnPoEOff"
    Me.btnPoEOff.Size = New System.Drawing.Size(207, 96)
    Me.btnPoEOff.TabIndex = 1
    Me.btnPoEOff.Text = "PoE Off"
    Me.btnPoEOff.UseVisualStyleBackColor = False
    '
    'btnPoEOn
    '
    Me.btnPoEOn.AutoScaleBorder = 0
    Me.btnPoEOn.AutoScaleImage = Nothing
    Me.btnPoEOn.BackColor = System.Drawing.Color.LightGray
    Me.btnPoEOn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnPoEOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnPoEOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnPoEOn.Location = New System.Drawing.Point(3, 3)
    Me.btnPoEOn.Name = "btnPoEOn"
    Me.btnPoEOn.Size = New System.Drawing.Size(206, 96)
    Me.btnPoEOn.TabIndex = 0
    Me.btnPoEOn.Text = "PoE On"
    Me.btnPoEOn.UseVisualStyleBackColor = False
    '
    'Timer1
    '
    Me.Timer1.Interval = 500
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1898, 1024)
    Me.Controls.Add(Me.tlpBackground)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "frmMain"
    Me.Text = "frmMain"
    Me.TransparencyKey = System.Drawing.Color.LightSteelBlue
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.tlpBackground.ResumeLayout(False)
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tlpmain.ResumeLayout(False)
    Me.tlpCmd.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pbSafety, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TableLayoutPanel4.ResumeLayout(False)
    CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel5.ResumeLayout(False)
    Me.TableLayoutPanel6.ResumeLayout(False)
    Me.TableLayoutPanel6.PerformLayout()
    CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel8.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tlpBackground As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents tlpmain As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents tlpCmd As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents btnLaunch As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnAbort As AutoScaleButton.AutoScaleButton
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents btnIgn1On As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnVentOpen As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnIgn2On As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnIgn1Off As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnVentClose As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnIgn2Off As AutoScaleButton.AutoScaleButton
  Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
  Friend WithEvents pbSafety As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txtPort As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtIP As System.Windows.Forms.TextBox
  Friend WithEvents btnConnect As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnDisconnect As AutoScaleButton.AutoScaleButton
  Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents dgvEvents As System.Windows.Forms.DataGridView
  Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents btnSensorReads As AutoScaleButton.AutoScaleButton
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lblKeroValve As System.Windows.Forms.Label
  Friend WithEvents lblLOXValve As System.Windows.Forms.Label
  Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
  Friend WithEvents lblThermo As System.Windows.Forms.Label
  Friend WithEvents lblBwire As System.Windows.Forms.Label
  Friend WithEvents lblMainValves As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents btnPoEOff As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnPoEOn As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnCameraCtl As AutoScaleButton.AutoScaleButton

End Class
