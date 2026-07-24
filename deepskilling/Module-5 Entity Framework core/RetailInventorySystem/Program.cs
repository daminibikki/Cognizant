using RetailInventorySystem.Data;

using var context = new RetailContext();

Console.WriteLine("Products with Price greater than 1000");

var products = context.Products
                      .Where(p => p.Price > 1000)
                      .OrderBy(p => p.Name)
                      .ToList();

foreach (var product in products)
{
    Console.WriteLine($"{product.ProductId} {product.Name} {product.Price}");
}