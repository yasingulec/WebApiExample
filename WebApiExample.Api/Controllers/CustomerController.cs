using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiExample.BLL;
using WebApiExample.Entities;

namespace WebApiExample.Api.Controllers
{
    public class CustomerController:ApiController
    {
        CustomerManager customerManager = new CustomerManager();
        public List<Customer> GetCustomers()
        {
            return customerManager.GetCustomers();
        }
        [HttpPost]
        public void AddCustomer(Customer customer)
        {
            //customer.CustomerID = 10;
            //customer.CustomerID = customer.CustomerID + 1;
            customerManager.AddCustomer(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            customerManager.UpdateCustomer(customer);
        }
    }
}