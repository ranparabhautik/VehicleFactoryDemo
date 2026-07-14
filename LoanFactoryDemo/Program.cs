using Microsoft.Extensions.DependencyInjection;
using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.ConcreteFactory;
using VehicleFactoryDemo.Enums;
using VehicleFactoryDemo.FactoryProvider;
using VehicleFactoryDemo.Services;

Console.WriteLine("Hello, World!");

ServiceCollection services = new ServiceCollection();

services.AddScoped<IVehicleFactory,Car_Factory>();
services.AddScoped<IVehicleFactory,Bike_Factory>();
services.AddScoped<IVehicleFactory,Truck_Factory>();
services.AddScoped<IVehicleFactory,Bus_Factory>();
services.AddScoped<IVehicleFactory,ElectricCar>();
services.AddScoped<IVehicleFactoryProvider,VehicleFactoryProvider>();
services.AddScoped<VehicleServices>();


ServiceProvider provider = services.BuildServiceProvider();

VehicleServices services1 = provider.GetRequiredService<VehicleServices>();

var ch1 = services1.CreateVehicle(VehicleType.Car,"GJ03BR693","GLS","White",10000);

Console.WriteLine(ch1.Color);
Console.WriteLine(ch1.Manifacturer);
Console.WriteLine(ch1.ModelName);
Console.WriteLine(ch1.fuelType);
Console.WriteLine(ch1.Price);
Console.WriteLine(ch1.SeatingCapacity);
Console.WriteLine(ch1.VehicleNo);