using FactoryPattern01;

Console.WriteLine("How many Wheels does your Vehicle Have?");

int numWheels = int.Parse(Console.ReadLine());

var vehicle = VehicleFactory.GetVehicle(numWheels);

vehicle.Drive();

