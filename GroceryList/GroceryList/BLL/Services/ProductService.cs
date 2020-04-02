using GroceryList.DAL.Models;
using GroceryList.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryList.BLL.Services
{
    public class ProductService 
    {
        private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public bool AddProduct(Product product, HttpContextBase httpContext)
        {
            return _productRepository.AddProduct(product, httpContext);
        }

        public bool DeleteProduct(int id, HttpContextBase httpContext)
        {
            return _productRepository.DeleteProduct(id, httpContext);
        }

        public Product GetProduct(int id, HttpContextBase httpContext)
        {
            return _productRepository.GetProduct(id, httpContext);
        }

        public List<Product> GetProducts(HttpContextBase httpContext)
        {
            return _productRepository.GetProducts(httpContext);
        }

        public bool UpdateProduct(Product product, HttpContextBase httpContext)
        {
            return _productRepository.UpdateProduct(product, httpContext);
        }
    }
}