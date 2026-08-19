using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class VehicleFactory
    {
        public static Vehicle CreateVehicle(VehicleType vehicleType, Brand brand, ProductionState productionState, string model, DateOnly yearOfManufacture)
        {
            switch (vehicleType)
            {
                case VehicleType.Car:
                    return new Car(brand, productionState, model, yearOfManufacture);
                case VehicleType.Motorcycle:
                    return new Motorcycle(brand, productionState, model, yearOfManufacture);
                case VehicleType.Truck:
                    return new Truck(brand, productionState, model, yearOfManufacture);
                case VehicleType.Airplane:
                    return new Airplane(brand, productionState, model, yearOfManufacture);
                case VehicleType.Ship:
                    return new Ship(brand, productionState, model, yearOfManufacture);
                case VehicleType.Bus:
                    return new Bus(brand, productionState, model, yearOfManufacture);
                case VehicleType.Train:
                    return new Train(brand, productionState, model, yearOfManufacture);
                case VehicleType.Tram:
                    return new Tram(brand, productionState, model, yearOfManufacture);
                case VehicleType.Bicycle:
                    return new Bicycle(brand, productionState, model, yearOfManufacture);
                default:
                    throw new ArgumentException($"Invalid vehicle type: {vehicleType}");
            }
        }
    }
}
