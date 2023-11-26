using Matrices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public abstract class Decorator
        : IMatrix
    {
        protected IMatrix matrix;

        public Decorator(IMatrix matrix)
        {
            this.matrix = matrix;
        }
        public int ROWS { get; }
        public int COLS { get; }

        public abstract int Get(int i, int j);
        public abstract void Set(int i, int j, int val);

        public IMatrix GetMatrix() => matrix;
    }
}
