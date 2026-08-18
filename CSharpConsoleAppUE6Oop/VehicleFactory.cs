using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class VehicleFactory
    {
        public static Vehicle CreateVehicle(string vehicleType, Brand brand, ProductionState productionState, string model, DateOnly yearOfManufacture)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car(brand, productionState, model, yearOfManufacture);
                case "motorcycle":
                    return new Motorcycle(brand, productionState, model, yearOfManufacture);
                default:
                    throw new ArgumentException($"Invalid vehicle type: {vehicleType}");
            }
        }
    }
}
