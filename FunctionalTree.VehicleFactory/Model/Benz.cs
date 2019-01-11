using System.Drawing;

namespace FunctionalTree.VehicleFactory.Model
{
    public class Benz : Vehicle
    {
        public Benz()
        {
            base.ImageIndex = 0;
            base.SelectedImageIndex = 1;
        }
    }
}
