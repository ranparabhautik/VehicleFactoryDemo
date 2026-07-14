using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.AbstractProduct;
using VehicleFactoryDemo.ConcreteProduct;
using VehicleFactoryDemo.Enums;

namespace VehicleFactoryDemo.ConcreteFactory;

public class Bus_Factory : IVehicleFactory
{
    public VehicleType VehicleType => VehicleType.Bus;

    public Vehicle CreateVehicle(string VehicleNo, string ModelName, string color, int price)
    {
        return new Bus_Vehicle_Product
        {
            VehicleNo= VehicleNo,
            Color = color,
            Price = price,
            EmergencyExitCount = 3,
            FuelTankCapacity= 30,
            fuelType = FuelType.Diesel,
            Manifacturer = "Volvo",
            ManufacturingDate = DateTime.Now,
            ModelName = "Volvo 9600",
            SeatingCapacity = 32,
            StandingCapacity = 0,
            VehicleType  = VehicleType.Bus
        };
    }
}
