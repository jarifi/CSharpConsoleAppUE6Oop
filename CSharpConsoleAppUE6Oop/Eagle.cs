using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Eagle : Bird, IFlyable
    {
        // Add a constructor that calls the base Bird constructor
        public Eagle(string name, int age) : base(name, age)
        {
        }

        public int Altitude
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void MakeSound()
        {
            Console.WriteLine("Screech!");
        }

        public void Fly()
        {
            Console.WriteLine("Eagle is flying.");
        }

        public void FlyTo(string destination)
        {
            throw new NotImplementedException();
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public void avoidCollision()
        {
            throw new NotImplementedException();
        }
    }
}

