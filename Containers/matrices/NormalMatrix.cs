using Vectors;

namespace Matrices
{
    public class NormalMatrix : AbstractMatrix
    {

        public NormalMatrix(int rows, int cols) : base(rows, cols) {}

        protected override IVector GetRow(int i)
        {
            return new NormalVector(i);
        }
    }
}
