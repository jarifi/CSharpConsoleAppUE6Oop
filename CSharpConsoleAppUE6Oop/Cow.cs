using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Moo!");
        }

        public void Rename(string newName)
        {
            Name = newName; 
        }


    }
}
