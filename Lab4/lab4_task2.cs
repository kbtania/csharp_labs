using System;

namespace lab4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < 9 && a > 3 || a > b && a < c)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            
        }
    }
}
