using Vectors;

namespace Matrices
{
    public class SparseMatrix : AbstractMatrix
    {

        public SparseMatrix(int rOWS, int cOLS) : base(rOWS, cOLS) {}
        protected override IVector GetRow(int i)
        {
            return new SparseVector();
        }
    }
}
