using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.Enums;

namespace VehicleFactoryDemo.FactoryProvider;

public class VehicleFactoryProvider : IVehicleFactoryProvider
{
    private readonly Dictionary<VehicleType, IVehicleFactory> _factory;
    public VehicleFactoryProvider(IEnumerable<IVehicleFactory> factories)
    {
        _factory = factories.ToDictionary(x=> x.VehicleType);
    }
    public IVehicleFactory GetFactory(VehicleType Typee)
    {
        //if(!_factory.TryGetValue(Typee,out var factory))
        //{
        //    throw new ArgumentException("No vehicle found");
        //}
        if (_factory.ContainsKey(Typee))
        {
            return _factory[Typee];
        }
        throw new ArgumentException("No vehicle found");
        //return factory;
    }

    

}
