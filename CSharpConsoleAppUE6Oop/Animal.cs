using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal abstract class Animal
    {
        public required string Name { get; set; }
        public required int Age { get; set; }
        public abstract void MakeSound();

        public void MakeJump()
        {
            Console.WriteLine($"{Name} is jumping!");
        }
    }
}
