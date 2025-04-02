using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Week4_5
{
    internal static class Ques5
    {
        public static void expensive()
        {
            List<Products> products = new List<Products>
            {
            new Products { ProductID = 1, Name = "Laptop", Price = 1200 },
            new Products { ProductID = 2, Name = "Smartphone", Price = 800 },
            new Products { ProductID = 3, Name = "Headphones", Price = 150 },
            new Products { ProductID = 4, Name = "Monitor", Price = 300 },
            new Products { ProductID = 5, Name = "Gaming Console", Price = 600 },
            new Products { ProductID = 6, Name = "Smartwatch", Price = 200 }
            };

            var topExpensiveProducts = products.OrderByDescending(product => product.Price).Take(3).ToList();

            Console.WriteLine("Top three Expensive items are: ");
            foreach (var product in topExpensiveProducts)
            {
                Console.WriteLine($"Product Name:- {product.Name} Price:- {product.Price}");
            }
        }
    }

    class Products
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
