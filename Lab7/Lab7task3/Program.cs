using System;

namespace Lab7task3
{
    class Program
    {
        //creates matrix
        static int[,] MatrixCreation(int row, int column)
        {
            int[,] matrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Element [{0}][{1}] = ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        // outputs matrix
        static void MatrixOutput(int[,] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // creating matrix A
            Console.Write("Rows = ");
            int rowsA = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Columns = ");
            int columnsA = Convert.ToInt32(Console.ReadLine());
            int[,] A = (MatrixCreation(rowsA, columnsA));

            MatrixOutput(A, rowsA, columnsA);

            // creating matrix B
            Console.Write("Rows = ");
            int rowsB = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Columns = ");
            int columnsB = Convert.ToInt32(Console.ReadLine());
            int[,] B = MatrixCreation(rowsB, columnsB);

            MatrixOutput(B, rowsB, columnsB);

            if (columnsA != rowsA)
                Console.Write("Number of columns in first matrix must be equal to number of rows in the second one.");
            else
            {
                // creating matrix C
                int[,] C = new int[columnsA, rowsB];
                for (int i = 0; i < C.GetLength(0); i++)
                {
                    for (int j = 0; j < C.GetLength(1); j++)
                    {
                        C[i, j] = 0;
                        for (int k = 0; k < A.GetLength(1); k++)
                            C[i, j] = C[i, j] + A[i, k] * B[k, j];
                    }
                }

                MatrixOutput(C, columnsA, rowsB);
            }
        
        }
    }
}
