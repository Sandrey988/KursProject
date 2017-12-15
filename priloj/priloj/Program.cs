using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace priloj
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmldoc = new XDocument(
              new XElement("Root"));

            Random ran = new Random();

            for (int i = 0; i < 100000; i++)
            {
                string Name = "Country";
                string FirmName = "FirmName";
                Name += i;
                FirmName +=i; 
                xmldoc.Root.Add(new XElement("Order", new XElement("Country_Names",Name), new XElement("Firm_Names", FirmName)));
            }

            xmldoc.Save("comp.xml");
        }
    }
}
