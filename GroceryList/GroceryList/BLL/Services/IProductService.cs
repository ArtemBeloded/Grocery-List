using GroceryList.DAL.Models;
using System.Collections.Generic;

namespace GroceryList.BLL.Services
{
    public interface IProductService
    {
        Product GetProduct(int id);
        List<Product> GetProducts();
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}
