# ЛАБОРАТОРНА РОБОТА № 11

## Завдання 1

| **Клас** | **Трикутник** |
| ------ | ------ |
| **Поля** | для зберігання довжин сторін; |
| **Методи** | конструктор без параметрів, конструктор з параметрами, конструкторкопіювання; |
|    | введення/виведення даних; |
|    | визначення площі; |
|    | визначення периметру; |
|    | порівняння з іншим трикутником; |
|    | перевантаження операторів + (додавання довжин сторін), – (віднімання довжин відповідних сторін), * (множення сторін на деяке число).|

### Program.cs
```cs
using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle tr1 = new Triangle(3, 4, 5);
                Triangle tr2 = new Triangle(6, 8, 10);

                Console.Write("Enter some num: ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"S = {tr1.Area()}");
                Console.WriteLine($"P = {tr1.Perimeter()}");
                 if (t1 == tr2)
                    Console.WriteLine("Equal");
                else
                    Console.WruteLine("Not equal");
                
                Console.WriteLine($"Added {num}: {tr1 + num}");
                Console.WriteLine($"Multiplied {num}: {tr1 * num}");
                Console.WriteLine($"Subtracted {num}: {tr1 - num}");

                Triangle copiedTriangle = new Triangle(tr2);
                Console.WriteLine(copiedTriangle);
            }

            catch
            {
                Console.WriteLine("Side of triangle must be positive.");
            }
        }
    }
}
```

### Triangle.cs
```cs
using System;

namespace Lab11
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set
            {
                if (value < 0)
                    throw new Exception("Side must be positive number");
                a = value;
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value < 0)
                    throw new Exception("Side must be positive number");
                b = value;
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                if (value < 0)
                    throw new Exception("Side must be positive number");
                c = value;
            }
        }

        public Triangle(double userA, double userB, double userC)
        {
            A = userA;
            B = userB;
            C = userC;
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c}";
        }
        
        // Copy constructor
        public Triangle(Triangle previousTriangle)
        {
            A = previousTriangle.a;
            B = previousTriangle.b;
            C = previousTriangle.c;
        }

        // Area
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        
        // Perimeter
        public double Perimeter()
        {
            return a + b + c;
        }
        
        //Comparing triangles
        public bool Compare(double newA, double newB, double newC)
        {
            if (a == newA && b == newB && c == newC)
                return true;
            else
                return false;
        }
        
        // Overloading +
        public static Triangle operator +(Triangle triangle, double num)
        {
            return new Triangle(triangle.a + num, triangle.b + num, triangle.c + num);
        }
        
        // Overloading -
        public static Triangle operator -(Triangle triangle, double num)
        {
            return new Triangle(triangle.a - num, triangle.b - num, triangle.c - num);
        }

        // Overloading *
        public static Triangle operator *(Triangle triangle, double num)
        {
            return new Triangle(triangle.a * num, triangle.b * num, triangle.c * num);
        }
    }
}
```
