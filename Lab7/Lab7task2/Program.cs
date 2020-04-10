using System;

namespace Lab7task2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Matrix creation
            Console.Write("Size of matrix = ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Element [{0}][{1}] = ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Matrix output
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }

            // Matrix search

            int[] vectorRow = new int[size];
            int[] vectorColumn = new int[size];
            Console.Write("Row number = ");
            int rowNumber = Convert.ToInt32(Console.ReadLine());
            if (rowNumber >= size || rowNumber < 0)
                Console.WriteLine("Row number must be in range [0;{0}]", size);

            else
            {
                // choosing row
                for (int i = rowNumber; i <= rowNumber; i++)
                {
                    for (int j = 0; j < size; j++)
                        vectorRow[j] = matrix[i, j];
                }
            }


            Console.Write("Row number = ");
            int columnNumber = Convert.ToInt32(Console.ReadLine());
            if (columnNumber >= size || columnNumber < 0)
                Console.WriteLine("Column number must be in range [0;{0}]", size);
            // choosing column
            for (int i = 0; i < size; i++)
            {
                for (int j = columnNumber; j <= columnNumber; j++)
                    vectorColumn[i] = matrix[i, j];
            }


            // scalar product
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                result += vectorRow[i] * vectorColumn[i];
            }
            Console.WriteLine(result);
        }
    }
}
