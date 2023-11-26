using Vectors;

namespace Matrices
{
    public abstract class AbstractMatrix : IMatrix
    {
        private IVector[] values;

        public AbstractMatrix(int rows, int cols)
        {
            ROWS = rows;
            COLS = cols;
            FillValues();
        }

        private void FillValues()
        {
            values = GetAllRows(ROWS);
            for (int i = 0; i < ROWS; i++)
            {
                values[i] = GetRow(COLS);
            }
        }

        protected IVector[] GetAllRows(int i)
        {
            return new IVector[i];
        }
        protected abstract IVector GetRow(int i);

        public int Get(int i, int j) => values[i].Get(j);
        public void Set(int i, int j, int val)
        {
            values[i].Set(j, val);
        }
        public int ROWS
        {
            get;
            set;
        }
        public int COLS
        {
            get;
            set;
        }
    }
}
