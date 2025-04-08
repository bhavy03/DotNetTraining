using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    public static class ECommerceManager
    {
        public static void AddInfo()
        {
            try
            {
                Console.WriteLine("Select the type of info you want to add");
                Console.WriteLine("1. Customer Info\n2. Product Info\n3. Order Info\n4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CustomerManager cManager = new CustomerManager();
                        var customer = cManager.AddCustomerInfo();
                        if (customer != null)
                        {
                            Console.WriteLine($"Customer {customer.CustomerName} Added Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Please provide valid information");
                        }
                        break;
                    case 2:
                        ProductManager pManager = new ProductManager();
                        var product = pManager.AddProductInfo();
                        if (product != null)
                        {
                            Console.WriteLine($"Product {product.Name} Added Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Enter valid information");
                        }
                        break;
                    case 3:
                        OrderManager oManager = new OrderManager();
                        oManager.AddOrderInfo();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Enter valid Choice");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }
        public static void RetrieveInfo()
        {
            try
            {
                Console.WriteLine("Select the info you want to retrieve");
                Console.WriteLine("1. Most Popular Product\n2. Customer with most Orders\n3. Total sales for a time period\n4. Total Sales\n5. Number of orders");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ProductManager pManager = new ProductManager();
                        string pName = pManager.MostPopularProduct();
                        Console.WriteLine($"Most Popular product is {pName}");
                        break;
                    case 2:
                        CustomerManager cManager = new CustomerManager();
                        string cName = cManager.CustomerWithMostOrders();
                        Console.WriteLine($"Customer with Most Orders is {cName}");
                        break;
                    case 3:
                        OrderManager oManager = new OrderManager();
                        decimal totalSalesPeriod = oManager.TotalSalesPeriod();
                        Console.WriteLine($"Total Sales in given time period is: {totalSalesPeriod}");
                        break;
                    case 4:
                        OrderManager orderManager = new OrderManager();
                        decimal totalSales = orderManager.TotalSales();
                        Console.WriteLine($"Total Sales all time is: {totalSales}");
                        break;
                    case 5:
                        OrderManager ordManager = new OrderManager();
                        int totalOrders = ordManager.TotalOrders();
                        Console.WriteLine($"Total orders are {totalOrders}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }
        public static void UpdateInfo()
        {
            try
            {
                Console.WriteLine("Select the Product info you want to update");
                Console.WriteLine("1. Product Price\n2. Product Catefory\n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ProductManager pManager = new ProductManager();
                        //pManager.UpdateInfo();
                        break;
                    case 2:
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter Valid choice");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        public static void DeleteInfo() { Console.WriteLine("Nothing to Delete"); }
    }
}
