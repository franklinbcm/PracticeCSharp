using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace PracticeCSharp
{
    public class XmlConverter
    {
        public XDocument GetXml()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Paises");
            var xAttributes = new Paises().CountryList()
                .Select(c => new XElement("Pais",
                    new XAttribute("Nombre", c.Name), 
                    new XAttribute("Habitantes", c.Population)
                ));
            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            return xDocument;
        }

        public void ConvertXmlToJson()
        {
            var country = GetXml()
                .Element("Paises")
                .Elements("Pais")
                .Select(c => new Paises
                {
                    Name = c.Attribute("Nombre").Value,
                    Population = int.Parse(c.Attribute("Habitantes").Value)

                });

            Console.WriteLine(JsonConvert.SerializeObject(country));
            Console.ReadLine();
        }

    }

    public class Paises
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public List<Paises> CountryList()
        {
            List<Paises> Lista = new List<Paises>();
            Lista.Add(new Paises() { Name = "Republica Dominicana", Population =  25222 });
            Lista.Add(new Paises() { Name = "Peru", Population = 12656 });
            Lista.Add(new Paises() { Name = "Cuba", Population = 36569 });
            Lista.Add(new Paises() { Name = "Jamaica", Population = 42566 });

            return Lista;
        }

    }
}
