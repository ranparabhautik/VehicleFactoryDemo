using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.AbstractProduct;
using VehicleFactoryDemo.Enums;
using VehicleFactoryDemo.FactoryProvider;

namespace VehicleFactoryDemo.Services;

public class VehicleServices
{
    private readonly IVehicleFactoryProvider _factoryProvider;
    public VehicleServices(IVehicleFactoryProvider factoryProvider)
    {
        _factoryProvider = factoryProvider;
    }

    public Vehicle CreateVehicle(VehicleType type, string Vehicleno, string color,string modelname,int price)
    {
        IVehicleFactory factory =  _factoryProvider.GetFactory(type);
        Vehicle vh =  factory.CreateVehicle(Vehicleno,modelname,color,price);
        return vh;

    }
}
