using System;

namespace Lab7task1
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
            int product = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i < j && matrix[i, j] > 0)
                        product *= matrix[i, j];
                }
            }

            Console.WriteLine((product > 1) ? $"Product = {product}" : "No positive elements above main diagonal.");
        }
    }
}
