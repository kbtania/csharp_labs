# ЛАБОРАТОРНА РОБОТА № 5

## Завдання 1

- Дано `x, a Є R, n Є N`. Знайти `((...((x+a)² + a )² +... +a)² +a)² + a`.
```cs

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double s = Math.Pow(x + a, 2);

            for (int i = 0; i < n - 1; i++)
            {
                s = Math.Pow(s + a, 2);
            }
            Console.WriteLine("Sum = {0}", s);
        }
    }
}
```


## Завдання 2

- Дано `n Є N`. Побудувати алгоритм для визначенння найменшої цифри у записі цього числа `n`.
```cs
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int min = 10;
            while (number > 0)
            {
                if (number % 10 < min)
                    min = number % 10;
                
                number /= 10;
            }
            Console.WriteLine("The least number is {0}", min);
        }
    }
}
```

## Завдання 3

- Перевірити справедливість при заданій точності `ε`: `a^x = 1 + (x*ln a)/1! + (x*lna a)²/2! +...+(x*ln a)^n/n!+...`

```cs
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Accuracy = ");
            double accuracy = Convert.ToDouble(Console.ReadLine());
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double suma = 1;
            int n = 1;
            int f = 1;
            while (true)
            {
                double next_addition = Math.Abs(Math.Pow((x * Math.Log(a)), n) / f);
                if (next_addition >= accuracy)
                {
                    suma += next_addition;
                    n++;
                    f *= n;
                }
                else
                    break;
            }
            Console.WriteLine("Sum = " + suma);
        }

    }
}
```

## Задвання 4

- Нехай `x0 = 0, x1 = 9, xi = 2*xi-1 + 3*xi-2, де і = 1,2,... . Визначити xn.`

```cs
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = Convert.ToInt32(Console.ReadLine());
                int x0 = 0;
                int x1 = 9;
                int xn =10;
                for (int i = 0; i < n - 1; i++)
                {
                    xn = 2 * x1 + 3 * x0;
                    x0 = x1;
                    x1 = xn;
                    
                }
                Console.WriteLine("x(n) = {0}", xn);

            }
        }
    }
}
```
