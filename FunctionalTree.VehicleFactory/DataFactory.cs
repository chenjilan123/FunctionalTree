using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTree.VehicleFactory
{
    public abstract class DataFactory
    {
        public abstract IVehicleTreeBuilder CreateVehicleTreeBuilder();

        //Here add new data builders
        //public abstract IUserModuleAutherizationProvider CreateUserModuleAutherizationProvider();
    }
}
