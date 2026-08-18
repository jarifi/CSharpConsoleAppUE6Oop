using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Tram : Vehicle
    {
        public Tram(Brand brand, ProductionState productionState, string model, DateOnly yearOfManifacture) : 
            base(brand, productionState, model, yearOfManifacture)
        {
        }
    }
}

