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
