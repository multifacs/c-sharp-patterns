using Matrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class ShuffleDecorator : Decorator
    {
        List<int> rowIndices;
        List<int> colIndices;
        public ShuffleDecorator(IMatrix matrix) : base(matrix)
        {
            rowIndices = Enumerable.Range(0, matrix.ROWS).ToList();
            colIndices = Enumerable.Range(0, matrix.COLS).ToList();
        }
        public override int Get(int i, int j)
        {
            return matrix.Get(rowIndices[i], colIndices[j]);
        }

        public override void Set(int i, int j, int val)
        {
            matrix.Set(rowIndices[i], colIndices[j], val);
        }

        public void ShuffleRows()
        {
            Random r = new Random();
            int idx1 = r.Next(rowIndices.Count);
            int idx2 = r.Next(rowIndices.Count);

            if (idx1 != idx2) ShuffleRows();

            (rowIndices[idx2], rowIndices[idx1]) =
                (rowIndices[idx1], rowIndices[idx2]);
        }

        public void ShuffleColumns()
        {
            Random r = new Random();
            int idx1 = r.Next(colIndices.Count);
            int idx2 = r.Next(colIndices.Count);

            if (idx1 != idx2) ShuffleColumns();

            (colIndices[idx2], colIndices[idx1]) =
                (colIndices[idx1], colIndices[idx2]);
        }
    }
}
