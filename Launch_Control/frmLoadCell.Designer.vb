<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadCell
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
        Dim Range1 As Syncfusion.Windows.Forms.Gauge.Range = New Syncfusion.Windows.Forms.Gauge.Range()
        Dim LinearRange1 As Syncfusion.Windows.Forms.Gauge.LinearRange = New Syncfusion.Windows.Forms.Gauge.LinearRange()
        Dim LinearRange2 As Syncfusion.Windows.Forms.Gauge.LinearRange = New Syncfusion.Windows.Forms.Gauge.LinearRange()
        Dim LinearRange3 As Syncfusion.Windows.Forms.Gauge.LinearRange = New Syncfusion.Windows.Forms.Gauge.LinearRange()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadCell))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rgLoadCell = New Syncfusion.Windows.Forms.Gauge.RadialGauge()
        Me.tbScale = New System.Windows.Forms.TrackBar()
        Me.lgTemp = New Syncfusion.Windows.Forms.Gauge.LinearGauge()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tbScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rgLoadCell, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbScale, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lgTemp, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(480, 736)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'rgLoadCell
        '
        Me.rgLoadCell.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.rgLoadCell.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.rgLoadCell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgLoadCell.EnableCustomNeedles = False
        Me.rgLoadCell.GaugeLabel = "Load (lbs)"
        Me.rgLoadCell.GaugeLableFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgLoadCell.GaugeValueFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgLoadCell.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.rgLoadCell.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.rgLoadCell.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside
        Me.rgLoadCell.Location = New System.Drawing.Point(3, 150)
        Me.rgLoadCell.MajorDifference = 2.0!
        Me.rgLoadCell.MaximumValue = 12.0!
        Me.rgLoadCell.MinimumSize = New System.Drawing.Size(125, 125)
        Me.rgLoadCell.MinorTickMarkHeight = 1
        Me.rgLoadCell.Name = "rgLoadCell"
        Range1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Range1.EndValue = 0!
        Range1.Height = 5
        Range1.InRange = False
        Range1.Name = "GaugeRange1"
        Range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside
        Range1.StartValue = 0!
        Me.rgLoadCell.Ranges.Add(Range1)
        Me.rgLoadCell.ShowGaugeValue = True
        Me.rgLoadCell.Size = New System.Drawing.Size(474, 474)
        Me.rgLoadCell.TabIndex = 0
        Me.rgLoadCell.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide
        Me.rgLoadCell.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver
        '
        'tbScale
        '
        Me.tbScale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbScale.LargeChange = 100
        Me.tbScale.Location = New System.Drawing.Point(3, 665)
        Me.tbScale.Maximum = 1000
        Me.tbScale.Name = "tbScale"
        Me.tbScale.Size = New System.Drawing.Size(474, 68)
        Me.tbScale.SmallChange = 50
        Me.tbScale.TabIndex = 1
        '
        'lgTemp
        '
        Me.lgTemp.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lgTemp.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lgTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lgTemp.ForeColor = System.Drawing.Color.Gray
        Me.lgTemp.GaugelabelFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lgTemp.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lgTemp.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lgTemp.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal
        Me.lgTemp.Location = New System.Drawing.Point(3, 3)
        Me.lgTemp.MajorDifference = 100
        Me.lgTemp.MajorTicksHeight = 15
        Me.lgTemp.MaximumValue = 1000.0!
        Me.lgTemp.MinimumSize = New System.Drawing.Size(100, 50)
        Me.lgTemp.MinorTickCount = 5
        Me.lgTemp.MinorTickHeight = 10
        Me.lgTemp.Name = "lgTemp"
        Me.lgTemp.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center
        LinearRange1.Color = System.Drawing.Color.Green
        LinearRange1.EndValue = 1000.0!
        LinearRange1.Height = 5
        LinearRange1.InRange = False
        LinearRange1.Name = "GaugeRange1"
        LinearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide
        LinearRange1.StartValue = 0!
        LinearRange2.Color = System.Drawing.Color.Yellow
        LinearRange2.EndValue = 350.0!
        LinearRange2.Height = 5
        LinearRange2.InRange = False
        LinearRange2.Name = "GaugeRange2"
        LinearRange2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide
        LinearRange2.StartValue = 100.0!
        LinearRange3.Color = System.Drawing.Color.Red
        LinearRange3.EndValue = 100.0!
        LinearRange3.Height = 5
        LinearRange3.InRange = False
        LinearRange3.Name = "GaugeRange3"
        LinearRange3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide
        LinearRange3.StartValue = 0!
        Me.lgTemp.Ranges.Add(LinearRange1)
        Me.lgTemp.Ranges.Add(LinearRange2)
        Me.lgTemp.Ranges.Add(LinearRange3)
        Me.lgTemp.Size = New System.Drawing.Size(474, 141)
        Me.lgTemp.TabIndex = 2
        Me.lgTemp.Text = "LinearGauge1"
        Me.lgTemp.ValueIndicatorColor = System.Drawing.Color.Gray
        Me.lgTemp.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver
        '
        'frmLoadCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 736)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoadCell"
        Me.Text = "Load Cell Dashboard"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tbScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents rgLoadCell As Syncfusion.Windows.Forms.Gauge.RadialGauge
    Friend WithEvents tbScale As TrackBar
    Friend WithEvents lgTemp As Syncfusion.Windows.Forms.Gauge.LinearGauge
End Class
