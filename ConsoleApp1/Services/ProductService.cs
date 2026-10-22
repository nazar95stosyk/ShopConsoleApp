using ConsoleApp1.Models;
namespace ConsoleApp1.Services;

public class ProductService
{
    public List<Product> Products { get; set; } = new();
    
    public void Load(string filePath, DataReader reader, JsonParser parser)
    {
        var json = reader.Read(filePath);
        Products = parser.Parse<List<Product>>(json) ?? new List<Product>();
    }

    public List<Product> GetAll()
    {
        return Products;
    }
}