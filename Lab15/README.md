# ЛАБОРАТОРНА РОБОТА № 15

## Завдання 
- Створити клас, що містить методи знаходження розв’язків системи двох лінійних
рівнянь з двома невідомими та системи трьох лінійних рівнянь з трьома
невідомими. Для системи двох лінійних рівнянь з двома невідомими та системи трьох
лінійних рівнянь з трьома невідомими передбачити відповідні інтерфейси.

## IMatrix2x2.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15Test
{
    interface IMatrix2x2
    {
        void SetValues(ref Equation mtrx);
        void EquationOutput();
        void Solution(out double x1, out double x2);
    }
}
```

## IMatrix3x3.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15Test
{
    interface IMatrix3x3
    {
        void SetValues(ref Equation mtrx);
        void EquationOutput();
        void Solution(out double x1, out double x2, out double x3);
    }
}
```

## Matrix.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15Test
{
    class Equation : IMatrix2x2, IMatrix3x3
    {
        private double[,] matrix = new double[3,4];
        
        public double[,] Matrix {get;set;}

        public Equation()
        {
            Matrix = matrix;
        }
        
        public double this[int i, int j]
        {
            get
            {
                return Matrix[i, j];
            }
            set
            {
                Matrix[i, j] = value;
            }
        }

        // set values of coefficients of the system of TWO linear equations
        void IMatrix2x2.SetValues(ref Equation mtrx)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Coefficient {i}{j} = ");
                    mtrx[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        // finds the roots of the system of TWO linear equations using determinant
        void IMatrix2x2.Solution(out double x1, out double x2)
        {
            double det = Matrix[0, 0] * Matrix[1, 1] - Matrix[0, 1] * Matrix[1, 0];
            double det1 = Matrix[0, 2] * Matrix[1, 1] - Matrix[1, 2] * Matrix[0, 1];
            double det2 = Matrix[0, 0] * Matrix[1, 2] - Matrix[1, 0] * Matrix[0, 2];

            x1 = det1 / det;
            x2 = det2 / det;
        }

        // outputs the system of TWO linear equations
        void IMatrix2x2.EquationOutput()
        {
            Console.WriteLine($" {Matrix[0,0]}x+{Matrix[0,1]}y = {Matrix[0,2]}\n {Matrix[1,0]}x+{Matrix[1,1]}y = {Matrix[1,2]}");
        }


        // set values of coefficients of the system of THREE linear equations
        void IMatrix3x3.SetValues(ref Equation mtrx)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Coefficient {i}{j} = ");
                    mtrx[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        // finds the roots of the system of THREE linear equations using determinant
        void IMatrix3x3.Solution(out double x1, out double x2, out double x3)
        {
            
            double det = Matrix[0, 0] * Matrix[1, 1] * Matrix[2, 2] + 
                Matrix[0, 1] * Matrix[1, 2] * Matrix[2, 0] + 
                Matrix[1, 0] * Matrix[2, 1] * Matrix[0, 2] - 
                Matrix[2, 0] * Matrix[1, 1] * Matrix[0, 2] - 
                Matrix[1, 0] * Matrix[0, 1] * Matrix[2, 2] - 
                Matrix[2, 1] * Matrix[1, 2] * Matrix[0, 0]; 
            
            double det1 = Matrix[0, 2] * Matrix[1, 1] * Matrix[2, 2] + 
                Matrix[0, 1] * Matrix[1, 2] * Matrix[2, 3] +
                Matrix[1, 3] * Matrix[2, 1] * Matrix[0, 2] - 
                Matrix[2, 3] * Matrix[1, 1] * Matrix[0, 2] -
                Matrix[1, 3] * Matrix[0, 1] * Matrix[2, 2] -
                Matrix[2, 1] * Matrix[1, 2] * Matrix[0, 3];
            
            double det2 = Matrix[0, 0] * Matrix[1, 3] * Matrix[2, 2] + 
                Matrix[0, 3] * Matrix[1, 2] * Matrix[2, 0] + 
                Matrix[1, 0] * Matrix[2, 3] * Matrix[0, 2] - 
                Matrix[2, 0] * Matrix[1, 3] * Matrix[0, 2] -
                Matrix[1, 0] * Matrix[0, 3] * Matrix[2, 2] - 
                Matrix[2, 3] * Matrix[1, 2] * Matrix[0, 0];
            
            double det3 = Matrix[0, 0] * Matrix[1, 1] * Matrix[2, 3] +
                Matrix[0, 1] * Matrix[1, 3] * Matrix[2, 0] + 
                Matrix[1, 0] * Matrix[2, 1] * Matrix[0, 3] -
                Matrix[2, 0] * Matrix[1, 1] * Matrix[0, 3] -
                Matrix[1, 0] * Matrix[0, 1] * Matrix[2, 3] - 
                Matrix[2, 1] * Matrix[1, 3] * Matrix[0, 0];
            x1 = det1 / det;
            x2 = det2 / det;
            x3 = det3 / det;
        }

        // outputs the system of THREE linear equations
        void IMatrix3x3.EquationOutput()
        {
            Console.WriteLine($" {Matrix[0, 0]}x+{Matrix[0, 1]}y + {Matrix[0, 2]}z = {Matrix[0,3]}\n " +
                $"{Matrix[1, 0]}x+{Matrix[1, 1]}y + {Matrix[1, 2]}z = {Matrix[1,3]}\n" +
                $" {Matrix[2,0]}x + {Matrix[2,1]}y + {Matrix[2,2]}z = {Matrix[2,3]}");
        }

    }
}
```

## Program.cs
```cs
using System;

namespace Lab15Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I want to find a solution of system of:\n 1) TWO linear equations \n 2) THREE linear equations");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                double x1;
                double x2; 

                Equation eq = new Equation();
                IMatrix2x2 eq2 = (IMatrix2x2)eq;
                eq2.SetValues(ref eq);
                eq2.Solution(out x1, out x2);
                Console.WriteLine();
                eq2.EquationOutput();
                Console.WriteLine();
                
                Console.WriteLine($"x = {x1}, y = {x2}");
                
            }
            else if (userChoice == 2)
            {
                double x1;
                double x2;
                double x3;

                Equation eq = new Equation();
                IMatrix3x3 eq3 = (IMatrix3x3)eq;
                eq3.SetValues(ref eq);
                eq3.Solution(out x1, out x2, out x3);
                Console.WriteLine();
                eq3.EquationOutput();
                
                Console.WriteLine($"x = {x1}, y = {x2}, z = {x3}");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}
```
