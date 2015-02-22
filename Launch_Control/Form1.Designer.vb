<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.tlpBackground = New System.Windows.Forms.TableLayoutPanel()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.tlpmain = New System.Windows.Forms.TableLayoutPanel()
    Me.tlpCmd = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnLaunch = New AutoScaleButton.AutoScaleButton()
    Me.btnAbort = New AutoScaleButton.AutoScaleButton()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnIgnOn = New AutoScaleButton.AutoScaleButton()
    Me.btnVentOpen = New AutoScaleButton.AutoScaleButton()
    Me.btnMainOpen = New AutoScaleButton.AutoScaleButton()
    Me.btnIgnOff = New AutoScaleButton.AutoScaleButton()
    Me.btnVentClose = New AutoScaleButton.AutoScaleButton()
    Me.btnMainClose = New AutoScaleButton.AutoScaleButton()
    Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    Me.pbSafety = New System.Windows.Forms.PictureBox()
    Me.PictureBox3 = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.txtPort = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtIP = New System.Windows.Forms.TextBox()
    Me.btnConnect = New AutoScaleButton.AutoScaleButton()
    Me.AutoScaleButton2 = New AutoScaleButton.AutoScaleButton()
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
    Me.dgvEvents = New System.Windows.Forms.DataGridView()
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
    Me.tlpBackground.Name = "tlpBackground"
    Me.tlpBackground.RowCount = 2
    Me.tlpBackground.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
    Me.tlpBackground.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
    Me.tlpBackground.Size = New System.Drawing.Size(1904, 1041)
    Me.tlpBackground.TabIndex = 0
    '
    'PictureBox1
    '
    Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox1.Image = Global.Launch_Control.My.Resources.Resources.title_2
    Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(1898, 150)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'tlpmain
    '
    Me.tlpmain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.tlpmain.ColumnCount = 2
    Me.tlpmain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
    Me.tlpmain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.0!))
    Me.tlpmain.Controls.Add(Me.tlpCmd, 0, 1)
    Me.tlpmain.Controls.Add(Me.PictureBox3, 0, 0)
    Me.tlpmain.Controls.Add(Me.TableLayoutPanel3, 1, 0)
    Me.tlpmain.Controls.Add(Me.TableLayoutPanel4, 1, 1)
    Me.tlpmain.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tlpmain.Location = New System.Drawing.Point(3, 159)
    Me.tlpmain.Name = "tlpmain"
    Me.tlpmain.RowCount = 2
    Me.tlpmain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.tlpmain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tlpmain.Size = New System.Drawing.Size(1898, 879)
    Me.tlpmain.TabIndex = 1
    '
    'tlpCmd
    '
    Me.tlpCmd.ColumnCount = 1
    Me.tlpCmd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tlpCmd.Controls.Add(Me.TableLayoutPanel1, 0, 1)
    Me.tlpCmd.Controls.Add(Me.TableLayoutPanel2, 0, 0)
    Me.tlpCmd.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tlpCmd.Location = New System.Drawing.Point(4, 55)
    Me.tlpCmd.Name = "tlpCmd"
    Me.tlpCmd.RowCount = 2
    Me.tlpCmd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
    Me.tlpCmd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.tlpCmd.Size = New System.Drawing.Size(429, 820)
    Me.tlpCmd.TabIndex = 0
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.btnLaunch, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnAbort, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 577)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(423, 240)
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
    Me.btnLaunch.Location = New System.Drawing.Point(3, 3)
    Me.btnLaunch.Name = "btnLaunch"
    Me.btnLaunch.Size = New System.Drawing.Size(417, 114)
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
    Me.btnAbort.Location = New System.Drawing.Point(3, 123)
    Me.btnAbort.Name = "btnAbort"
    Me.btnAbort.Size = New System.Drawing.Size(417, 114)
    Me.btnAbort.TabIndex = 1
    Me.btnAbort.UseVisualStyleBackColor = False
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.btnIgnOn, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.btnVentOpen, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.btnMainOpen, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.btnIgnOff, 1, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.btnVentClose, 1, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.btnMainClose, 1, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.PictureBox2, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.pbSafety, 1, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 4
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(423, 568)
    Me.TableLayoutPanel2.TabIndex = 1
    '
    'btnIgnOn
    '
    Me.btnIgnOn.AutoScaleBorder = 0
    Me.btnIgnOn.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.ignitor_on2
    Me.btnIgnOn.BackColor = System.Drawing.SystemColors.ControlDark
    Me.btnIgnOn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnIgnOn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.btnIgnOn.FlatAppearance.BorderSize = 2
    Me.btnIgnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnIgnOn.Location = New System.Drawing.Point(3, 110)
    Me.btnIgnOn.Name = "btnIgnOn"
    Me.btnIgnOn.Size = New System.Drawing.Size(205, 147)
    Me.btnIgnOn.TabIndex = 0
    Me.btnIgnOn.UseVisualStyleBackColor = False
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
    Me.btnVentOpen.Location = New System.Drawing.Point(3, 263)
    Me.btnVentOpen.Name = "btnVentOpen"
    Me.btnVentOpen.Size = New System.Drawing.Size(205, 147)
    Me.btnVentOpen.TabIndex = 1
    Me.btnVentOpen.UseVisualStyleBackColor = False
    '
    'btnMainOpen
    '
    Me.btnMainOpen.AutoScaleBorder = 0
    Me.btnMainOpen.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.main_open
    Me.btnMainOpen.BackColor = System.Drawing.SystemColors.ControlDark
    Me.btnMainOpen.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnMainOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.btnMainOpen.FlatAppearance.BorderSize = 2
    Me.btnMainOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMainOpen.Location = New System.Drawing.Point(3, 416)
    Me.btnMainOpen.Name = "btnMainOpen"
    Me.btnMainOpen.Size = New System.Drawing.Size(205, 149)
    Me.btnMainOpen.TabIndex = 2
    Me.btnMainOpen.UseVisualStyleBackColor = False
    '
    'btnIgnOff
    '
    Me.btnIgnOff.AutoScaleBorder = 0
    Me.btnIgnOff.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.ignitor_off1
    Me.btnIgnOff.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.btnIgnOff.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnIgnOff.FlatAppearance.BorderColor = System.Drawing.Color.Red
    Me.btnIgnOff.FlatAppearance.BorderSize = 2
    Me.btnIgnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnIgnOff.Location = New System.Drawing.Point(214, 110)
    Me.btnIgnOff.Name = "btnIgnOff"
    Me.btnIgnOff.Size = New System.Drawing.Size(206, 147)
    Me.btnIgnOff.TabIndex = 3
    Me.btnIgnOff.UseVisualStyleBackColor = False
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
    Me.btnVentClose.Location = New System.Drawing.Point(214, 263)
    Me.btnVentClose.Name = "btnVentClose"
    Me.btnVentClose.Size = New System.Drawing.Size(206, 147)
    Me.btnVentClose.TabIndex = 4
    Me.btnVentClose.UseVisualStyleBackColor = False
    '
    'btnMainClose
    '
    Me.btnMainClose.AutoScaleBorder = 0
    Me.btnMainClose.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.main_closed
    Me.btnMainClose.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.btnMainClose.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnMainClose.FlatAppearance.BorderColor = System.Drawing.Color.Red
    Me.btnMainClose.FlatAppearance.BorderSize = 2
    Me.btnMainClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMainClose.Location = New System.Drawing.Point(214, 416)
    Me.btnMainClose.Name = "btnMainClose"
    Me.btnMainClose.Size = New System.Drawing.Size(206, 149)
    Me.btnMainClose.TabIndex = 5
    Me.btnMainClose.UseVisualStyleBackColor = False
    '
    'PictureBox2
    '
    Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox2.Image = Global.Launch_Control.My.Resources.Resources.safety
    Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(205, 101)
    Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox2.TabIndex = 6
    Me.PictureBox2.TabStop = False
    '
    'pbSafety
    '
    Me.pbSafety.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pbSafety.Image = Global.Launch_Control.My.Resources.Resources.safety_on2
    Me.pbSafety.Location = New System.Drawing.Point(214, 3)
    Me.pbSafety.Name = "pbSafety"
    Me.pbSafety.Size = New System.Drawing.Size(206, 101)
    Me.pbSafety.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pbSafety.TabIndex = 7
    Me.pbSafety.TabStop = False
    '
    'PictureBox3
    '
    Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox3.Image = Global.Launch_Control.My.Resources.Resources.no_go_for_launch
    Me.PictureBox3.Location = New System.Drawing.Point(4, 4)
    Me.PictureBox3.Name = "PictureBox3"
    Me.PictureBox3.Size = New System.Drawing.Size(429, 44)
    Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox3.TabIndex = 1
    Me.PictureBox3.TabStop = False
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanel3.ColumnCount = 6
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.txtPort, 3, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.Label2, 2, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.txtIP, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.btnConnect, 4, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.AutoScaleButton2, 5, 0)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(440, 4)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(1454, 44)
    Me.TableLayoutPanel3.TabIndex = 2
    '
    'txtPort
    '
    Me.txtPort.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtPort.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPort.Location = New System.Drawing.Point(747, 4)
    Me.txtPort.Name = "txtPort"
    Me.txtPort.Size = New System.Drawing.Size(170, 39)
    Me.txtPort.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Black
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(4, 1)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(188, 42)
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
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(535, 1)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(205, 42)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Board Port:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtIP
    '
    Me.txtIP.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtIP.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtIP.Location = New System.Drawing.Point(199, 4)
    Me.txtIP.Name = "txtIP"
    Me.txtIP.Size = New System.Drawing.Size(329, 39)
    Me.txtIP.TabIndex = 2
    '
    'btnConnect
    '
    Me.btnConnect.AutoScaleBorder = 0
    Me.btnConnect.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.connect1
    Me.btnConnect.BackColor = System.Drawing.SystemColors.ControlLight
    Me.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnConnect.Location = New System.Drawing.Point(924, 4)
    Me.btnConnect.Name = "btnConnect"
    Me.btnConnect.Size = New System.Drawing.Size(258, 36)
    Me.btnConnect.TabIndex = 4
    Me.btnConnect.UseVisualStyleBackColor = False
    '
    'AutoScaleButton2
    '
    Me.AutoScaleButton2.AutoScaleBorder = 0
    Me.AutoScaleButton2.AutoScaleImage = Global.Launch_Control.My.Resources.Resources.disconnect
    Me.AutoScaleButton2.BackColor = System.Drawing.SystemColors.ControlLight
    Me.AutoScaleButton2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.AutoScaleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.AutoScaleButton2.Location = New System.Drawing.Point(1189, 4)
    Me.AutoScaleButton2.Name = "AutoScaleButton2"
    Me.AutoScaleButton2.Size = New System.Drawing.Size(261, 36)
    Me.AutoScaleButton2.TabIndex = 5
    Me.AutoScaleButton2.UseVisualStyleBackColor = False
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
    Me.TableLayoutPanel4.ColumnCount = 2
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel4.Controls.Add(Me.dgvEvents, 0, 0)
    Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(440, 55)
    Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
    Me.TableLayoutPanel4.RowCount = 1
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(1454, 820)
    Me.TableLayoutPanel4.TabIndex = 3
    '
    'dgvEvents
    '
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dgvEvents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
    Me.dgvEvents.Location = New System.Drawing.Point(4, 4)
    Me.dgvEvents.Name = "dgvEvents"
    Me.dgvEvents.Size = New System.Drawing.Size(1082, 812)
    Me.dgvEvents.TabIndex = 0
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1904, 1041)
    Me.Controls.Add(Me.tlpBackground)
    Me.Name = "Form1"
    Me.Text = "frmMain"
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
  Friend WithEvents btnIgnOn As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnVentOpen As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnMainOpen As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnIgnOff As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnVentClose As AutoScaleButton.AutoScaleButton
  Friend WithEvents btnMainClose As AutoScaleButton.AutoScaleButton
  Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
  Friend WithEvents pbSafety As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txtPort As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtIP As System.Windows.Forms.TextBox
  Friend WithEvents btnConnect As AutoScaleButton.AutoScaleButton
  Friend WithEvents AutoScaleButton2 As AutoScaleButton.AutoScaleButton
  Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents dgvEvents As System.Windows.Forms.DataGridView

End Class
