using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>
        {
            CreateOrder(
                "Mia Johnson", "123 George St", "Springfield", "IL", "USA",
                new List<Product>
                {
                    new Product("Yellow backpack", "YB123", 20.99, 2),
                    new Product("Yellow lunchbox", "YL4569", 9.99, 3)
                }
            ),
            CreateOrder(
                "Noah Lyons", "45 Birch Circle", "Vancouver", "BC", "Canada",
                new List<Product>
                {
                    new Product("Pull-out home organizer", "PO789", 54.20, 2),
                    new Product("Under sink storage organizer", "US321", 39.99, 5)
                }
            )
        };

        int i = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"Order {i++}:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }

    static Order CreateOrder(string customerName, string street, string city, string state, string country, List<Product> products)
    {
        Address address = new Address(street, city, state, country);
        Customer customer = new Customer(customerName, address);
        return new Order(customer, products);
    }
}

class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() => _name;
    public string GetProductID() => _productId;
    public double GetTotalCost() => _price * _quantity;
}

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA() => _country.Trim().ToUpper() == "USA";

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName() => _name;
    public Address GetAddress() => _address;
    public bool LivesInUSA() => _address.IsInUSA();
}

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        total += _customer.LivesInUSA() ? 5.0 : 35.0;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
