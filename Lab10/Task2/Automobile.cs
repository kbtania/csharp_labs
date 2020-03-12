using System;

namespace Lab10Task2
{
    public class Automobile
    {
        private string brand;
        private string color;
        private int carNum;
        private DateTime year;
        private Manufacturer manufacturer;
        private Seller seller;
        private Owner owner;
        

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int CarNum
        {
            get { return carNum; }
            set { carNum = value; }
        }

        public Manufacturer Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public Seller Seller
        {
            get { return seller; }
            set { seller = value; }
        }

        public Owner Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public DateTime Year
        {
            get { return year; }
            set { year = value; }
        }
        public Automobile(string brand, string color, int carNum,
            Manufacturer manufacturer, Seller seller, Owner owner, DateTime year)
        {
            Brand = brand;
            Color = color;
            CarNum = carNum;
            Manufacturer = manufacturer;
            Seller = seller;
            Owner = owner;
            Year = year;
        }
        
        public override string ToString()
        {
            return $"BRAND: {brand} \r\nCOLOR: {color} \r\nCAR NUMBER: {carNum} " +
                   $"\r\nMANUFACTURER: {manufacturer.Name} " +
                   $" \r\nSELLER: {seller.Name}  \r\nOwner: {owner.Name} " +
                   $"\r\nPRODUCTION YEAR: {year.ToString("MMMM yyyy")}";
        }

        public int GetAge(DateTime currentDate)
        {
            return currentDate.Year - year.Year;
        }
        
    }
}