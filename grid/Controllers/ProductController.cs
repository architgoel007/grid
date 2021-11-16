using grid.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grid.Controllers
{
    public class ProductController : Controller
    {
        public ProductController(ApplicationContext context)
        {
            Context = context;
        }

        public ApplicationContext Context { get; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        public IActionResult SubCategory()
        {
            return View();
        }

        public IActionResult GetProducts()
        {
            var products = Context.Products.ToList();
            return Json(products);
        }

        public IActionResult CreateProducts(Product product)
        {
            Context.Products.ToList();
            Context.SaveChanges();
            return Json(product);
        }


    }
}
