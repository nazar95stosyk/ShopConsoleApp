using ConsoleApp1.Models;
namespace ConsoleApp1.Services;

public class CategoryService
{
    public List<Category> Categories { get; set; } = new();

    public void Load(string filePath, DataReader reader, JsonParser parser)
    {
        var json = reader.Read(filePath);
        Categories = parser.Parse<List<Category>>(json) ?? new List<Category>();
    }

    public List<Category> GetAll()
    {
        return Categories;
    }
}