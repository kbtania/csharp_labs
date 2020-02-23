using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int min = 10;
            while (number > 0)
            {
                if (number % 10 < min)
                    min = number % 10;
                
                number /= 10;
            }
            Console.WriteLine("The least number is {0}", min);
        }
    }
}
