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

            // Define the visual range for the primary X-axis.
            diagram.AxisX.VisualRange.MinValue = 3;
            diagram.AxisX.VisualRange.MaxValue = 6;

            // Define the visual range for the secondary X-axis.
            diagram.SecondaryAxesX[0].VisualRange.MinValue = "A";
            diagram.SecondaryAxesX[0].VisualRange.MaxValue = "G";

            // Enable the X-axis scrolling at the diagram's level.
            // By default, it then becomes enabled at the panes' level, as well.
            diagram.EnableAxisXScrolling = true;

            // Define the whole range for the primary X-axis.
            diagram.AxisX.WholeRange.MinValue = 2;
            diagram.AxisX.WholeRange.MaxValue = 7;

            // Define the whole range for the secondary X-axis.
            diagram.SecondaryAxesX[0].WholeRange.MinValue = "A";
            diagram.SecondaryAxesX[0].WholeRange.MaxValue = "H";

            // Disable the side margins.
            diagram.AxisX.WholeRange.AutoSideMargins = false;
        }

    }
}