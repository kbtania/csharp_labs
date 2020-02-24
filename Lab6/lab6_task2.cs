using System;

namespace lab6_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[i];
            double numerator = 1;
            double denominator = 0;
            int sumPositive = 0;
            int sumNegative = 0;
            for (int x = 1; x < i + 1; x++)
            {
                double product = (2 * x - 1) * Math.Cos(x);
                denominator += Math.Pow(x, 2);
                numerator *= product;
                double element = numerator / denominator;
                if (element > 0)
                    sumPositive++;

                else
                    sumNegative++;

                if (x < i)
                    arr[x - 1] = element;
            }

            if (sumNegative < sumPositive)

                Console.WriteLine(-1);
            else
                Console.WriteLine(1);


        }
    }  
}



