using System;

namespace Lab12Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(12, 4, 2020);
            Console.WriteLine($"Previous date is {d1}");
            Console.WriteLine(d1['d']); // output by index
            
            // changing value by index
            d1['y'] = 1955; 
            d1['m'] = 12;
            
            Console.WriteLine($"Changed date is {d1}");
            Console.WriteLine("");

            // Adding d/m/y to the date
            Console.WriteLine("What do you want to change: day, month or year?");
            char choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"How many {choice} do you want to add?");
            int add = Convert.ToInt32(Console.ReadLine());
            
            d1.ChangeDate(ref d1, choice, add);
            Console.WriteLine(d1);



        }
    }
}
