using Matrices;
using System.Threading;
using System.Windows.Forms;

namespace Visualization
{
    public class GraphicTwoDimImplementor : IImplementor
    {
        bool drawBorder;
        MatrixData<string> matrixData;
        void NewWindow()
        {
            Application.Run(new FormGraphicVisualization(matrixData, drawBorder));
        }

        public void Visualize(MatrixData<string> data, bool drawBorder)
        {
            this.matrixData = data;
            this.drawBorder = drawBorder;
            Thread thread = new Thread(new ThreadStart(NewWindow));
            thread.Start();
            thread.Join();
        }
    }
}
