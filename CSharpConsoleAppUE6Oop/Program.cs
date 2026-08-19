using ConsoleAppue7;

namespace CSharpConsoleAppUE6Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = (Car)VehicleFactory.CreateVehicle(VehicleType.Car, Brand.Toyota, ProductionState.InProduction, "Camry", new DateOnly(2020, 1, 1));
            Console.WriteLine(car.Brand);
            Console.WriteLine(car.Model);

            Motorcycle motorcycle = (Motorcycle)VehicleFactory.CreateVehicle(VehicleType.Motorcycle, Brand.Honda, ProductionState.InProduction, "CBR500R", new DateOnly(2020, 1, 1));
            Console.WriteLine(motorcycle.Brand);
            Console.WriteLine(motorcycle.Model);

            Bus bus = (Bus)VehicleFactory.CreateVehicle(VehicleType.Bus, Brand.Mercedes, ProductionState.InProduction, "O 2600", new DateOnly(1938, 1, 1));
            Console.WriteLine(bus.Brand);
            Console.WriteLine(bus.Model);

            Truck truck = (Truck)VehicleFactory.CreateVehicle(VehicleType.Truck, Brand.Volvo, ProductionState.InProduction, "FGH16", new DateOnly(2020, 1, 1));
            Console.WriteLine(truck.Brand);
            Console.WriteLine(truck.Model);

            Ship ship = (Ship)VehicleFactory.CreateVehicle(VehicleType.Ship, Brand.WhiteStarLine, ProductionState.InProduction, "Titanic", new DateOnly(1912, 4, 10));
            Console.WriteLine(ship.Brand);
            Console.WriteLine(ship.Model);

            Bicycle bicycle = (Bicycle)VehicleFactory.CreateVehicle(VehicleType.Bicycle, Brand.Trek, ProductionState.InProduction, "Domane", new DateOnly(2020, 1, 1));
            Console.WriteLine(bicycle.Brand);
            Console.WriteLine(bicycle.Model);

            Train train = (Train)VehicleFactory.CreateVehicle(VehicleType.Train, Brand.Siemens , ProductionState.InProduction, "Siemens", new DateOnly(2020, 1, 1));
            Console.WriteLine(train.Brand);
            Console.WriteLine(train.Model);

            Airplane airplane = (Airplane)VehicleFactory.CreateVehicle(VehicleType.Airplane, Brand.Boeing, ProductionState.InProduction, "747", new DateOnly(2020, 1, 1));
            Console.WriteLine(airplane.Brand);
            Console.WriteLine(airplane.Model);

            Tram tram = (Tram)VehicleFactory.CreateVehicle(VehicleType.Tram, Brand.Skoda, ProductionState.InProduction, "Siemens", new DateOnly(2020, 1, 1)); 







        }
    }
}
