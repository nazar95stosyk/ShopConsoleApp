namespace ConsoleApp1.Models;

public class Product
{
    public decimal Price { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int Id { get; set; }
    public string StockDescription { get; set; }
    public int CategoryId { get; set; }
}