# ЛАБОРАТОРНА РОБОТА № 12

## Завдання 1
- Створити клас TDate для роботи із датами у форматі “день.місяць.рік”. Дата
представляється структурою із трьома полями. Реалізувати методи збільшення/зменшення
дати на певну кількість днів, місяців чи років. Введення та виведення дати реалізувати за
допомогою методу ToString.

## Date.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12Task1
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 0 || value > 31)
                    throw new Exception("Day must be in range 1-31");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new Exception("Month must be in range 1-12");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                    throw new Exception("Year must be a positive integer");
            }
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // indexer
        public int this[char indx]
        {
            get
            {
                switch (indx)
                {
                    case 'd': return Day;
                    case 'm': return Month;
                    case 'y': return Year;
                    default: return 0;
                }
            }

            set
            {
                switch (indx)
                {
                    case 'd':
                        Day = value;
                        break;
                    case 'm':
                        Month = value;
                        break;
                    case 'y':
                        Year = value;
                        break;
                }
            }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public void ChangeDate(ref Date date, char choice, int add)
        {
            if (choice == 'd')
                date =  new Date(this['d'] + add, Month, Year);
            else if (choice == 'm')
                date =  new Date(Day, this['m'] + add, Year);
            else if (choice == 'y')
                date =  new Date(Day, Month, this['y']);
            else
                date = this;
        }

    }
}
```

## Program.cs
```cs
using System;

namespace Lab12Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(12, 4, 2020);
            Console.WriteLine($"Previous date is {d1}");
            Console.WriteLine(d1['d']); // output by index
            
            // changing value by index
            d1['y'] = 1955; 
            d1['m'] = 12;
            
            Console.WriteLine($"Changed date is {d1}");
            Console.WriteLine("");

            // Adding d/m/y to the date
            Console.WriteLine("What do you want to change: day, month or year?");
            char choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"How many {choice} do you want to add?");
            int add = Convert.ToInt32(Console.ReadLine());
            
            d1.ChangeDate(ref d1, choice, add);
            Console.WriteLine(d1);



        }
    }
}
```

## Завдання 2
- Реалізувати клас, щопредсатвляє трикутник (трикутник задається довжинами
сторін) і містить опис індексатора для доступу до сторін трикутника( a- перша сторона, b – друга сторона, c – третя сторна).
Передбачаити методи введення/виведення, знаходження периметру та площі.

## Triangle.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12Task2
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

        public double this[char indx]
        {
            get
            {
                switch (indx)
                {
                    case 'a': return A;
                    case 'b': return B;
                    case 'c': return C;
                    default: return 0;
                }
            }

            set
            {
                switch (indx)
                {
                    case 'a':
                        A = value;
                        break;
                    case 'b':
                        B = value;
                        break;
                    case 'c':
                        C = value;
                        break;
                }
            }
        }

        public override string ToString()
        {
            return $"Tiangle with sides: a = {A}, b = {B}, c = {C}";
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p*(p - A) * (p - B) * (p - C));
        }
    }
}
```
## Program.cs
```cs
using System;

namespace Lab12Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr1 = new Triangle(3, 4, 5);

            // changing values by index
            tr1['a'] = 6;
            tr1['b'] = 8;
            tr1['c'] = 10;
            Console.WriteLine("Area = " + tr1.Area());
            Console.WriteLine("Perimeter = " + tr1.Perimeter());
            Console.WriteLine(tr1);
            
        }

    }
}
```
