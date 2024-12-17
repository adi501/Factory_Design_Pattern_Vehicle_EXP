// Ref: https://medium.com/cloud-native-daily/factory-design-pattern-in-c-for-net-core-projects-9afcef346f66

using Factory_Design_Pattern_Vehicle_EXP.Factory;
using Factory_Design_Pattern_Vehicle_EXP;

VehicleFactory factory = new VehicleFactory();

IVehicle car = factory.CreateVehicle("Car");
car.Manufacture(); // Output: Car is being manufactured.

IVehicle bike = factory.CreateVehicle("Bike");
bike.Manufacture(); // Output: Bike is being manufactured.

IVehicle truck = factory.CreateVehicle("Truck");
truck.Manufacture(); // Output: Truck is being manufactured.

Console.ReadLine();