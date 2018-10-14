using FunctionalTree.VehicleFactory.Model;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FunctionalTree.VehicleFactory.XmlBuilder
{
    public class XmlVehicleTreeBuilder : IVehicleTreeBuilder
    {
        private static string[] vehicles = { "Benz", "Ferrari", "Honda" };
        public TreeNode GetRootNode()
        {
            var xmlDoc = XDocument.Load("DataSource\\Vehicle.xml");
            var root = xmlDoc.Root;
            return GetVehicleNode(root);
        }

        /// <summary>
        /// 递归创建
        /// 可构建泛型参数的通用实现
        /// 参数为：TElement, Func<TElement, IEnumerable<TElement>>
        /// </summary>
        /// <param name="xElement"></param>
        /// <returns></returns>
        private TreeNode GetVehicleNode(XElement xElement)
        {
            if (vehicles.Contains(xElement.Name.ToString()))
                return this.CreateVehicle(xElement);
            var node = new TreeNode(xElement.Name.ToString()) { ImageIndex = 6, SelectedImageIndex = 6};
            foreach (var childElement in xElement.Elements())
            {
                node.Nodes.Add(GetVehicleNode(childElement));
            }
            return node;
        }

        private Vehicle CreateVehicle(XElement element)
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
