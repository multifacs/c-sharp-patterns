using Matrices;
using Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        int rowSize = 10;
        int colSize = 10;

        Console.WriteLine("Matrix size: " + rowSize + " * " + colSize);
        Console.WriteLine();

        IMatrix normalMatrix = new NormalMatrix(rowSize, colSize);
        IMatrix sparseMatrix = new SparseMatrix(rowSize, colSize);

        int normalNotNull = 90;
        int normalMax = 50;
        MatrixInitializer.Initialize(normalMatrix, normalNotNull, normalMax);
        Console.WriteLine("Normal: not null = " + normalNotNull + ", max = " + normalMax);

        int sparseNotNull = 15;
        int sparseMax = 20;
        MatrixInitializer.Initialize(sparseMatrix, sparseNotNull, sparseMax);
        Console.WriteLine("Sparse: not null = " + sparseNotNull + ", max = " + sparseMax);
        Console.WriteLine();

        MatrixStats normalStats = new MatrixStats(normalMatrix);
        MatrixStats sparseStats = new MatrixStats(sparseMatrix);

        Console.WriteLine("Normal data statistics:");
        Console.WriteLine("SUM = " + normalStats.SUM);
        Console.WriteLine("AVERAGE = " + normalStats.AVERAGE);
        Console.WriteLine("MAX = " + normalStats.MAX);
        Console.WriteLine("NOT_NULL = " + normalStats.NOT_NULL);

        Console.WriteLine();

        Console.WriteLine("Sparse data statistics:");
        Console.WriteLine("SUM = " + sparseStats.SUM);
        Console.WriteLine("AVERAGE = " + sparseStats.AVERAGE);
        Console.WriteLine("MAX = " + sparseStats.MAX);
        Console.WriteLine("NOT_NULL = " + sparseStats.NOT_NULL);
    }
}