Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace RangeAxis
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)

            ' Define the visible range for the primary X-axis.
            diagram.AxisX.Range.MinValue = 3
            diagram.AxisX.Range.MaxValue = 6

            ' Define the visible range for the secondary X-axis.
            diagram.SecondaryAxesX(0).Range.MinValueInternal = 3
            diagram.SecondaryAxesX(0).Range.MaxValueInternal = 6

            ' Enable the X-axis scrolling at the diagram's level.
            ' By default, it then becomes enabled at the panes' level, as well.
            diagram.EnableAxisXScrolling = True

            ' Define the scrolling range for the primary X-axis.
            diagram.AxisX.Range.ScrollingRange.MinValue = 2
            diagram.AxisX.Range.ScrollingRange.MaxValue = 7

            ' Define the scrolling range for the secondary X-axis.
            diagram.SecondaryAxesX(0).Range.ScrollingRange.MinValue = "A"
            diagram.SecondaryAxesX(0).Range.ScrollingRange.MaxValue = "G"

            ' Disable the side margins.
            diagram.AxisX.Range.ScrollingRange.SideMarginsEnabled = False
        End Sub

	End Class
End Namespace