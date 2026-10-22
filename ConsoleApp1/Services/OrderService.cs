using ConsoleApp1.Models;
namespace ConsoleApp1.Services;


public class OrderService
{
    public List<Order> Orders { get; set; } = new();

    public void Load(string filePath, DataReader reader, JsonParser parser)
    {
        var json = reader.Read(filePath);
        Orders = parser.Parse<List<Order>>(json) ?? new List<Order>();
    }

    public List<Order> GetAll()
    {
        return Orders;
    }
}