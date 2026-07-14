using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.AbstractProduct;
using VehicleFactoryDemo.ConcreteProduct;
using VehicleFactoryDemo.Enums;

namespace VehicleFactoryDemo.ConcreteFactory;

public class ElectricCar : IVehicleFactory
{
    public VehicleType VehicleType => VehicleType.ElectricCar;

    public Vehicle CreateVehicle(string VehicleNo, string ModelName, string color, int price)
    {
        return new ElectricCar_Vehicle_Product 
        {
            VehicleType = VehicleType.ElectricCar,
            Color = color,
            Price = price,
            BatteryCapacity = 550,
            fuelType = FuelType.Electric,
            Manifacturer = "MG",
            VehicleNo = VehicleNo,
            ManufacturingDate = DateTime.Now,
            ModelName = "Comet",
            RangePerCharge = 205,
            SeatingCapacity = 4
        };
    }
}
