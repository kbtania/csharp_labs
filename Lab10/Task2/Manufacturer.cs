using System;

namespace Lab10Task2
{
    public class Manufacturer
    {
        private string name;
        private DateTime foundation;
        private int phoneNumber;
        private int productionVolume;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Foundation
        {
            get { return foundation; }
            set { foundation = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int ProdutionVolume
        {
            get { return productionVolume; }
            set { productionVolume = value; }
        }


        public Manufacturer(string name, DateTime foundation, int phoneNumber, int productionVolume)
        {
            Name = name;
            Foundation = foundation;
            PhoneNumber = phoneNumber;
            ProdutionVolume = productionVolume;
        }
        
        public override string ToString()
        {
            return $"Name: {name}\r\nFoundation: {foundation}\r\n" +
                   $"Phone Number: {phoneNumber}\r\nProduction Volume: {productionVolume}";
        }
        
        
        
    }
}