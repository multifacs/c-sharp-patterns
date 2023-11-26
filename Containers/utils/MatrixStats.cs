using Matrices;

namespace Utils
{
    public class MatrixStats
    {
        public MatrixStats(IMatrix matrix)
        {
            int sum = 0;
            int max = matrix.Get(0, 0);
            int notNull = 0;
            for (int i = 0; i < matrix.ROWS; i++)
            {
                for (int j = 0; j < matrix.COLS; j++)
                {
                    sum += matrix.Get(i, j);
                    max = max < matrix.Get(i, j) ? matrix.Get(i, j) : max;
                    notNull += matrix.Get(i, j) != 0 ? 1 : 0;
                }

                SUM = sum;
                AVERAGE = (double)sum / (matrix.ROWS * matrix.COLS);
                MAX = max;
                NOT_NULL = notNull;
            }
        }
        public int SUM
        {
            get;
        }
        public double AVERAGE
        {
            get;
        }
        public int MAX
        {
            get;
        }
        public int NOT_NULL
        {
            get;
        }
    }
}
