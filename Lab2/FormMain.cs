using Decorators;
using Matrices;
using System;
using System.Windows.Forms;
using Utils;

namespace Visualization
{
    public partial class FormMain : Form
    {
        IMatrix matrix = null;
        ShuffleDecorator decorated;
        bool checkState = false;
        string last = "none";
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

        private void GenerateNormalBtn_click(object sender, EventArgs e)
        {
            last = "normal";

            int rowSize, colSize;
            GetRndSize(out rowSize, out colSize);

            matrix = new NormalMatrix(rowSize, colSize);

            int normalNotNull = (int) (rowSize * colSize * 0.9);
            int normalMax = 50;
            MatrixInitializer.Initialize(matrix, normalNotNull, normalMax);

            DisplayMatrix(new NormalPrinter<int>(), matrix);
        }

        private void GenerateSparseBtn_click(object sender, EventArgs e)
        {
            last = "sparse";

            int rowSize, colSize;
            GetRndSize(out rowSize, out colSize);

            matrix = new SparseMatrix(rowSize, colSize);

            int sparseNotNull = (int)(rowSize * colSize * 0.15);
            int sparseMax = 50;
            MatrixInitializer.Initialize(matrix, sparseNotNull, sparseMax);

            DisplayMatrix(new SparsePrinter<int>(), matrix);
        }

        private static void GetRndSize(out int rowSize, out int colSize)
        {
            Random r = new Random();

            rowSize = r.Next(2, 10);
            colSize = r.Next(2, 10);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void DrawBorderChkBox_CheckedChanged(object sender, EventArgs e)
        {
            checkState = checkBox1.Checked;
        }

        private void DecorateBtn_Click(object sender, EventArgs e)
        {
            if (matrix == null) return;

            decorated = new ShuffleDecorator(matrix);
            decorated.ShuffleRows();
            decorated.ShuffleColumns();
            if (last == "normal")
            {
                DisplayMatrix(new NormalPrinter<int>(), decorated);
            }
            if (last == "sparse")
            {
                DisplayMatrix(new SparsePrinter<int>(), decorated);
            }
        }

        private void UndecorateBtn_Click(object sender, EventArgs e)
        {
            if (matrix == null) return;

            if (last == "normal")
            {
                DisplayMatrix(new NormalPrinter<int>(), matrix);
            }
            if (last == "sparse")
            {
                DisplayMatrix(new SparsePrinter<int>(), matrix);
            }
        }
    }
}
