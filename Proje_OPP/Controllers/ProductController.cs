using Microsoft.AspNetCore.Mvc;
using Proje_OPP.Entitiy;
using Proje_OPP.ProjeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_OPP.Controllers
{
    public class ProductController : Controller
    {

        Context context = new Context();
        public IActionResult Index()

            
        {
            var values = context.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();


            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var values = context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            context.Remove(values);
            context.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            return View(value);
        
        }
        [HttpPost]

        public IActionResult UpdateProduct(Product p)
        {

            var value = context.Products.Where(x => x.ProductId == p.ProductId).FirstOrDefault();
            value.ProductName = p.ProductName;
            value.Price = p.Price;
            value.Stock = p.Stock;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
