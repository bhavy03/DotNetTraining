using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Week4_5
{
    internal static class Ques4
    {
        public static void thresholdGreater()
        {
            List<Customer> customers = new List<Customer>{
            new Customer
            {
                CustomerID = 1, Name = "Alice",
                Orders = new List<Order>
                {
                    new Order { OrderID = 101, TotalValue = 500 },
                    new Order { OrderID = 102, TotalValue = 1500 }
                }
            },
            new Customer
            {
                CustomerID = 2, Name = "Bob",
                Orders = new List<Order>
                {
                    new Order { OrderID = 103, TotalValue = 200 },
                    new Order { OrderID = 104, TotalValue = 800 }
                }
            },
            new Customer
            {
                CustomerID = 3, Name = "Charlie",
                Orders = new List<Order>
                {
                    new Order { OrderID = 105, TotalValue = 3000 }
                }
            }
            };

            Console.WriteLine("Enter the threshold value: ");
            int thresholdValue = Convert.ToInt32(Console.ReadLine());

            var orders = customers.SelectMany(customer => customer.Orders, (customer, orderTotal) => new
            {
                customerName = customer.Name,
                orderId = orderTotal.OrderID,
                totalValue = orderTotal.TotalValue
            }).Where(order => order.totalValue >= thresholdValue).ToList();

            Console.WriteLine($"Customers with orders greater than {thresholdValue}:");
            foreach (var order in orders)
            {
                Console.WriteLine($"Customer:- {order.customerName}, OrderId:- {order.orderId}, TotalValue:- {order.totalValue}");
            }
        }
    }

    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }

    class Order
    {
        public int OrderID { get; set; }
        public double TotalValue { get; set; }
        public int CustomerID { get; set; }
    }
}
