using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList.DAL.Models
{
    public class ProductsBasket
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
