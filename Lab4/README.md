# ЛАБОРАТОРНА РОБОТА № 5

## Завдання 1

- Обчислити площу трикутника, якщо трикутник задано двома сторонами та кутом між ними.
```cs
using System;

namespace lab4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Angle = ");
            double angle = Convert.ToInt32(Console.ReadLine());
            double res = 0.5 * a * b * Math.Sin((angle * Math.PI) / 180);
            Console.WriteLine("The area of triangle is {0}", res);

        }
    }
}
```

## Завдання 2

- Дано цілі числа a, b, c Є Z. Визначити чи належить а множині {3, 4, 5,...,9}U{b, b+1, b+2, ..., c}.
```cs
using System;

namespace lab4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < 9 && a > 3 || a > b && a < c)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            
        }
    }
}
```

## Завдання 3

- Трикутник задаєтья координатами своїх вершин. Визначити чи є цей трикутник тупокутним.
```cs
using System;

namespace lab4_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x3 = ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3 = ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double cosA = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            double cosB = (Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a);
            double cosC = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);

            if (cosA < 0 || cosB < 0 || cosC < 0)
                Console.WriteLine("Тупокутний");
            else
                Console.WriteLine("Не тупокутний");
        }
    }
}
```

## Завдання 4

- y = 1, якщо а < b < c
- y = 2, якщо a = b = c
- y = 3, якщо b < a < c
- 0, в інших випадках
```cs
using System;

namespace lab4_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a < b && b < c)
                Console.WriteLine('1');
            
            else if (a == b && a == c)
                Console.WriteLine('2');
            
            else if (b < a && a < c)
                Console.WriteLine('3');
            
            else
                Console.WriteLine('0');
            
        }
    }
}
```


