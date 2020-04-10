using System;

namespace ConsoleApp1
{
    class Program
    {
        //creates matrix
        static int[,] MatrixCreation(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Element [{0}][{1}] = ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        // outputs matrix
        static void MatrixOutput(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
       
        static void Main(string[] args)
        {
            Console.Write("Size = ");
            int size = Convert.ToInt32((Console.ReadLine()));
            int[,] matrix = MatrixCreation(size);
           
            MatrixOutput(matrix, size);
        
            int maxSum = -10;

            // looping through elements above main diagonal
            for (int k = 0; k < size; k++)
            {
                int i = 0;
                int sum = 0;
                for (int j = k; j < size; j++)
                {
                    sum += matrix[i, j];
                    i++;
                }
                if (sum > maxSum)
                    maxSum = sum;
            }

            // looping through elemnts below main diagonal
            for (int k = 1; k < size; k++)
            {
                int j = 0;
                int sum = 0;
                for (int i = k; i < size; i++)
                {
                    sum += matrix[i, j];
                    j++;
                }
                if (sum > maxSum)
                    maxSum = sum;
            }
            Console.WriteLine(maxSum);
        }

    }
}
