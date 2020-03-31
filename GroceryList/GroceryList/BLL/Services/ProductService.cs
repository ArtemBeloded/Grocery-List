using GroceryList.DAL.Models;
using GroceryList.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryList.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(HttpContextBase httpContext)
        {
            _productRepository = new ProductRepository(httpContext);
        }
        public bool AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public Product GetProduct(int id)
        {
            return _productRepository.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public bool UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }
    }
}