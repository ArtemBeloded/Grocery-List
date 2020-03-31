using GroceryList.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GroceryList.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductsBasket _productBasket;
        private readonly HttpContext _httpContext;
        public ProductRepository(HttpContext httpContext)
        {
            _httpContext = httpContext;
            InitSession();
            _productBasket.Products.AddRange(new List<Product>() {
                new Product(){Id = 0, Name = "Oil", Quantity = 2, units = Units.liter },
                new Product(){Id = 1, Name = "Pasta", Quantity = 3, units = Units.pieces },
                new Product(){Id = 2, Name = "Sugar", Quantity = 5, units = Units.kilo },
                new Product(){Id = 3, Name = "Water", Quantity = 500, units = Units.milliliter }
            });
        }

        public bool AddProduct(Product product)
        {
            InitSession();
            _productBasket.Products.Add(product);
            return true;
        }

        public bool DeleteProduct(int id)
        {
            InitSession();
            var product = _productBasket.Products.FirstOrDefault(x => x.Id == id);
            _productBasket.Products.Remove(product);
            return true;
        }

        public Product GetProduct(int id)
        {
            InitSession();
            var product = _productBasket.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public List<Product> GetProducts()
        {
            InitSession();
            var products = _productBasket.Products;
            return products;
        }

        public bool UpdateProduct(Product product)
        {
            InitSession();
            var productForDelete = _productBasket.Products.FirstOrDefault(x => x.Id == product.Id);
            _productBasket.Products.Remove(productForDelete);
            _productBasket.Products.Add(product);
            return true;
        }

        private void InitSession()
        {
            InitSession();
            _productBasket = _httpContext.Session["Products"] as ProductsBasket;
            if (_productBasket == null)
            {
                _httpContext.Session["Products"] = new ProductsBasket();
                _productBasket = _httpContext.Session["Products"] as ProductsBasket;
            }
        }
    }
}
