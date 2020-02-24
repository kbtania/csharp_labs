using System;

namespace lab6_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element[{0}] = ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(numbers.Min());
        }
    }
}
