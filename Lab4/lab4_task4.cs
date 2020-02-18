using System;

namespace lab4_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a < b && b < c)
                Console.WriteLine('1');
            
            else if (a == b && a == c)
                Console.WriteLine('2');
            
            else if (b < a && a < c)
                Console.WriteLine('3');
            
            else
                Console.WriteLine('0');
            
        }
    }
}
