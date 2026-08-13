using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAppUE6Oop
{
    internal abstract class Animal
    {
        private string _name = string.Empty;
        private int _age;
        public State AnimalState { get; set; }
        public string Colour { get; set; } = string.Empty;

        public string Name
        {
            get => _name;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value == "Hitler")
                {
                    throw new ArgumentException("Name cannot be null, whitespace, or 'Hitler'.", nameof(value));
                }
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.", nameof(value));
                }
                _age = value;
            }
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();

        public void MakeJump()
        {
            Console.WriteLine($"{_name} is jumping!");
        }

        public Animal(string name, int age, State state, string colour)
            : this(name, age)
        {
            AnimalState = state;
            Colour = colour ?? string.Empty;
        }
    }
}