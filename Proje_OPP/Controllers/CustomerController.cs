using Microsoft.AspNetCore.Mvc;
using Proje_OPP.Entitiy;
using Proje_OPP.ProjeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_OPP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomers()
        {

            return View();
        }



        [HttpPost]

        public IActionResult AddCustomers(Customer c)
        {

            if (c.CustomerName.Length >=5 && c.CustomerCity!="" && c.CustomerCity.Length<=3)
            {

                context.Add(c);
                context.SaveChanges();

                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.message = "Eksik parametere girdiniz";
                return View();

            }
         

        }

        public IActionResult DeleteCustomers(int id)
        {
            var values = context.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            context.Remove(values);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateCustomers(int id)
        {
            var value = context.Customers.Where(x => x.CustomerID == id).FirstOrDefault();

            return View(value);

        }

        [HttpPost]
        public IActionResult UpdateCustomers(Customer c)
        {
            var value = context.Customers.Where(x => x.CustomerID == c.CustomerID).FirstOrDefault();
            value.CustomerName = c.CustomerName;
            value.CustomerCity = c.CustomerCity;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    
    }
}
