using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp
{
    [Serializable]
    class Subscriber
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public bool Debt { get; set; }
        public Subscriber(string name, int number, int year, bool debt)
        {
            Name = name;
            Number = number;
            Year = year;
            Debt = debt;
        }
        public override string ToString()
        {
            return $"{this.Name}  {this.Number}  {this.Year}";
        }
    }
}
