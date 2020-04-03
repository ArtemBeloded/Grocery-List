using GroceryList.DAL.Models;
using System;
using System.Collections.Generic;
using System.Web;

namespace GroceryList.BLL.Services
{
    public interface IProductService
    {
        Product GetProduct(Guid id);
        IEnumerable<Product> GetProducts();
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Guid id);
    }
}
