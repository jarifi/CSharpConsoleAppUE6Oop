using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal abstract class Vehicle
    {
        public Brand Brand { get; set; }
        public ProductionState ProductionState { get; set; }
        public string Model { get; set; } = string.Empty;
        public DateOnly YearOfManifacture { get; set; }

        public Vehicle(Brand brand, ProductionState productionState, string model, DateOnly yearOfManifacture)
        {
            Brand = brand;
            ProductionState = productionState;
            Model = model;
            YearOfManifacture = yearOfManifacture;
        }
    }
}
