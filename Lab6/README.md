# ЛАБОРАТОРНА РОБОТА № 6

## Завдання 1

- Дано n дійсних чисел x1, x2, ... xn. Знайти найменше серед них.
```cs
using System;
using System.Linq;

namespace lab6_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element[{0}] = ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(numbers.Min());
        }
    }
}
```

## Завдання 2

- Елементи масиву A(ai), i = (1,2,..,n) задаються так:
- ai = (cos1*(3*cos2)*(5*cos3)*..*(2i-1)*cosi)/(1+4+9+...+i^2)
- Обчислити z = -1, якщо сума квадратів відємних елементів менша за суму додатніх
-                1, в іншому випадку

```cs
using System;

namespace lab6_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[i];
            double numerator = 1;
            double denominator = 0;
            int sumPositive = 0;
            int sumNegative = 0;
            for (int x = 1; x < i + 1; x++)
            {
                double product = (2 * x - 1) * Math.Cos(x);
                denominator += Math.Pow(x, 2);
                numerator *= product;
                double element = numerator / denominator;
                if (element > 0)
                    sumPositive++;
                else
                    sumNegative++;
                if (x < i)
                    arr[x - 1] = element;
            }

            if (sumNegative < sumPositive)
                Console.WriteLine(-1);
            else
                Console.WriteLine(1);
        }
    }  
}
```
## Завдання 3

- Дано два вектори x, y Є R^n. Знайти векторний добуток веторів.
```cs
using System;

namespace lab6_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];
            for (int x = 0; x < 3; x++)
            {
                Console.Write("[{0}] coordinate of first vector ", x+1);
                int v1 = Convert.ToInt32(Console.ReadLine());
                vector1[x] = v1;
            }
            for (int x = 0; x < 3; x++)
            {
                Console.Write("[{0}] coordinate of second vector ", x+1);
                int v2 = Convert.ToInt32(Console.ReadLine());
                vector2[x] = v2;
            }
            int xRes = vector1[1] * vector2[2] - vector1[2] * vector2[1];
            int yRes = vector1[2] * vector2[0] - vector1[0] * vector2[2];
            int zRes = vector1[0] * vector2[1] - vector1[1] * vector2[0];
            Console.WriteLine("Result: ({0}, {1}, {2})", xRes, yRes, zRes);
            
        }
    }
}
```

## Завдання 4

- Стиснути масив, вилучивши з нього всі елементи, модуль яких не перевищує 1,
місце яке звільнилось в кінці масиву заповнити нулями.
```cs
using System;

namespace lab6_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numArray = new double[size];
            for (int i = 0; i < size; i++)
                {
                    Console.Write("[{0}] number: ", i);
                    numArray[i] = Convert.ToDouble(Console.ReadLine());
                }

            double[] resArray = new double[size];
            for (int i = 0, j = 0; i < size; i++)
            {
                if (Math.Abs(numArray[i]) > 1)
                    resArray[j++] = numArray[i];
            }
            foreach (double element in resArray)
                Console.Write("{0};  ", element);
        }
    }
}
```

