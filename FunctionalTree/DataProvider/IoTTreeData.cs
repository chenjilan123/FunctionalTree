using FunctionalTree.Model;
using FunctionalTree.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FunctionalTree.DataProvider
{
    public class IoTTreeData
    {
        public IEnumerable<Vehicle> GetVehicleTree()
        {
            var xmlDoc = XDocument.Load("DataSource\\Vehicle.xml");
            var root = xmlDoc.Root;
            var benzs = from v in root.Element("Benzs").Elements("Benz")
                             select (Vehicle)new Benz { Name = (string)v.Element("Name") };
            var ferraris = from v in root.Element("Ferraris").Elements("Ferrari")
                           select (Vehicle)new Ferrari { Name = (string)v.Element("Name") };
            var hondas = from v in root.Element("Hondas").Elements("Honda")
                           select (Vehicle)new Honda { Name = (string)v.Element("Name") };
            return benzs.Union(ferraris).Union(hondas);
        }
    }
}
