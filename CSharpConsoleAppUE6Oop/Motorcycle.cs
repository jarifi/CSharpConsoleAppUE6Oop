using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(Brand brand, ProductionState productionState, string model, DateOnly yearOfManufacture) : base(brand, productionState, model, yearOfManufacture)
        {
        }
    }
}
