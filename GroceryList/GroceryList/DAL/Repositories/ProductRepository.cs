using GroceryList.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductsBasket _productBasket;
        public ProductRepository()
        {

        }

        public bool AddProduct(Product product)
        {
            
        }

        public bool DeleteProduct(int id)
        {
            
        }

        public Product GetProduct(int id)
        {
            
        }

        public List<Product> GetProducts()
        {
            
        }

        public bool UpdateProduct(Product product)
        {
            
        }

        private void InitSession() 
        {
            _productBasket = Session["Products"] as ProductsBasket;
            if (sessionData == null)
            {
                Session["Products"] = new SessionData();
                sessionData = Session["Products"] as SessionData;
            }
        }
    }
}
