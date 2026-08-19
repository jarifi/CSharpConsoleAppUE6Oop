using System;

namespace CSharpConsoleAppUE6Oop
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, string email, string phone, DateOnly dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            DateOfBirth = dateOfBirth;
        }

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{FullName} ({Email})";
        }
    }