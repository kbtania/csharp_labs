using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Module1
{
    [Serializable]
    class Gallery
    {
        public int Id { get; set; }
        public string Painter { get; set; }
        public string NameOfPicture { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }

        public Gallery(int id, string painter, string nameOfPicture, double price, int status)
        {
            Id = id;
            Painter = painter;
            NameOfPicture = nameOfPicture;
            Price = price;
            Status = status;
        }

        // returns Xml based on object
        public XmlElement ToXmlElement(XmlDocument doc)
        {
            XmlElement gallery = doc.CreateElement("gallery");
            gallery.InnerText = NameOfPicture;
            gallery.SetAttribute("id", Id.ToString());
            gallery.SetAttribute("painter", Painter);
            gallery.SetAttribute("price", Price.ToString().ToLower());
            gallery.SetAttribute("status", Status.ToString());

            return gallery;
        }

        // returns Object based on Xml
        public static Gallery FromXmlElement(XmlElement element)
        {
            int Id = Convert.ToInt32(element.GetAttribute("id"));
            string NameOfPicture = element.InnerText;
            string Painter = element.GetAttribute("painter");
            double Price = Convert.ToDouble(element.GetAttribute("price"));
            int Status = Convert.ToInt32(element.GetAttribute("status"));
            return new Gallery(Id, Painter, NameOfPicture, Price, Status);
        }

        public override string ToString()
        {
            return $"id: {Id}\nAuthor: {Painter}\nName: {NameOfPicture}\nPrice: {Price}mln\nStatus: {Status}";
        }

    }
}
