using ConsoleApp1.Models;

namespace ConsoleApp1.Services;

public class CustomerService
{
    public List<Customer> Customers { get; set; } = new();
    
    public void Load(string filePath, DataReader reader, JsonParser parser)
    {
        var json = reader.Read(filePath);
        Customers = parser.Parse<List<Customer>>(json) ?? new List<Customer>();
    }

    public List<Customer> GetAll()
    {
        return Customers;
    }
}