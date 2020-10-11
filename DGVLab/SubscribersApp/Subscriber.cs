//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



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

        public Subscriber(XmlElement element)
        {
            Subscriber sub = Subscriber.FromXmlElement(element);
            Name = sub.Name;
            Number = sub.Number;
            Year = sub.Year;
            Debt = sub.Debt;
        }

        // returns Xml based on object
        public XmlElement ToXmlElement(XmlDocument doc) 
        {
            XmlElement subscriber = doc.CreateElement("subscriber");
            subscriber.InnerText = Name;
            subscriber.SetAttribute("number", Number.ToString());
            subscriber.SetAttribute("startYear", Year.ToString());
            subscriber.SetAttribute("debt", Debt.ToString().ToLower());
            return subscriber;
        }

        // returns Object based on Xml
        public static Subscriber FromXmlElement(XmlElement element)      
        {
            string name = element.InnerText;
            int number = Convert.ToInt32(element.GetAttribute("number"));
            int startYear = Convert.ToInt32(element.GetAttribute("startYear"));
            bool debt = Convert.ToBoolean(element.GetAttribute("debt").ToLower());
            return new Subscriber(name, number, startYear, debt);
        }

        public override string ToString()
        {
            return $"{Name}  {Number}  {Year}";
        }
    }
}
