using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age){}

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }


    }
}
