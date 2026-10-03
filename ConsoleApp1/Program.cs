// See https://aka.ms/new-console-template for more information
//asfsfs

using ConsoleApp1.Models;

var product = new Product()
{
    Id = 1,
    Name = "Samsung",
    Price = 28000,
    StockQuantity  = 1,
    Description = "Холодильник Самсунг",
    CategoryId = 1
};

var customer = new Customer()
{
    Id = 1,
    FirstName = "Nazar",
    LastName = "Stosyk",
    Email = "fantombeowulf@gmail.com",
    Phone = "0935053404"
};

var category = new Category()
{
    Id = 1,
    Name = "Холодильники",
    Description = "Холодильник для кухні"
};
var order = new Order()
{
    Id = 1,
    CustomerId = 1,
    CreatedAt = DateTime.Now,
    Status = "Sold",
    TotalAmount = 34000
};

var orderItem = new OrderItem()
{
    Id = 1,
    OrderId = 1,
    ProductId = 1,
    Quantity = 2,
    UnitPrice = 28000
};
List<Product> products = new List<Product>(); // created list of products

products.Add(product);// додали 1 продукт в список продуктів, перед тим ствоили його через змінну продукт
products.Add(new Product()
{
    Id = 2,
    Name = "BOSCH",
    Price = 25000,
    StockQuantity  = 3,
    Description = "Холодильник BOSCH",
    CategoryId = 1
});// добавили ще один продукт в список продуктів відразу, не створювали спочатку через var
products.Add(new Product()
{
    Id = 4,
    Name = "SIEMENS",
    Price = 19000,
    StockQuantity  = 1,
    Description = "пральна машина SIEMENS",
    CategoryId = 2
});
var product3 = new Product()
{
    Id = 3,
    Name = "AEG",
    Price = 20000,
    StockQuantity = 3,
    Description = "пральна машина АЕГ",
    CategoryId = 2
};
products.Add(product3);//спочатку створили продукт, а потім додали у список

Console.WriteLine(products.Count);// вивели на консоль кількість продуктів у списку
products[0].Price=30000;//переписали першому товару ціну
products[0].Name = "Samsung Updated"; //переіменували перший товар
Console.WriteLine(products[0].Price);//вивели на консоль змінену ціну 1 товару

products.RemoveAt(0);//видалили перший товар із списку
Console.WriteLine(products.Count);