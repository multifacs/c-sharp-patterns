using Matrices;

namespace Visualization
{
    public interface IPrinter<T>
    {
        string[] Print(T[] data);
    }
}
