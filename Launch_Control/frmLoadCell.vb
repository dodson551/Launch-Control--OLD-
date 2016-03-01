
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Gauge
Imports System.Runtime.InteropServices

Public Class frmLoadCell
    Private Sub tbScale_Scroll(sender As Object, e As EventArgs) Handles tbScale.Scroll
        Me.rgLoadCell.Value = Me.tbScale.Value
        Me.lgTemp.Value = Me.tbScale.Value
        'rgLoadCell.Invalidate()
    End Sub

    Private Sub frmLoadCell_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim gr As New Range()
        gr.EndValue = 8
        gr.StartValue = 0
        gr.Height = 10
        gr.Color = Color.Lime
        Me.rgLoadCell.Ranges.Add(gr)

        Dim yr As New Range()
        yr.EndValue = 10
        yr.StartValue = 8
        yr.Height = 10
        yr.Color = Color.Yellow
        Me.rgLoadCell.Ranges.Add(yr)

        Dim rr As New Range()
        rr.EndValue = 12
        rr.StartValue = 10
        rr.Height = 10
        rr.Color = Color.Red
        Me.rgLoadCell.Ranges.Add(rr)

    End Sub

End Class