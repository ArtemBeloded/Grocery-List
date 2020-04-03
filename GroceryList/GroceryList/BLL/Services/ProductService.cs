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
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public bool DeleteProduct(Guid id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public Product GetProduct(Guid id)
        {
            return _productRepository.GetProduct(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public bool UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }
    }
}