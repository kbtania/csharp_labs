using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = Convert.ToInt32(Console.ReadLine());
                int x0 = 0;
                int x1 = 9;
                int xn =10;
                for (int i = 0; i < n - 1; i++)
                {
                    xn = 2 * x1 + 3 * x0;
                    x0 = x1;
                    x1 = xn;
                    
                }
                Console.WriteLine("x(n) = {0}", xn);

            }
        }
    }
}
