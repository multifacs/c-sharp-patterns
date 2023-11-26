using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public interface IVector
    {
        int Get(int i);
        void Set(int i, int val);
        int CAPACITY
        {
            get;
        }
    }
}
