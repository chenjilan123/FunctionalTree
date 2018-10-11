using FunctionalTree.ModelBase;
using System.Windows.Forms;

namespace FunctionalTree.DataProvider
{
    public abstract class VehicleFactory<T>
    {
        public abstract TreeNode CreateVehicleNode(T root);

        public abstract Vehicle CreateVehicle(T element);
    }
}
