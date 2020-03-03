using System;

namespace ConsoleApp5
{
    class Program
    {
        static int Recursion(int i)
        {
            if (i == 0 || i == 1)
                return 1;
            else
                return Recursion(i - 1) + 2 * Recursion(i - 2);    
        }
        
        static void Main(string[] args)
        {
            Console.Write("i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"i[{i}] = {Recursion(i)}");
        }
    }
}