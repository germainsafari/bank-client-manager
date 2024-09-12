using System;
using System.Collections.Generic;

public class BankClientsManager
{
    private static BankClientsManager _instance;
    private List<Client> _clients;
    private int _clientIdCounter;

    // Private constructor to prevent instantiation from outside
    private BankClientsManager()
    {
        _clients = new List<Client>();
        _clientIdCounter = 1;
    }

    // Public method to get the single instance of the class
    public static BankClientsManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BankClientsManager();
            }
            return _instance;
        }
    }

    // Method to add a client
    public void AddClient(string firstName, string lastName, decimal balance)
    {
        Client newClient = new Client(_clientIdCounter++, firstName, lastName, balance);
        _clients.Add(newClient);
        Console.WriteLine("New client has been added!");
    }

    // Method to remove a client by ID
    public void RemoveClient(int clientId)
    {
        Client clientToRemove = _clients.Find(c => c.ClientId == clientId);
        if (clientToRemove != null)
        {
            _clients.Remove(clientToRemove);
            Console.WriteLine("Client has been removed!");
        }
        else
        {
            Console.WriteLine("Client not found!");
        }
    }

    // Method to display all clients
    public void DisplayClients()
    {
        if (_clients.Count == 0)
        {
            Console.WriteLine("No clients found.");
        }
        else
        {
            foreach (var client in _clients)
            {
                Console.WriteLine(client.ToString());
            }
        }
    }
}
