using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal abstract class Vehicle
    {
        public CarBrand CarBrand { get; set; }
        public MotorcycleBrand MotorcycleBrand { get; set; }
        public ProductionState ProductionState { get; set; }
        public string Model { get; set; } = string.Empty;
        public DateOnly YearOfManifacture { get; set; }
     
    }
}
