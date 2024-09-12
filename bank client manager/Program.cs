
using System;

class Program
{
    static void Main(string[] args)
    {
        BankClientsManager manager = BankClientsManager.Instance;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nWelcome to the bank's customer management system!");
            Console.WriteLine("1. Add a new customer");
            Console.WriteLine("2. Delete an existing customer");
            Console.WriteLine("3. View the customer list");
            Console.WriteLine("4. Exit the application");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddCustomer(manager);
                    break;
                case "2":
                    RemoveCustomer(manager);
                    break;
                case "3":
                    manager.DisplayClients();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Thank you for using our app!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Helper method to add a customer
    static void AddCustomer(BankClientsManager manager)
    {
        Console.Write("Enter the new customer's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter the new customer's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter the new customer's account balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());

        manager.AddClient(firstName, lastName, balance);
    }

    // Helper method to remove a customer
    static void RemoveCustomer(BankClientsManager manager)
    {
        Console.Write("Enter the customer ID to remove: ");
        int clientId = int.Parse(Console.ReadLine());
        manager.RemoveClient(clientId);
    }
}
