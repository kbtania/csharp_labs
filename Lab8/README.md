# ЛАБОРАТОРНА РОБОТА № 8

## Завдання 1

- За даними дійсними числами a i b обчислити U = min(f(a), f(b))
- f(x) = sinx + sinx^2 + .. + sinx^6, x>3
- = -cosx + coscosx+...+(-1)^5cos...cosx

```cs
using System;

namespace ConsoleApp1
{
    class Program
    { 
        static double Sum(double x)
        {
            if (x > 3)
            {
                double s = 0;
                for (int i = 1; i < 7; i++)
                    s += Math.Sin(Math.Pow(x, i));
                return s;
            }
            else
            {
                double z = -1;
                double s = 0;
                double a = Math.Cos(x);
                for (int i = 1; i < 6; i++)
                {
                    s = s + z * a;
                    a = Math.Cos(a);
                    z = -z;
                }
                return s;
            }
        }
        
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double res1 = Sum(num1);
            double res2 = Sum(num2);
            Console.WriteLine(Math.Min(res1, res2));
        }
    }
}
```

## Завдання 2

- Використовуючи підпрограми для додавання векторів та множення вектора на
число, знайти вектор c = a - 3b + 2c
```cs
using System;
using System.Threading.Channels;

namespace ConsoleApp2
{
    class Program
    {
        static int[] SumOfVectors(int[] vector1, int[] vector2)
        {

            int[] resVector = new int[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
                resVector[i] = vector1[i] + vector2[i];
            return resVector;
        }

        static int[] DifferenceOfVectors(int[] vector1, int[] vector2)
        {

            int[] resVector = new int[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
                resVector[i] = vector1[i] - vector2[i];
            return resVector;
        }
        
        static int[] VectorMultiplyByNumber(int[] vector, int number)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] *= number;
            return vector;
        }
        
        
    static void Main(string[] args)
        {
            Console.Write("Size of vectors: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int [size];
            int[] b = new int [size];
            int[] c = new int [size];
            
            for (int i = 0; i < size; i++)
            {
                Console.Write("Coordinate [{0}] of vector 1: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            for (int j = 0; j < size; j++)
            {
                Console.Write("Coordinate [{0}] of vector 2: ", j);
                b[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            for (int j = 0; j < size; j++)
            {
                Console.Write("Coordinate [{0}] of vector 3: ", j);
                c[j] = Convert.ToInt32(Console.ReadLine());
            }

            int[] b3 = VectorMultiplyByNumber(b, 3);
            int[] c2 = VectorMultiplyByNumber(c, 2);
            int[] res = SumOfVectors(DifferenceOfVectors(a, b3), c2);
            
            for (int i = 0; i < size; i++)
                Console.Write(" "+res[i]);
            
        }
    }
}
```

## Завдання 3

- Нехай x0 =x1 = 1, xi = x(i-1) + 2x(i-2), i = 2,3... Визначити xn.
```cs
using System;

namespace ConsoleApp5
{
    class Program
    {
        static int Recursion(int i)
        {
            if (i == 0 || i == 1)
                return 1;
            else
                return Recursion(i - 1) + 2 * Recursion(i - 2);    
        }
        
        static void Main(string[] args)
        {
            Console.Write("i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"i[{i}] = {Recursion(i)}");
        }
    }
}
```

