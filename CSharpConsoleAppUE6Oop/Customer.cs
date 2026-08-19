using CSharpConsoleAppUE6Oop;

public class Customer : Person
{
    public int CustomerId { get; set; }
    public decimal TotalSpent { get; set; }

    public Customer(string firstName, string lastName, string email, string phone, DateOnly dateOfBirth, int customerId, decimal totalSpent)
        : base(firstName, lastName, email, phone, dateOfBirth)
    {
        CustomerId = customerId;
        TotalSpent = totalSpent;
    }
}