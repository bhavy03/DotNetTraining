using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class OrderManager
    {
        ECommerceContext context = new ECommerceContext();
        public void AddOrderInfo()
        {
            try
            {
                Console.WriteLine("Enter CustomerID: ");
                int customerId = Convert.ToInt32(Console.ReadLine());
                var fetchedCustomers = context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
                if (fetchedCustomers == null)
                {
                    Console.WriteLine("No prior customer exists");
                    CustomerManager manager = new CustomerManager();
                    var customer = manager.AddCustomerInfo();
                    fetchedCustomers = customer;
                }

                List<OrderProductMapping> orders = new List<OrderProductMapping>();

                Console.WriteLine("Enter no of products you want to enter");
                int noP = Convert.ToInt32(Console.ReadLine());
                while (noP != 0)
                {
                    Console.WriteLine("Enter Product Id:");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    var fetchedProducts = context.Products.FirstOrDefault(p => p.ProductId == productId);
                    if (fetchedProducts == null)
                    {
                        Console.WriteLine("This Product doesn't exist. Would you like to try again? (Y/N)");
                        string choice = Console.ReadLine().Trim().ToUpper();
                        if (choice == "Y") continue;
                        else break;
                    }
                    else
                    {
                        Console.WriteLine("Enter the Quantity:");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        orders.Add(new OrderProductMapping()
                        {
                            ProductId = productId,
                            Quantity = quantity,
                        });
                    }
                    noP--;
                }

                if (orders.Count == 0)
                {
                    Console.WriteLine("No products added. Order cancelled.");
                    return;
                }

                var order = new Order()
                {
                    OrderDate = DateTime.UtcNow,
                    CustomerId = fetchedCustomers.CustomerId,
                    OrderProductMapping = orders
                };

                context.Orders.Add(order);
                context.SaveChanges();
                Console.WriteLine("Order placed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public decimal TotalSalesPeriod()
        {
            try
            {

                Console.WriteLine("Enter Start Date (yyyy-mm-dd):");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter End Date (yyyy-mm-dd):");
                DateTime endDate = DateTime.Parse(Console.ReadLine());

                var totalSalesPeriod = context.Orders.Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate).SelectMany(order => order.OrderProductMapping).Sum(pro => pro.Product.Price * pro.Quantity);

                return totalSalesPeriod;
            }
            catch (Exception)
            {
                //Console.WriteLine(ex.Message);
                return 0;
            }

        }

        public decimal TotalSales()
        {
            var totalSales = context.OrderProductMappings.Sum(total => total.Quantity * total.Product.Price);
            return totalSales;
        }

        public int TotalOrders()
        {
            var totalOrders = context.Orders.Count();
            return totalOrders;
        }
    }
}
