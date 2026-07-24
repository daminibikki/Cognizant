using System;
using System.Collections.Generic;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product(1, "Laptop"),
                new Product(2, "Mobile"),
                new Product(3, "Keyboard"),
                new Product(4, "Mouse")
            };

            string searchItem = "Keyboard";

            Product result = SearchService.LinearSearch(products, searchItem);

            if (result != null)
                Console.WriteLine($"Product Found: {result.ProductName}");
            else
                Console.WriteLine("Product Not Found");
        }
    }
}