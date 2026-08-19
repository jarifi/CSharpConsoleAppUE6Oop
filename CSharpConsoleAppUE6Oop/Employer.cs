using System;

namespace CSharpConsoleAppUE6Oop
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string firstName, string lastName, string email, string phone, DateOnly dateOfBirth, int employeeId, string position, decimal salary)
            : base(firstName, lastName, email, phone, dateOfBirth)
        {
            EmployeeId = employeeId;
            Position = position;
            Salary = salary;
        }
    }
    }