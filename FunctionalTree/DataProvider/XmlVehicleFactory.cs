using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FunctionalTree.Model;
using FunctionalTree.ModelBase;

namespace FunctionalTree.DataProvider
{
    public class XmlVehicleFactory : VehicleFactory<XElement>
    {
        private static string[] vehicles = { "Benz", "Ferrari", "Honda" };
        public override TreeNode CreateVehicleNode(XElement xElement)
        {
            if (vehicles.Contains(xElement.Name.ToString()))
                return this.CreateVehicle(xElement);
            var node = new TreeNode(xElement.Name.ToString()) { ImageIndex = 6, SelectedImageIndex = 6};
            foreach (var childElement in xElement.Elements())
            {
                node.Nodes.Add(CreateVehicleNode(childElement));
            }
            return node;
        }

        public override Vehicle CreateVehicle(XElement element)
        {
            Vehicle vehicle = null;
            switch (element.Name.ToString())
            {
                case "Benz":
                    vehicle = new Benz()
                    {
                        ImageIndex = 0,
                        SelectedImageIndex = 1,
                    };
                    break;
                case "Honda":
                    vehicle = new Honda()
                    {
                        ImageIndex = 2,
                        SelectedImageIndex = 3,
                    };
                    break;
                case "Ferrari":
                    vehicle = new Ferrari()
                    {
                        ImageIndex = 4,
                        SelectedImageIndex = 5,
                    };
                    break;
                default:
                    break;
            }
            vehicle.Name = (string)element.Element("Name");
            vehicle.Text = vehicle.Name;
            
            return vehicle;
        }
    }
}
