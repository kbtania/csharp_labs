using System;

namespace Lab7task4
{
    class Program
    {
        // matrix transposing
        static int[][] TransposedMatrix(int[][] matr)
        {
            int rowCount = matr.Length;
            int columnCount = matr[0].Length;
            int[][] transposed = new int[columnCount][];
            transposed = (int[][])matr.Clone();
            for (int i = 1; i < rowCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = transposed[i][j];
                    transposed[i][j] = transposed[j][i];
                    transposed[j][i] = temp;
                }
            }
            return transposed;
        }

        // matrix output
        static void MatrixOutput(int[][] matr)
        {
            int rowCount = matr.Length;
            int columnCount = matr[0].Length;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // creating matrix
            Console.Write("Rows = ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns = ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Element = ");
                    matrix[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Original matrix:");
            MatrixOutput(matrix);
            Console.WriteLine();

            int[][] transposed = TransposedMatrix(matrix);

            // sorting rows of transposed matrix
            for (int i = 0; i < transposed.Length; i += 2)
            {
                Array.Sort(transposed[i]);
            }

            int[][] res = TransposedMatrix(transposed);

            Console.WriteLine("Result matrix: ");
            MatrixOutput(res);
        }
    }
}
