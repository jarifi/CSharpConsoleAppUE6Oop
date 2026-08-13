using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Dog: Animal, ISwimmable
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Woof!");
        }

        public void Swim()
        {
            Console.WriteLine("The dog is swimming slower.");
        }

        public string Rename(string newName)
        {
            Name = newName;
            return Name;
        }

    }
}
