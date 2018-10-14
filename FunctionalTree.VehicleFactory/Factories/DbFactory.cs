using FunctionalTree.VehicleFactory.DbFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTree.VehicleFactory.Factories
{
    internal class DbFactory : AbstractDataFactory
    {
        public override IVehicleTreeBuilder CreateVehicleTreeBuilder()
        {
            return new DbVehicleTreeBuilder();
        }
    }
}
