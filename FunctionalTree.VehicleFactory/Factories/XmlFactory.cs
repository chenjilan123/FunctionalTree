using FunctionalTree.VehicleFactory.XmlBuilder;

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
