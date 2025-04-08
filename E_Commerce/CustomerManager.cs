using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    internal class CustomerManager
    {
        ECommerceContext context = new ECommerceContext();
        public Customer AddCustomerInfo()
        {
            try
            {
                Console.WriteLine("Enter information about Customer");
                Console.WriteLine("Enter Customer name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Customer Address");
                string location = Console.ReadLine();
                var customer = new Customer()
                {
                    CustomerName = name,
                    Location = location
                };

                context.Customers.Add(customer);
                context.SaveChanges();
                return customer;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public String CustomerWithMostOrders()
        {
            var customer = context.Orders.GroupBy(c => c.CustomerId).Select(c => new
            {
                customerId = c.Key,
                totalOrders = c.Count(),
                customerName = c.FirstOrDefault().Customer.CustomerName,
            }).OrderByDescending(cus => cus.customerId).FirstOrDefault();
            return customer.customerName;
        }

    }
}
