using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    public interface IMatrix
    {
        int Get(int i, int j);
        void Set(int i, int j, int val);
        int ROWS
        {
            get;
        }
        int COLS
        {
            get;
        }
    }
}
