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

