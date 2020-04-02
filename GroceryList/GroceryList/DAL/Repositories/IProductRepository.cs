using GroceryList.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList.DAL.Repositories
{
    public interface IProductRepository
    {
        Product GetProduct(Guid id);
        List<Product> GetProducts();
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Guid id);
    }
}
