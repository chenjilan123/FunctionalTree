using FunctionalTree.VehicleFactory.XmlBuilder;

namespace FunctionalTree.VehicleFactory.Factories
{
    internal class XmlFactory : DataFactory
    {
        public override IVehicleTreeBuilder CreateVehicleTreeBuilder()
        {
            return new XmlVehicleTreeBuilder();
        }
    }
}
