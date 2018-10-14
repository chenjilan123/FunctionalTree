using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTree.VehicleFactory
{
    public abstract class AbstractDataFactory
    {
        public abstract IVehicleTreeBuilder CreateVehicleTreeBuilder();
    }
}
