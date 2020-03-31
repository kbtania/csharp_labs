using System;

namespace Module
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle tr1 = new Triangle(3, 4, 5);
                Triangle tr2 = new Triangle(6, 8, 10);
                Console.WriteLine($"Tr1: {tr1}");
                Console.WriteLine($"Tr2: {tr2}");
                Console.WriteLine($"Area of Tr1 = {tr1.Area()}");
                Console.WriteLine($"Perimeter of Tr2 = {tr1.Perimeter()}");
                Console.WriteLine("");
            
                TrianglePrizm trpr1 = new TrianglePrizm(3, 4, 5, 10);
                Console.WriteLine($"Prizm: {trpr1}");
                Console.WriteLine($"Volume of prizma = {trpr1.Volume()}");
                Console.WriteLine("");

                Console.WriteLine($"Tr1+Tr2: {tr1 + tr2}");
                Console.WriteLine($"Tr2-Tr1: {tr2 - tr1}");
                Console.WriteLine($"{tr1*10}");
                Console.WriteLine("");

                Console.WriteLine($"Tr1 = Tr2: { tr1 == tr2}");
            }
            catch
            {
                Console.WriteLine("Side cannot be negative");
            }


        }
    }
}
