using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiExample.DAL;
using WebApiExample.Entities;

namespace WebApiExample.BLL
{
  public class CustomerManager
    {
        DataContext dc = new DataContext();
        public Customer GetCustomer(int id)
        {
            return dc.Customer.FirstOrDefault(c => c.CustomerID == id);
        }
        public List<Customer> GetCustomers()
        {
            return dc.Customer.ToList();
        }
        public void AddCustomer(Customer customer)
        {
            dc.Customer.Add(customer);
            dc.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            Customer cus = dc.Customer.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            cus.FirstName = customer.FirstName;
            cus.LastName = customer.LastName;
            cus.Age = customer.Age;
            cus.Email = customer.Email;
            cus.PhoneNumber = customer.PhoneNumber;
            dc.SaveChanges();
        }
    }
}
