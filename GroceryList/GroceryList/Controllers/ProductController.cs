using GroceryList.BLL.Services;
using GroceryList.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroceryList.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public ActionResult ListOfProduct()
        {
            var products = _productService.GetProducts();
            return View(products);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        public ActionResult SaveNewProduct(Product product) 
        {
            product.Id = Guid.NewGuid();
           // product.DateOfCreate = DateTime.Now;
            _productService.AddProduct(product);
            return RedirectToAction("ListOfProduct");
        }

        public ActionResult DetailProduct(Guid id) 
        {
            var product = _productService.GetProduct(id);
            return View(product);
        }

        public ActionResult EditProduct(Guid id)
        {
            var product = _productService.GetProduct(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product) 
        {
            _productService.UpdateProduct(product);
            return RedirectToAction("ListOfProduct");
        }

        [HttpPost]
        public ActionResult DeleteProduct(Guid id) 
        {
            _productService.DeleteProduct(id);
            return RedirectToAction("ListOfProduct");
        }
    }
}