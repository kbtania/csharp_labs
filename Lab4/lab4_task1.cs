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
