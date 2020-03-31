# Модуль № 3

## Завдання 

| **Клас** | **Трикутник** |
| ------ | ------ |
| **Поля** | для зберігання довжин сторін; |
| **Методи** | конструктор без параметрів, конструктор з параметрами, конструкторкопіювання; |
|    | введення/виведення даних; |
|    | визначення площі; |
|    | визначення периметру; |
|    | порівняння з іншим трикутником; |
|    | перевантаження операторів + (додавання довжин сторін), – (віднімання довжин відповідних сторін), * (множення сторін на деяке число).|
|    | - Створити клас-нащадок TTrianglePrizm (пряма призма, в основі якої трикутник) на основі класу TTriangle. Додати метод зонаходження об’єму призми та перевизначити відпвідні методи.|
|    |- Створити програму-клієнт для тестування.|

## Triangle.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Module
{
    class Triangle
    {
        private protected double a;
        private protected double b;
        private protected double c;
        private protected const double EPSILON = 0.0001;

        public double A
        {
            get { return a; }
            set
            {
                if (value < 0)
                    throw new Exception("Side cannot be negative");
                a = value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value < 0)
                    throw new Exception("Side cannot be negative");
                b = value;
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value < 0)
                    throw new Exception("Side cannot be negative");
                c = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // copy constructor
        public Triangle(Triangle previousTriangle)
        {
            A = previousTriangle.a;
            B = previousTriangle.b;
            C = previousTriangle.c;
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c}";
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

        // Comparing triangles
        public static bool operator ==(Triangle tr1, Triangle tr2)
        {
            return (Math.Abs(tr1.a - tr2.a) < EPSILON && Math.Abs(tr1.b - tr2.b) < EPSILON && Math.Abs(tr1.c - tr2.c) < EPSILON);
        }

        public static bool operator !=(Triangle tr1, Triangle tr2)
        {
            return !(tr1 == tr2);
        }

        // Overloading +
        public static Triangle operator +(Triangle tr1, Triangle tr2)
        {
            return new Triangle(tr1.a + tr2.a, tr1.b + tr2.b, tr1.c + tr2.c);
        }

        // Overloading -
        public static Triangle operator -(Triangle tr1, Triangle tr2)
        {
            return new Triangle(tr1.a - tr2.a, tr1.b - tr2.b, tr1.c - tr2.c);
        }

        // Overloading *
        public static Triangle operator *(Triangle triangle, double num)
        {
            return new Triangle(triangle.a * num, triangle.b * num, triangle.c * num);
        }

    }
}
```
## TrianglePrizm.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Module
{
    class TrianglePrizm:Triangle
    {
        private double h;
        public double H
        {
            get { return h; }
            set
            {
                if (value < 0)
                    throw new Exception("Side cannot be negative");
                h = value;
            }
        }
        public TrianglePrizm(double a, double b, double c, double h):base(a, b, c)
        {
            H = h;
        }

        // площа повної поверхні
        public new double Area()
        {
            return Perimeter() * h * 2 * base.Area();
        }

        // volume
        public double Volume()
        {
            return base.Area() * h;
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c}, h = {h}";
        }

        public static TrianglePrizm operator +(TrianglePrizm trpr1, TrianglePrizm trpr2)
        {
            return new TrianglePrizm(trpr1.a + trpr2.a, trpr1.b + trpr2.b, trpr1.c + trpr2.c, trpr1.h + trpr2.h);
        }

        public static TrianglePrizm operator -(TrianglePrizm trpr1, TrianglePrizm trpr2)
        {
            return new TrianglePrizm(trpr1.a - trpr2.a, trpr1.b - trpr2.b, trpr1.c - trpr2.c, trpr1.h - trpr2.h);
        }

        public static TrianglePrizm operator *(TrianglePrizm trpr, double num)
        {
            return new TrianglePrizm(trpr.a * num, trpr.b * num, trpr.c * num, trpr.h*num);
        }

        public static bool operator ==(TrianglePrizm trpr1, TrianglePrizm trpr2)
        {
            return (Math.Abs(trpr1.a - trpr2.a) < EPSILON && Math.Abs(trpr1.b - trpr2.b) < EPSILON && Math.Abs(trpr1.c - trpr2.c) < EPSILON && Math.Abs(trpr1.h-trpr2.h)<EPSILON);
        }

        public static bool operator !=(TrianglePrizm trpr1, TrianglePrizm trpr2)
        {
            return !(trpr1 == trpr2);
        }
    }
}
```

## Program
```cs
using System;

namespace Module
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle tr1 = new Triangle(3, 4, 5);
                Triangle tr2 = new Triangle(6, 8, 10);
                Console.WriteLine($"Tr1: {tr1}");
                Console.WriteLine($"Tr2: {tr2}");
                Console.WriteLine($"Area of Tr1 = {tr1.Area()}");
                Console.WriteLine($"Perimeter of Tr2 = {tr1.Perimeter()}");
                Console.WriteLine("");
            
                TrianglePrizm trpr1 = new TrianglePrizm(3, 4, 5, 10);
                Console.WriteLine($"Prizm: {trpr1}");
                Console.WriteLine($"Volume of prizma = {trpr1.Volume()}");
                Console.WriteLine("");

                Console.WriteLine($"Tr1+Tr2: {tr1 + tr2}");
                Console.WriteLine($"Tr2-Tr1: {tr2 - tr1}");
                Console.WriteLine($"{tr1*10}");
                Console.WriteLine("");

                Console.WriteLine($"Tr1 = Tr2: { tr1 == tr2}");
            }
            catch
            {
                Console.WriteLine("Side cannot be negative");
            }


        }
    }
}
```
