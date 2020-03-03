using System;

namespace ConsoleApp1
{
    class Program
    { 
        static double Sum(double x)
        {
            if (x > 3)
            {
                double s = 0;
                for (int i = 1; i < 7; i++)
                    s += Math.Sin(Math.Pow(x, i));
                return s;
            }
            else
            {
                double z = -1;
                double s = 0;
                double a = Math.Cos(x);
                for (int i = 1; i < 6; i++)
                {
                    s = s + z * a;
                    a = Math.Cos(a);
                    z = -z;
                }

                return s;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double res1 = Sum(num1);
            double res2 = Sum(num2);
            Console.WriteLine(Math.Min(res1, res2));
        }
    }
}
