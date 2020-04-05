using System.Collections.Generic;

namespace GroceryList.DAL.Models
{
    public class ProductsBasket
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
