using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Bicycle : Vehicle
    {
        public Bicycle(Brand brand, ProductionState productionState, string model, DateOnly yearOfManufacture) : base(brand, productionState, model, yearOfManufacture)
        {
        }
    }
}
