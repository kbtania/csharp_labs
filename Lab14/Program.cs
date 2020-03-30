using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("Enter the amount of figures: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Body[] figures = new Body[n];
                Random rnd = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < figures.Length; i++)
                {
                    switch (rnd.Next(1,3))
                    {
                        case 1: figures[i] = new Parallelepiped(rnd.Next(1,10), rnd.Next(1,10), rnd.Next(1,10));
                            break;
                        case 2: figures[i] = new Ball(rnd.Next(1, 10));
                            break;
                    }
                }

                // outputs every figure
                for (int i = 0; i < figures.Length; i++)
                {
                    Console.WriteLine(figures[i]);
                }

                // calculates the general area
                double sum = 0;
                for (int i = 0; i < figures.Length; i++)
                {
                    sum += figures[i].Area();
                }

                Console.WriteLine(" ");
                Console.WriteLine($"SUM = {sum}");
            }
            catch
            {
                Console.WriteLine("Cannot be negative");
            }
        }
    }
}
