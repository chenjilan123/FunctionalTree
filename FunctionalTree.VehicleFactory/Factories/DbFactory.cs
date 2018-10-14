using FunctionalTree.VehicleFactory.DbBuilder;

namespace FunctionalTree.VehicleFactory.Factories
{
    internal class DbFactory : DataFactory
    {
        public override IVehicleTreeBuilder CreateVehicleTreeBuilder()
        {
            return new DbVehicleTreeBuilder();
        }
    }
}
