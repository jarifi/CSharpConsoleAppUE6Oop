using CSharpConsoleAppUE6Oop;

List<Vehicle> vehicles = new List<Vehicle>();

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


// Get the last vehicle
Vehicle lastVehicle = vehicles.Last();

Console.WriteLine("Last vehicle:");
Console.WriteLine($"Brand: {lastVehicle.Brand}");
Console.WriteLine($"Model: {lastVehicle.Model}");