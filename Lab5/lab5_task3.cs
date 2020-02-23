using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Accuracy = ");
            double accuracy = Convert.ToDouble(Console.ReadLine());
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double suma = 1;
            int n = 1;
            int f = 1;
            while (true)
            {
                double next_addition = Math.Abs(Math.Pow((x * Math.Log(a)), n) / f);
                if (next_addition >= accuracy)
                {
                    suma += next_addition;
                    n++;
                    f *= n;
                }
                else
                    break;
            }
            Console.WriteLine("Sum = " + suma);
        }

    }
}
