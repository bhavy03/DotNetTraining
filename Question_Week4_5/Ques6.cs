using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Week4_5
{
    internal static class Ques6
    {
        public static void joining()
        {
            List<Customer> customers = new List<Customer>
            {
            new Customer { CustomerID = 1, Name = "Alice" },
            new Customer { CustomerID = 2, Name = "Bob" },
            new Customer { CustomerID = 3, Name = "Charlie" }
            };

            List<Order> orders = new List<Order>
            {
            new Order { OrderID = 101, CustomerID = 1, TotalValue = 250.50 },
            new Order { OrderID = 102, CustomerID = 2, TotalValue = 150.75 },
            new Order { OrderID = 103, CustomerID = 1, TotalValue = 99.99 },
            new Order { OrderID = 104, CustomerID = 3, TotalValue = 500.00 }
            };

            var joinedList = customers.Join(orders,
                customer => customer.CustomerID,
                order => order.CustomerID,
                (customer, order) => new
                {
                    CustomerName = customer.Name,
                    orderId = order.OrderID,
                    OrderTotal = order.TotalValue
                }).ToList();

            Console.WriteLine("Customer Orders:");
            foreach (var item in joinedList)
            {
                Console.WriteLine($"CustomerName:- {item.CustomerName}, OrderId:- {item.orderId}, OrderTotal:- {item.OrderTotal}");
            }
        }
    }
}
