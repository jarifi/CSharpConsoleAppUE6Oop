using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Dog: Animal, ISwimmable
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Woof!");
        }

        public void Swim()
        {
            Console.WriteLine("The dog is swimming slower.");
        }
    

    }
}
