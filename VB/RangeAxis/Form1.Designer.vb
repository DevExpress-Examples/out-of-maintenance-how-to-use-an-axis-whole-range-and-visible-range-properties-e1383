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
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (DirectCast(12R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (DirectCast(4R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (DirectCast(8R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (DirectCast(2R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (DirectCast(6R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (DirectCast(14R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (DirectCast(8R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("H", New Object() { (DirectCast(10R, Object))})
            Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (DirectCast(13R, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (DirectCast(5R, Object))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (DirectCast(9R, Object))})
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("4", New Object() { (DirectCast(3R, Object))})
            Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("5", New Object() { (DirectCast(7R, Object))})
            Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("6", New Object() { (DirectCast(15R, Object))})
            Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("7", New Object() { (DirectCast(9R, Object))})
            Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("8", New Object() { (DirectCast(11R, Object))})
            Dim sideBySideBarSeriesView2 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(secondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "0"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1;0"
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.EnableAxisYScrolling = True
            xyDiagram1.EnableAxisYZooming = True
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1})
            secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisX1.AxisID = 0
            secondaryAxisX1.Name = "Secondary AxisX 1"
            secondaryAxisX1.VisibleInPanesSerializable = "-1"
            xyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() { secondaryAxisX1})
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            sideBySideBarSeriesView1.AxisXName = "Secondary AxisX 1"
            series1.View = sideBySideBarSeriesView1
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series2.Name = "Series 2"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
            sideBySideBarSeriesView2.PaneName = "Pane 1"
            series2.View = sideBySideBarSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            Me.chartControl1.Size = New System.Drawing.Size(792, 515)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(792, 515)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(secondaryAxisX1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

    End Class
End Namespace

