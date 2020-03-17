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
                Console.WriteLine($"Triangle with sides {tr2} is equal to {tr1}: {tr1.Compare(tr2.A, tr2.B, tr2.C)}");
                
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