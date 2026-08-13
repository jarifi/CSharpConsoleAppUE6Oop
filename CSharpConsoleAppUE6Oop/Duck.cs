using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Duck : Animal
    {
        public Duck(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Quack!");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }

        public void Rename(string newName)
        {
            Name = newName;
        }
    }
}

