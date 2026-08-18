using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Train : Vehicle
    {
        public Train(Brand brand, ProductionState productionState, string model, DateOnly yearOfManifacture) :
            base(brand, productionState, model, yearOfManifacture)
        {


        }
    }
}
