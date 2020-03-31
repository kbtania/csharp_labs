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
