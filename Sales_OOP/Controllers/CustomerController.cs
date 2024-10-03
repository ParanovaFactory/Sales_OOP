using Microsoft.AspNetCore.Mvc;
using Sales_OOP.Entity;
using Sales_OOP.ProjectContext;
using System.Linq;

namespace Sales_OOP.Controllers
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
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if (customer.CustomerName.Length >=3 && customer.CustomerCity != "" && customer.CustomerCity.Length <= 14)
            {
                context.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Enter the non defined parameters";
                return View();
            }
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.CustomerId ==  id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            context.Update(customer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
