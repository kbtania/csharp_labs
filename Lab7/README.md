# Lab 7

## Task 1
- Дана цілочислова прямокутна матриця. Визначити добуток додатних елементів матриці вище головної діагоналі.

## Program.cs
```cs
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
```
## Task 2
- Дано дійсну матрицю розмірності nn , всі елементи якої різні. Знайти скалярний добуток i-го рядка і j-го стовпчика 
(i, j задаються користувачем).

## Program.cs
```cs
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
```

## Task 3
- Дано матриці А і В. Знайти C = А x B.
```cs
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
```
## Task 4
- Розмістити елементи непарних стовпців у порядку зростання.
```cs
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
```

## Task 5
- Дана цілочислова квадратна матриця. Визначити добуток елементів в тих рядках, які не містять від’ємних елементів.
```cs
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
```

## Task 6
- Дана цілочислова квадратна матриця. Визначити максимум серед сум елементів діагоналей, паралельних головній діагоналі матриці.
```cs
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
```
