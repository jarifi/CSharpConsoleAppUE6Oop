using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Duck : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Quack!");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }

    }
}
