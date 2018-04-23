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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim XyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim SecondaryAxisX1 As DevExpress.XtraCharts.SecondaryAxisX = New DevExpress.XtraCharts.SecondaryAxisX()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {CType(12.0R, Object)})
            Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {CType(4.0R, Object)})
            Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {CType(8.0R, Object)})
            Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {CType(2.0R, Object)})
            Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("E", New Object() {CType(6.0R, Object)})
            Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("F", New Object() {CType(14.0R, Object)})
            Dim SeriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("G", New Object() {CType(8.0R, Object)})
            Dim SeriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("H", New Object() {CType(10.0R, Object)})
            Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim SeriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1.0R, New Object() {CType(13.0R, Object)})
            Dim SeriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.0R, New Object() {CType(5.0R, Object)})
            Dim SeriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3.0R, New Object() {CType(9.0R, Object)})
            Dim SeriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(4.0R, New Object() {CType(3.0R, Object)})
            Dim SeriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(5.0R, New Object() {CType(7.0R, Object)})
            Dim SeriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(6.0R, New Object() {CType(15.0R, Object)})
            Dim SeriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(7.0R, New Object() {CType(9.0R, Object)})
            Dim SeriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(8.0R, New Object() {CType(11.0R, Object)})
            Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SecondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisX.Range.SideMarginsEnabled = True
            XyDiagram1.AxisX.VisibleInPanesSerializable = "0"
            XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisY.Range.SideMarginsEnabled = True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1;0"
            XyDiagramPane1.Name = "Pane 1"
            XyDiagramPane1.PaneID = 0
            XyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane1})
            SecondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            SecondaryAxisX1.AxisID = 0
            SecondaryAxisX1.DateTimeScaleMode = DevExpress.XtraCharts.DateTimeScaleMode.Manual
            SecondaryAxisX1.Name = "Secondary AxisX 1"
            SecondaryAxisX1.Range.ScrollingRange.SideMarginsEnabled = True
            SecondaryAxisX1.Range.SideMarginsEnabled = True
            SecondaryAxisX1.VisibleInPanesSerializable = "-1"
            XyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() {SecondaryAxisX1})
            Me.chartControl1.Diagram = XyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            SideBySideBarSeriesLabel1.LineVisible = True
            Series1.Label = SideBySideBarSeriesLabel1
            Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Series1.Name = "Series 1"
            Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4, SeriesPoint5, SeriesPoint6, SeriesPoint7, SeriesPoint8})
            SideBySideBarSeriesView1.AxisXName = "Secondary AxisX 1"
            Series1.View = SideBySideBarSeriesView1
            SideBySideBarSeriesLabel2.LineVisible = True
            Series2.Label = SideBySideBarSeriesLabel2
            Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Series2.Name = "Series 2"
            Series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint9, SeriesPoint10, SeriesPoint11, SeriesPoint12, SeriesPoint13, SeriesPoint14, SeriesPoint15, SeriesPoint16})
            SideBySideBarSeriesView2.PaneName = "Pane 1"
            Series2.View = SideBySideBarSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
            SideBySideBarSeriesLabel3.LineVisible = True
            Me.chartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel3
            Me.chartControl1.Size = New System.Drawing.Size(638, 365)
            Me.chartControl1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(638, 365)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(XyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SecondaryAxisX1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl

	End Class
End Namespace

