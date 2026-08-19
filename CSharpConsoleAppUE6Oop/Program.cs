using CSharpConsoleAppUE6Oop;

List<Vehicle> vehicles = new List<Vehicle>();
List<Vehicle> soldVehicles = new List<Vehicle>();


List<Person> persons = new List<Person>();

persons.Add(new Employee("John", "Doe", "john.doe@example.com", "123-456-7890", new DateOnly(1990, 1, 1), 1234, "Seller", 2500));
persons.Add(new Customer("Johan", "Doe", "johana.doe@example.com", "123-456-7891", new DateOnly(1990, 1, 1), 1234, 0));



Car car = (Car)VehicleFactory.CreateVehicle(
    VehicleType.Car, Brand.Toyota, ProductionState.InProduction,
    "Camry", new DateOnly(2020, 1, 1));
vehicles.Add(car);

Motorcycle motorcycle = (Motorcycle)VehicleFactory.CreateVehicle(
    VehicleType.Motorcycle, Brand.Honda, ProductionState.InProduction,
    "CBR500R", new DateOnly(2020, 1, 1));
vehicles.Add(motorcycle);

Bus bus = (Bus)VehicleFactory.CreateVehicle(
    VehicleType.Bus, Brand.Mercedes, ProductionState.InProduction,
    "O 2600", new DateOnly(1938, 1, 1));
vehicles.Add(bus);

Truck truck = (Truck)VehicleFactory.CreateVehicle(
    VehicleType.Truck, Brand.Volvo, ProductionState.InProduction,
    "FGH16", new DateOnly(2020, 1, 1));
vehicles.Add(truck);

Ship ship = (Ship)VehicleFactory.CreateVehicle(
    VehicleType.Ship, Brand.WhiteStarLine, ProductionState.InProduction,
    "Titanic", new DateOnly(1912, 4, 10));
vehicles.Add(ship);

Bicycle bicycle = (Bicycle)VehicleFactory.CreateVehicle(
    VehicleType.Bicycle, Brand.Trek, ProductionState.InProduction,
    "Domane", new DateOnly(2020, 1, 1));
vehicles.Add(bicycle);

Train train = (Train)VehicleFactory.CreateVehicle(
    VehicleType.Train, Brand.Siemens, ProductionState.InProduction,
    "Siemens", new DateOnly(2020, 1, 1));
vehicles.Add(train);

Airplane airplane = (Airplane)VehicleFactory.CreateVehicle(
    VehicleType.Airplane, Brand.Boeing, ProductionState.InProduction,
    "747", new DateOnly(2020, 1, 1));
vehicles.Add(airplane);

Tram tram = (Tram)VehicleFactory.CreateVehicle(
    VehicleType.Tram, Brand.Skoda, ProductionState.InProduction,
    "Siemens", new DateOnly(2020, 1, 1));
vehicles.Add(tram);

int vehicleIndex = 0;
Console.WriteLine("--- Lagerstand vorher ---");

Console.WriteLine("| Position | Brand| Model| Production Year| Production State|");
foreach (var vehicle in vehicles)
{
    Console.WriteLine
        (
        $"\n {++vehicleIndex} " + vehicle.Brand 
        + "," + vehicle.Model 
        + ", " + vehicle.YearOfManifacture 
        + ", " + vehicle.ProductionState
        );
}


// Verkauf von Fahrzeugen
Vehicle vehicleToSell = vehicles.FirstOrDefault(v => v.Brand == Brand.Toyota && v.Model == "Camry");
if (vehicleToSell != null)
{
    vehicles.Remove(vehicleToSell);
    soldVehicles.Add(vehicleToSell);
}


vehicleIndex = 0;
Console.WriteLine("--- Lagerstand nachher ---");

Console.WriteLine("| Position | Brand| Model| Production Year| Production State|");
foreach (var vehicle in vehicles)
{
    Console.WriteLine
        (
        $"\n {++vehicleIndex} " + vehicle.Brand
        + "," + vehicle.Model
        + ", " + vehicle.YearOfManifacture
        + ", " + vehicle.ProductionState
        );
}


vehicleIndex = 0;
Console.WriteLine("--- Lagerstand der verkauften Fahrzeuge ---");

Console.WriteLine("| Position | Brand| Model| Production Year| Production State|");
foreach (var vehicle in soldVehicles)
{
    Console.WriteLine
        (
        $"\n {++vehicleIndex} " + vehicle.Brand
        + "," + vehicle.Model
        + ", " + vehicle.YearOfManifacture
        + ", " + vehicle.ProductionState
        );
}


