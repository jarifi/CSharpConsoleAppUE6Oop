using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal abstract class Animal
    {
        private string _name;
        private int _age;
        public State AnimalState { get; set; }
        public string Colour { get; set; }

        public string Name
        {
            get => _name;
            protected set {

                if (string.IsNullOrWhiteSpace(value) || value.Equals("Hitler"))
                {
                    throw new ArgumentException("Name cannot be null or whitespace.");
                }
                _name = value; 
            }
        }

       public int Age
        {
            get => _age;
            protected set => _age = value;
        }

        public Animal(string name, int age)
        {
            Name = name; // This will call the setter of the Name property, which includes validation.
            _age = age;
        }

        public abstract void MakeSound();

        public void MakeJump()
        {
            Console.WriteLine($"{_name} is jumping!");
        }
    }
}
