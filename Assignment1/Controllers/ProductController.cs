using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Assignment1.Controllers
{
    public class ProductController : Controller
    {
       
        private ProductContext context { get; set; }
         

        public ProductController(ProductContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var products = context.Products.OrderBy(p => p.DateAdded);
            return View(products);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }



    }
}
