using System;

namespace Lab10Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateProductionManufacturer = new DateTime(1967, 1, 1);
            DateTime dateProductionSeller = new DateTime(2001, 1, 1);
            DateTime dateProductionCar= new DateTime(2016, 1, 1);
            DateTime currDate = new DateTime(2020, 1, 1);
            Manufacturer m = new Manufacturer("Hyundai Motor Group", dateProductionManufacturer, 03144653, 100000);
            Seller s = new Seller("SellingCars", dateProductionSeller, 123, 95 );
            Owner o = new Owner("Pet", 111);
            
            Console.WriteLine("------- Car info -------");

            Automobile auto = new Automobile("Hyundai", "black", 3232, m, s, o, dateProductionCar);
            Console.WriteLine(auto);
            Console.WriteLine($"The age of car is {auto.GetAge(currDate)}");
        
        }
    }
}
