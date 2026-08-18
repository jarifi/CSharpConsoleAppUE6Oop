using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Airplane : Vehicle, IFlyable
    {
        public Airplane(Brand brand, ProductionState productionState, string model, DateOnly yearOfManufacture) : base(brand, productionState, model, yearOfManufacture)
        {
        }

        public int Altitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void avoidCollision()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void FlyTo(string destination)
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }
    }
}
