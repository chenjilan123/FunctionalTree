using System.Windows.Forms;

namespace FunctionalTree.VehicleFactory
{
    public interface IVehicleTreeBuilder
    {
        TreeNode GetRootNode();
    }
}
