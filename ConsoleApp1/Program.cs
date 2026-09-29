// See https://aka.ms/new-console-template for more information
//asfsfs

using System.Text.Json;
using ConsoleApp1.DataContainers;
using ConsoleApp1.Models;
using System.Text.Json;

string filePath = "/Users/medina228/RiderProjects/ConsoleApp1/ConsoleApp1/DataSource/Data.json";

string json = File.ReadAllText(filePath);


var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

var shopData = JsonSerializer.Deserialize<ShopData>(json, options);

var products = shopData!.Products;
var customers = shopData.Customers;
var categories = shopData.Categories;
var orders = shopData.Orders;

Console.WriteLine($"Products: {products.Count}");
Console.WriteLine($"Customers: {customers.Count}");
Console.WriteLine($"Categories: {categories.Count}");
Console.WriteLine($"Orders: {orders.Count}");

// 1. Всі товари дорожчі за 20 000
var expensiveProducts = products
    .Where(p => p.Price > 20000);


// 2. Всі товари, яких немає на складі
var outOfStockProducts = products
    .Where(p => p.StockQuantity == 0);


// 3. Всі товари, яких на складі менше 5
var lowStockProducts = products
    .Where(p => p.StockQuantity < 5);


// 4. Всі товари Samsung
var samsungProducts = products
    .Where(p => p.Name.Contains("Samsung"));


// 5. Найдорожчий товар
var mostExpensiveProduct = products
    .OrderByDescending(p => p.Price)
    .First();


// 6. Найдешевший товар
var cheapestProduct = products
    .OrderBy(p => p.Price)
    .First();


// 7. Топ-3 найдорожчих товари
var topThreeExpensiveProducts = products
    .OrderByDescending(p => p.Price)
    .Take(3);


// 8. Товари від 10 000 до 25 000
var productsInPriceRange = products
    .Where(p => p.Price >= 10000 && p.Price <= 25000);


// 9. Середня ціна товарів
var averagePrice = products
    .Average(p => p.Price);


// 10. Загальна кількість товарів на складі
var totalStock = products
    .Sum(p => p.StockQuantity);


// 11. Скільки товарів коштують більше 20 000
var expensiveProductsCount = products
    .Count(p => p.Price > 20000);


// 12. Чи є хоча б один товар, якого немає на складі
var hasOutOfStockProducts = products
    .Any(p => p.StockQuantity == 0);


// 13. Чи всі товари мають ціну більше 1 000
var allProductsHaveValidPrice = products
    .All(p => p.Price > 1000);


// 14. Перший товар Samsung
var firstSamsungProduct = products
    .FirstOrDefault(p => p.Name.Contains("Samsung"));


// 15. Всі товари категорії "Пилососи" (CategoryId = 5)
var vacuumCleaners = products
    .Where(p => p.CategoryId == 5);


// 16. Назви всіх товарів
var productNames = products
    .Select(p => p.Name);


// 17. Назви товарів, які коштують більше 20 000
var expensiveProductNames = products
    .Where(p => p.Price > 20000)
    .Select(p => p.Name);


// 18. Ціни товарів Samsung
var samsungPrices = products
    .Where(p => p.Name.Contains("Samsung"))
    .Select(p => p.Price);


// 19. Товари відсортовані від найдешевшого до найдорожчого
var productsByPrice = products
    .OrderBy(p => p.Price);


// 20. Товари відсортовані від найдорожчого до найдешевшого
var productsByPriceDescending = products
    .OrderByDescending(p => p.Price);


// 21. Топ-3 найдорожчих Samsung
var topThreeSamsungProducts = products
    .Where(p => p.Name.Contains("Samsung"))
    .OrderByDescending(p => p.Price)
    .Take(3);


// 22. Назви товарів, яких немає на складі
var unavailableProductNames = products
    .Where(p => p.StockQuantity == 0)
    .Select(p => p.Name);


// 23. Загальна вартість всіх товарів на складі
var totalInventoryValue = products
    .Sum(p => p.Price * p.StockQuantity);


// 24. Найдорожчий товар, який є на складі
var mostExpensiveAvailableProduct = products
    .Where(p => p.StockQuantity > 0)
    .OrderByDescending(p => p.Price)
    .First();


// 25. Найдешевший товар, якого на складі більше 5
var cheapestProductWithGoodStock = products
    .Where(p => p.StockQuantity > 5)
    .OrderBy(p => p.Price)
    .First();


// 26. Скільки грошей зараз "лежить" на складі
var inventoryValue = products
    .Sum(p => p.Price * p.StockQuantity);


// 27. Середня ціна Samsung
var averageSamsungPrice = products
    .Where(p => p.Name.Contains("Samsung"))
    .Average(p => p.Price);


// 28. Кількість товарів кожної категорії
var productsByCategory = products
    .GroupBy(p => p.CategoryId);
    
    // ============================================
// PRIMARY KEY / FOREIGN KEY BASICS
// ============================================

// 1. Знайти категорію за її Primary Key (Id)
var category = categories
    .FirstOrDefault(c => c.Id == 1);


// 2. Знайти всі товари, які належать категорії з Id = 1
var productsInCategory = products
    .Where(p => p.CategoryId == 1);


// 3. Взяти CategoryId першого товару
var firstProduct = products.First();

var categoryId = firstProduct.CategoryId;


// 4. За Foreign Key товару знайти його категорію
var productCategory = categories
    .FirstOrDefault(c => c.Id == firstProduct.CategoryId);


// 5. Знайти товар за Primary Key
var product = products
    .FirstOrDefault(p => p.Id == 5);


// 6. Знайти всі замовлення конкретного Customer
var customerOrders = orders
    .Where(o => o.CustomerId == 1);


// 7. Знайти Customer за CustomerId із замовлення
var order = orders.First();

var customer = customers
    .FirstOrDefault(c => c.Id == order.CustomerId);


// 8. Перевірити, чи існує категорія для товару
var productExistsCategory = categories
    .Any(c => c.Id == product.CategoryId);


// 9. Перевірити, чи існує Customer для замовлення
var customerExists = customers
    .Any(c => c.Id == order.CustomerId);


// 10. Кількість товарів у конкретній категорії
var productsCountInCategory = products
    .Count(p => p.CategoryId == 1);


// 11. Кількість замовлень конкретного Customer
var customerOrdersCount = orders
    .Count(o => o.CustomerId == 1);


// 12. Знайти всі товари конкретного Customer через його замовлення
var customerId = 1;

var customerOrderIds = orders
    .Where(o => o.CustomerId == customerId)
    .Select(o => o.Id);


// 13. Перевірити, чи Customer має хоча б одне замовлення
var customerHasOrders = orders
    .Any(o => o.CustomerId == customerId);


// 14. Знайти категорію конкретного товару
var productId = 3;

var selectedProduct = products
    .FirstOrDefault(p => p.Id == productId);

var selectedCategory = categories
    .FirstOrDefault(c => c.Id == selectedProduct!.CategoryId);


// 15. Знайти всі товари категорії "Холодильники"
var refrigeratorsCategory = categories
    .FirstOrDefault(c => c.Name == "Холодильники");

var refrigerators = products
    .Where(p => p.CategoryId == refrigeratorsCategory!.Id);




// 17. Те саме через method syntax
var productsWithCategories2 = products
    .Join(
        categories,
        product => product.CategoryId,
        category => category.Id,
        (product, category) => new
        {
            ProductName = product.Name,
            Price = product.Price,
            CategoryName = category.Name
        });
