using Matrices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
    public class GraphicTwoDimImplementor : IImplementor
    {
        Form form;
        void NewWindow()
        {
            Application.Run(form);
        }

        public void Visualize(MatrixData<string> data, bool drawBorder)
        {
            form = new FormGraphicVisualization(data, drawBorder);
            Task.Run(NewWindow);
        }
    }
}
