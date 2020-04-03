﻿using GroceryList.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryList.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductsBasket _productBasket;
        private readonly HttpContextBase _httpContext;
        private Random rnd;
        public ProductRepository(HttpContextBase httpContext)
        {
            rnd = new Random();
            _httpContext = httpContext;
            InitSession();
        }

        public bool AddProduct(Product product)
        {
            _productBasket.Products.Add(product);
            return true;
        }

        public bool DeleteProduct(Guid id)
        {
            var product = _productBasket.Products.FirstOrDefault(x => x.Id == id);
            _productBasket.Products.Remove(product);
            return true;
        }

        public Product GetProduct(Guid id)
        {
            var product = _productBasket.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _productBasket.Products;
            return products;
        }

        public bool UpdateProduct(Product product)
        {
            var count = _productBasket.Products.FindIndex(x => x.Id == product.Id);
            _productBasket.Products[count] = product;
            return true;
        }

        private void InitSession()
        {
            _productBasket = _httpContext.Session["Products"] as ProductsBasket;
            if (_productBasket == null)
            {
                _httpContext.Session["Products"] = new ProductsBasket();
                _productBasket = _httpContext.Session["Products"] as ProductsBasket;
                //    _productBasket.Products.AddRange(new List<Product>() {
                //    new Product(){Id = 0, Name = "Oil", Quantity = 2, units = Units.liter },
                //    new Product(){Id = 1, Name = "Pasta", Quantity = 3, units = Units.pieces },
                //    new Product(){Id = 2, Name = "Sugar", Quantity = 5, units = Units.kilo },
                //    new Product(){Id = 3, Name = "Water", Quantity = 500, units = Units.milliliter }
                //});
                for (int i = 1; i <= 15; i++)
                {
                    _productBasket.Products.Add(new Product()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Product" + i,
                        Quantity = rnd.Next(1, 1000),
                        units = (Units)Enum.GetValues(typeof(Units)).GetValue(rnd.Next(5)),
                        DateOfCreate = DateTime.Now
                    });
                }
            }
        }
    }
}

