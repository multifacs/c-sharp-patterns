using Matrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualization
{
    class TwoDimMatrixAdapter
    {
        static public MatrixData<int> AdaptTwoDimMatrix(IMatrix matrix)
        {
            int[] data = new int[matrix.ROWS * matrix.COLS];
            for (int i = 0; i < matrix.ROWS; i++)
            {
                for (int j = 0; j < matrix.COLS; j++)
                {
                    data[i * matrix.COLS + j] = matrix.Get(i, j);
                }
            }

            return new MatrixData<int>(
                data,
                new int[] { matrix.ROWS, matrix.COLS }
                );
        }

    }
}
