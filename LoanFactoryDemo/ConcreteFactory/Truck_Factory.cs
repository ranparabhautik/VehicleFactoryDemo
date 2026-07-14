using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.AbstractProduct;
using VehicleFactoryDemo.ConcreteProduct;
using VehicleFactoryDemo.Enums;

namespace VehicleFactoryDemo.ConcreteFactory;

public class Truck_Factory : IVehicleFactory
{
    public VehicleType VehicleType => VehicleType.Truck;

    public Vehicle CreateVehicle(string VehicleNo, string ModelName, string color, int price)
    {
        return new Truck_Vehicle_Product
        {
            VehicleType = VehicleType.Truck,
            VehicleNo = VehicleNo,
            ModelName = ModelName,
            Price = price,
            Color = color,
            FuelTankCapacity = 50,
            fuelType=FuelType.Diesel,
            Manifacturer = "Ashok Leyland",
            ManufacturingDate = DateTime.Now,
            MaxLoad = 60,
            NoOfAxles = 6,
            SeatingCapacity = 3
        };
    }
}
