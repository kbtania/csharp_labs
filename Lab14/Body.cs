using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14
{
    public abstract class Body
    {
        private protected int data;
        public  int Data
        {
            get { return data; }
            set
            {
                if (value < 0)
                    throw new Exception("Cannot be negative");
                data = value;
            }
        }
        public Body(int data)
        {
            Data = data;
        }

        public abstract double Area();

        public abstract double Volume();



    }
}
