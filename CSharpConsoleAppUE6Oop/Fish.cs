using CSharpConsoleAppUE6Oop;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppue7
{
    internal class Fish : Animal, ISwimmable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Blub");
        }
        public void Swim()
        {
            Console.WriteLine("The fish is swimming");
        }
    }
}
