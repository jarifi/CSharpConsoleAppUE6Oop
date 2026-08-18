using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Bus : Vehicle
    {
        public Bus(Brand brand, ProductionState productionState, string model, DateOnly yearOfManifacture) :
            base(brand, productionState, model, yearOfManifacture)
        {

        }

    }
}
