using FunctionalTree.VehicleFactory.Model;
using System;
using System.Windows.Forms;

namespace FunctionalTree
{
    public partial class VehicleDetail : UserControl
    {
        private Vehicle vehicle;
        public VehicleDetail()
        {
            InitializeComponent();
        }
        public void SetCurrentVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            UpdateInformation();
        }

        private void UpdateInformation()
        {
            throw new NotImplementedException();
        }
    }
}
