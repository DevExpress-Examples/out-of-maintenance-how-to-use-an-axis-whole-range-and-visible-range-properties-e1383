Imports Microsoft.VisualBasic
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)

			' Define the visual range for the primary X-axis.
			diagram.AxisX.VisualRange.MinValue = 3
			diagram.AxisX.VisualRange.MaxValue = 6

			' Define the visual range for the secondary X-axis.
			diagram.SecondaryAxesX(0).VisualRange.MinValue = "A"
			diagram.SecondaryAxesX(0).VisualRange.MaxValue = "G"

			' Enable the X-axis scrolling at the diagram's level.
			' By default, it then becomes enabled at the panes' level, as well.
			diagram.EnableAxisXScrolling = True

			' Define the whole range for the primary X-axis.
			diagram.AxisX.WholeRange.MinValue = 2
			diagram.AxisX.WholeRange.MaxValue = 7

			' Define the whole range for the secondary X-axis.
			diagram.SecondaryAxesX(0).WholeRange.MinValue = "A"
			diagram.SecondaryAxesX(0).WholeRange.MaxValue = "H"

			' Disable the side margins.
			diagram.AxisX.WholeRange.AutoSideMargins = False
		End Sub

	End Class
End Namespace