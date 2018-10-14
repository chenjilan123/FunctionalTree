using FunctionalTree.VehicleFactory.DbBuilder;

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
