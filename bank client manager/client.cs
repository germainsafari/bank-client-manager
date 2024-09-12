using System;

public class Client
{
    public int ClientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal AccountBalance { get; set; }

    public Client(int id, string firstName, string lastName, decimal balance)
    {
        ClientId = id;
        FirstName = firstName;
        LastName = lastName;
        AccountBalance = balance;
    }

    public override string ToString()
    {
        return $"ID: {ClientId}, First Name: {FirstName}, Last Name: {LastName}, Balance: {AccountBalance:C}";
    }
}
