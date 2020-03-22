using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle tr1 = new Triangle(3, 4, 5);
                Triangle tr2 = new Triangle(6, 8, 10);

                Console.Write("Enter some num: ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"S = {tr1.Area()}");
                Console.WriteLine($"P = {tr1.Perimeter()}");
                if (t1 == tr2)
                    Console.WriteLine("Equal");
                else
                    Console.WruteLine("Not equal");
                
                Console.WriteLine($"Added {num}: {tr1 + num}");
                Console.WriteLine($"Multiplied {num}: {tr1 * num}");
                Console.WriteLine($"Subtracted {num}: {tr1 - num}");

                Triangle copiedTriangle = new Triangle(tr2);
                Console.WriteLine(copiedTriangle);
            }

            catch
            {
                Console.WriteLine("Side of triangle must be positive.");
            }
        }
    }
}
