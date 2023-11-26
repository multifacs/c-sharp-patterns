using Matrices;

namespace Visualization
{
    public interface IImplementor
    {
        void Visualize(MatrixData<string> data, bool drawBorder);
    }
}
