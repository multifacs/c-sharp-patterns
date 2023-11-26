using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualization
{
    public class MatrixData<T>
    {
        public T[] data;
        public int[] dims;

        public MatrixData(T[] data, int[] dims)
        {
            this.data = data;
            this.dims = dims;
        }
    }
}
