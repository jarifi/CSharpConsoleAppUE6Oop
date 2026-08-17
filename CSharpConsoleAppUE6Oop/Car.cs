using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Car
    {
        public Brand Brand { get; set; }
        public ProductionState ProductionState { get; set; }
        public string Model { get; set; } = string.Empty;
        public DateOnly YearOfManifacture { get; set; }
     
    }
}
