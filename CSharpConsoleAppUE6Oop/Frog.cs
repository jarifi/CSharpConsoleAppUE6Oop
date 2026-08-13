using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Frog : Animal, ISwimmable
    {
        public Frog(string name, int age) : base(name, age) { }

        public void Rename(string newName)
        {
            Name = newName; // This will call the setter of the Name property in the base class, which includes validation.
        }

        public override void MakeSound()
        {
            Console.WriteLine("Ribbit!");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }
    }
}
