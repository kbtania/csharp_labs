using System;
using System.Linq;

namespace Lab7task5
{
    class Program
    {
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

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i].Min() > 0)
                {
                    int product = 1;
                    foreach (int element in matrix[i])
                        product *= element;

                    Console.WriteLine($"Product of elements in {i + 1} row is {product}.");
                }
                else
                    Console.WriteLine($"{i + 1} row contains negative element.");
            }
        }
    }
}
