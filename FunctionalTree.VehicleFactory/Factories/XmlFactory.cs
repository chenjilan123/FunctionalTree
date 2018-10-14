using FunctionalTree.VehicleFactory.XmlFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTree.VehicleFactory.Factories
{
    internal class XmlFactory : AbstractDataFactory
    {
        public override IVehicleTreeBuilder CreateVehicleTreeBuilder()
        {
            return new XmlVehicleTreeBuilder();
        }
    }
}
