using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class SparseVector : IVector
    {
        Dictionary<int, int> values;

        public SparseVector()
        {
            values = new Dictionary<int, int>();
            CAPACITY = 0;
        }

        public int Get(int i)
        {
            if (!values.ContainsKey(i)) return 0;
            return values[i];
        }
        public void Set(int i, int val)
        {
            values[i] = val;
        }
        public int CAPACITY
        {
            get;
        }
    }
}
