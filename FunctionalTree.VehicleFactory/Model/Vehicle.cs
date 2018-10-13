using System.Windows.Forms;

namespace FunctionalTree.VehicleFactory.Model
{
    public abstract class Vehicle : TreeNode
    {
        public string Manufacturer { get; set; }
    }
}
