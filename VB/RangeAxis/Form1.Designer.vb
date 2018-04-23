Imports Microsoft.VisualBasic
Imports System
Namespace RangeAxis
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
			Dim secondaryAxisX1 As New DevExpress.XtraCharts.SecondaryAxisX()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(12))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(4))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(8))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(2))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(6))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (CObj(14))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (CObj(8))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("H", New Object() { (CObj(10))})
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(13))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(5))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(9))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("4", New Object() { (CObj(3))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("5", New Object() { (CObj(7))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("6", New Object() { (CObj(15))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("7", New Object() { (CObj(9))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("8", New Object() { (CObj(11))})
			Dim sideBySideBarSeriesView2 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "0"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1;0"
			xyDiagramPane1.Name = "Pane 1"
			xyDiagramPane1.PaneID = 0
			xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1})
			secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
			secondaryAxisX1.AxisID = 0
			secondaryAxisX1.Name = "Secondary AxisX 1"
			secondaryAxisX1.Range.ScrollingRange.SideMarginsEnabled = True
			secondaryAxisX1.Range.SideMarginsEnabled = True
			secondaryAxisX1.VisibleInPanesSerializable = "-1"
			xyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() { secondaryAxisX1})
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			sideBySideBarSeriesLabel1.LineVisible = True
			sideBySideBarSeriesLabel1.Visible = False
			series1.Label = sideBySideBarSeriesLabel1
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
			series1.SeriesID = 0
			sideBySideBarSeriesView1.AxisXName = "Secondary AxisX 1"
			series1.View = sideBySideBarSeriesView1
			sideBySideBarSeriesLabel2.LineVisible = True
			sideBySideBarSeriesLabel2.Visible = False
			series2.Label = sideBySideBarSeriesLabel2
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
			series2.SeriesID = 1
			sideBySideBarSeriesView2.PaneName = "Pane 1"
			series2.View = sideBySideBarSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			sideBySideBarSeriesLabel3.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel3
			Me.chartControl1.Size = New System.Drawing.Size(385, 228)
			Me.chartControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(385, 228)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl

	End Class
End Namespace

