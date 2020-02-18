using System;

namespace lab4_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x3 = ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3 = ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(x2 - x2, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double cosA = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            double cosB = (Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a);
            double cosC = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);

            if (cosA < 0 || cosB < 0 || cosC < 0)
                Console.WriteLine("Тупокутний");
            else
                Console.WriteLine("Не тупокутний");
        }
    }
}
