using Matrices;

namespace Visualization
{
    public interface IVisualizer<T>
    {
        IImplementor IMPLEMENTOR { get; set; }
        IPrinter<T> PRINTER { get; set; }
        bool DrawBorder { get; set; }
        void Visualize(MatrixData<T> data);
    }
}
