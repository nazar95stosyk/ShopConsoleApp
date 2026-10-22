namespace ConsoleApp1.Services;
using ConsoleApp1.Models;

public class OrderItemService
{
    public List<OrderItem> OrderItems { get; set; } = new();

    public void Load(string filePath, DataReader reader, JsonParser parser)
    {
        var json = reader.Read(filePath);
        OrderItems = parser.Parse<List<OrderItem>>(json) ?? new List<OrderItem>();
    }

    public List<OrderItem> GetAll()
    {
        return OrderItems;
    }
}