using System.Collections.Generic;

namespace EcommerceSearch
{
    public class SearchService
    {
        public static Product LinearSearch(List<Product> products, string name)
        {
            foreach (var product in products)
            {
                if (product.ProductName.ToLower() == name.ToLower())
                {
                    return product;
                }
            }
            return null;
        }
    }
}