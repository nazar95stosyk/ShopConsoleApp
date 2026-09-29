using ConsoleApp1.Models;

namespace ConsoleApp1.DataContainers;

public class ShopData
{
    public List<Product> Products { get; set; } = new();
    public List<Customer> Customers { get; set; } = new();
    public List<Category> Categories { get; set; } = new();
    public List<Order> Orders { get; set; } = new();
}