using GroceryList.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroceryList.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        public ProductController()
        {
            _productService = new ProductService(this.HttpContext);
        }
        // GET: Product
        public ActionResult ListOfProduct()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
    }
}