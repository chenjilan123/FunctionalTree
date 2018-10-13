using FunctionalTree.VehicleFactory.Model;

namespace FunctionalTree.VehicleFactory
{
    public abstract class IVehicleBuilder<T>
    {
        public abstract Vehicle CreateVehicle(T data);
    }
}
