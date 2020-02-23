using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double s = Math.Pow(x + a, 2);

            for (int i = 0; i < n - 1; i++)
            {
                s = Math.Pow(s + a, 2);
            }
            Console.WriteLine("Sum = {0}", s);
        }
    }
}
