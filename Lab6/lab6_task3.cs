using System;

namespace lab6_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];
            for (int x = 0; x < 3; x++)
            {
                Console.Write("[{0}] coordinate of first vector ", x+1);
                int v1 = Convert.ToInt32(Console.ReadLine());
                vector1[x] = v1;
            }
            for (int x = 0; x < 3; x++)
            {
                Console.Write("[{0}] coordinate of second vector ", x+1);
                int v2 = Convert.ToInt32(Console.ReadLine());
                vector2[x] = v2;
            }
            int xRes = vector1[1] * vector2[2] - vector1[2] * vector2[1];
            int yRes = vector1[2] * vector2[0] - vector1[0] * vector2[2];
            int zRes = vector1[0] * vector2[1] - vector1[1] * vector2[0];
            Console.WriteLine("Result: ({0}, {1}, {2})", xRes, yRes, zRes);
            
        }
    }
}
