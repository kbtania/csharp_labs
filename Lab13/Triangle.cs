using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class Triangle
    {
        private protected double a;
        private protected double b;
        private protected double c;
        private protected const double EPSILON = 0.0000001;

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


        public static Triangle operator +(Triangle tr1, Triangle tr2)
        {
            return new Triangle(tr1.a + tr2.a, tr1.b + tr2.b, tr1.c + tr2.c);
        }

        public static Triangle operator -(Triangle tr1, Triangle tr2)
        {
            return new Triangle(tr1.a - tr2.a, tr1.b - tr2.b, tr1.c - tr2.c);
        }

       
        public static Triangle operator *(Triangle tr, double num)
        {
            return new Triangle(tr.a * num, tr.b * num, tr.c * num);
        }
       
    }
}
