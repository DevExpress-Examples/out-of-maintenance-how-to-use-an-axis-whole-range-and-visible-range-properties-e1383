using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace RangeAxis {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            // Define the visible range for the primary X-axis.
            diagram.AxisX.Range.MinValue = 3;
            diagram.AxisX.Range.MaxValue = 6;

            // Define the visible range for the secondary X-axis.
            diagram.SecondaryAxesX[0].Range.MinValueInternal = 3;
            diagram.SecondaryAxesX[0].Range.MaxValueInternal = 6;

            // Enable the X-axis scrolling at the diagram's level.
            // By default, it then becomes enabled at the panes' level, as well.
            diagram.EnableAxisXScrolling = true;

            // Define the scrolling range for the primary X-axis.
            diagram.AxisX.Range.ScrollingRange.MinValue = 2;
            diagram.AxisX.Range.ScrollingRange.MaxValue = 7;

            // Define the scrolling range for the secondary X-axis.
            diagram.SecondaryAxesX[0].Range.ScrollingRange.MinValue = "A";
            diagram.SecondaryAxesX[0].Range.ScrollingRange.MaxValue = "G";

            // Disable the side margins.
            diagram.AxisX.Range.ScrollingRange.SideMarginsEnabled = false;
        }

    }
}