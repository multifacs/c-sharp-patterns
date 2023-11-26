using Matrices;
using System;

namespace Visualization
{
    public class ConsoleTwoDimImplementor : IImplementor
    {
        public void Visualize(MatrixData<string> data, bool drawBorder)
        {
            Console.WriteLine("Console visualization:");
            Console.WriteLine(data.dims[0] + " " + data.dims[1]);

            if (drawBorder)
            {
                for (int j = 0; j < data.dims[1]; j++)
                {
                    Console.Write("------");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < data.dims[0]; i++)
            {
                for (int j = 0; j < data.dims[1]; j++)
                {
                    if (drawBorder) Console.Write("|");
                    Console.Write(" " + data.data[i * data.dims[1] + j] + " ");
                    if (drawBorder) Console.Write("|");
                }
                Console.WriteLine();
                if (drawBorder)
                {
                    for (int j = 0; j < data.dims[1]; j++)
                    {
                        Console.Write("------");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
