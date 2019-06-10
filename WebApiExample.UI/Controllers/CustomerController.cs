using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiExample.BLL;
using WebApiExample.Entities;

namespace WebApiExample.UI.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager();
        // GET: Customer
        public ActionResult GetCustomers()
        {
            List<Customer> customers = customerManager.GetCustomers();
            return View(customers);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            customerManager.AddCustomer(customer);
            return View();
        }
        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            Customer cus = customerManager.GetCustomer(id);
            return View(cus);
        }    
        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            customerManager.UpdateCustomer(customer);
            return RedirectToAction("GetCustomers");
        }
    }
}