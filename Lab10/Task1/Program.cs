using System;

namespace Lab10Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Number n = new Number(number);

                Console.WriteLine($"The number: {n.ToString()}");
                Console.WriteLine($"Count of digits: {n.CountOfNums()}");
                Console.WriteLine($"Sum of digits: {n.SumOfDigits()}");
            }
            catch
            {
                Console.WriteLine("Number must be positive integer.");
            }
        }
    }
}