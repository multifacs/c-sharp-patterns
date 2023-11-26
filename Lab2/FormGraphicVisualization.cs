using Matrices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Visualization
{
    public partial class FormGraphicVisualization : Form
    {
        public MatrixData<string> data;
        bool drawBorder;
        public FormGraphicVisualization()
        {
            InitializeComponent();
        }
        public FormGraphicVisualization(MatrixData<string> data, bool drawBorder)
        {
            InitializeComponent();
            this.data = data;
            this.drawBorder = drawBorder;
        }

        private void FormGraphicVisualization_Load(object sender, EventArgs e)
        {

        }
        Graphics g;

        private void FormGraphicVisualization_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Azure);

            for (int i = 0; i < data.dims[0]; i++)
            {
                for (int j = 0; j < data.dims[1]; j++)
                {
                    Pen pen = drawBorder ? Pens.Black : Pens.Transparent;

                    g.DrawRectangle(pen, j * 25 + 100, i * 25 + 100, 25, 25);
                    g.DrawString(data.data[i * data.dims[1] + j].ToString(),
                        SystemFonts.DefaultFont,
                        Brushes.Black,
                        j * 25 + 105,
                        i * 25 + 105);
                }
            }
        }
    }
}
