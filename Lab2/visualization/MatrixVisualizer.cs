using Matrices;
using System;

namespace Visualization
{
    public class MatrixVisualizer<T> : IVisualizer<T>
    {
        public IImplementor IMPLEMENTOR { get; set; }
        public IPrinter<T> PRINTER { get; set; }
        public bool DrawBorder { get; set; }

        public MatrixVisualizer(bool drawBorder = true)
        {
            DrawBorder = drawBorder;
        }

        public void Visualize(MatrixData<T> data)
        {
            string[] string_data = PRINTER.Print(data.data);
            IMPLEMENTOR.Visualize(
                new MatrixData<string>(
                    string_data,
                    data.dims
                    ),
                DrawBorder);
        }
    }
}
