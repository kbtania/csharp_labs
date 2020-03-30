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
        public static bool operator ==(Triangle tr1, Triangle tr2)
        {
            return tr1.a == tr2.a && tr1.b == tr2.b && tr1.c == tr2.c;
        }
        
        public static bool operator !=(Triangle tr1, Triangle tr2)
        {
            return !(tr1 == tr2);
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
