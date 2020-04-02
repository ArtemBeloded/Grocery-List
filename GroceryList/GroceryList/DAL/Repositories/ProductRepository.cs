﻿using GroceryList.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GroceryList.DAL.Repositories
{
    public class ProductRepository 
    {
        private ProductsBasket _productBasket;
        //private readonly HttpContextBase _httpContext;
        public ProductRepository()
        {
            //_httpContext = httpContext;
            //InitSession();
        }

        public bool AddProduct(Product product, HttpContextBase httpContext)
        {
            InitSession(httpContext);
            _productBasket.Products.Add(product);
            return true;
        }

        public bool DeleteProduct(int id, HttpContextBase httpContext)
        {
            InitSession(httpContext);
            var product = _productBasket.Products.FirstOrDefault(x => x.Id == id);
            _productBasket.Products.Remove(product);
            return true;
        }

        public Product GetProduct(int id, HttpContextBase httpContext)
        {
            InitSession(httpContext);
            var product = _productBasket.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public List<Product> GetProducts(HttpContextBase httpContext)
        {
            InitSession(httpContext);
            var products = _productBasket.Products;
            return products;
        }

        public bool UpdateProduct(Product product, HttpContextBase httpContext)
        {
            InitSession(httpContext);
            var productForDelete = _productBasket.Products.FirstOrDefault(x => x.Id == product.Id);
            _productBasket.Products.Remove(productForDelete);
            _productBasket.Products.Add(product);
            return true;
        }

        private void InitSession(HttpContextBase httpContext)
        {
            _productBasket = httpContext.Session["Products"] as ProductsBasket;
            if (_productBasket == null)
            {
                httpContext.Session["Products"] = new ProductsBasket();
                _productBasket = httpContext.Session["Products"] as ProductsBasket;
                _productBasket.Products.AddRange(new List<Product>() {
                new Product(){Id = 0, Name = "Oil", Quantity = 2, units = Units.liter },
                new Product(){Id = 1, Name = "Pasta", Quantity = 3, units = Units.pieces },
                new Product(){Id = 2, Name = "Sugar", Quantity = 5, units = Units.kilo },
                new Product(){Id = 3, Name = "Water", Quantity = 500, units = Units.milliliter }
            });
            }
        }
    }
}
