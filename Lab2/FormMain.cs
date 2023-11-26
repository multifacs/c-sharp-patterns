using Matrices;
using System;
using System.Windows.Forms;
using Utils;

namespace Visualization
{
    public partial class FormMain : Form
    {
        NormalMatrix normalMatrix;
        SparseMatrix sparseMatrix;
        bool checkState = false;
        public FormMain()
        {
            InitializeComponent();
        }

        void DisplayMatrix(IPrinter<int> printer, IMatrix matrix)
        {
            MatrixData<int> data = TwoDimMatrixAdapter.AdaptTwoDimMatrix(matrix);

            IVisualizer<int> visualizer = new MatrixVisualizer<int>(checkState);
            visualizer.PRINTER = printer;

            visualizer.IMPLEMENTOR = new ConsoleTwoDimImplementor();
            visualizer.Visualize(data);
            Console.WriteLine();

            visualizer.IMPLEMENTOR = new GraphicTwoDimImplementor();
            visualizer.Visualize(data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int rowSize = r.Next(2, 10);
            int colSize = r.Next(2, 10);

            normalMatrix = new NormalMatrix(rowSize, colSize);

            int normalNotNull = (int) (rowSize * colSize * 0.9);
            int normalMax = 50;
            MatrixInitializer.Initialize(normalMatrix, normalNotNull, normalMax);

            DisplayMatrix(new NormalPrinter<int>(), normalMatrix);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();

            int rowSize = r.Next(2, 10);
            int colSize = r.Next(2, 10);

            sparseMatrix = new SparseMatrix(rowSize, colSize);

            int sparseNotNull = (int)(rowSize * colSize * 0.15);
            int sparseMax = 50;
            MatrixInitializer.Initialize(sparseMatrix, sparseNotNull, sparseMax);

            DisplayMatrix(new SparsePrinter<int>(), sparseMatrix);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(sender.ToString());
            //Console.WriteLine(e.ToString());
            checkState = checkBox1.Checked;
        }
    }
}
