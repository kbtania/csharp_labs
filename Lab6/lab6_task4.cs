using System;
using System.Linq;
using System.Collections.Generic;

namespace lab6_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numArray = new double[size];
            for (int i = 0; i < size; i++)
                {
                    Console.Write("[{0}] number: ", i);
                    numArray[i] = Convert.ToDouble(Console.ReadLine());
                }

            double[] resArray = new double[size];
            for (int i = 0, j = 0; i < size; i++)
            {
                if (Math.Abs(numArray[i]) > 1)
                    resArray[j++] = numArray[i];
            }
            foreach (double element in resArray)
            {
                Console.Write("{0};  ", element);

            }

        }
    }
}
