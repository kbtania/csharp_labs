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
