using System;
using System.Collections.Generic;
using Matrices;

namespace Utils
{
    public class MatrixInitializer
    {
        static public void Initialize(IMatrix matrix, int n, int max)
        {
            List<Tuple<int, int>> indices = new List<Tuple<int, int>>();
            Random r = new Random();

            for (int i = 0; i < matrix.ROWS; i++)
            {
                for (int j = 0; j < matrix.COLS; j++)
                {
                    indices.Add(new Tuple<int, int>(i, j));
                }
            }

            for (int i = 0; i < n; i++)
            {
                Tuple<int, int> idxs = indices[r.Next(indices.Count)];
                indices.Remove(idxs);

                int num = r.Next(1, max + 1);
                matrix.Set(idxs.Item1, idxs.Item2, num);
            }
        }
    }
}
