using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class NormalVector : IVector
    {
        int[] values = null;
        public NormalVector(int cap)
        {
            values = new int[cap];
            CAPACITY = cap;
        }
        public int Get(int i) => values[i];
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
