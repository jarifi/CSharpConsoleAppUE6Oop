using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chrip!");
        }

        public void Rename(string newName)
        {
            Name = newName;

        }

        
    }
}
