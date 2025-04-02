using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Week4_5
{
    internal static class Ques3
    {
        public static void TotalQuantity()
        {
            List<Product> products = new List<Product>
            {
            new Product { Name = "Apple", Category = "Fruits", Quantity = 10 },
            new Product { Name = "Banana", Category = "Fruits", Quantity = 20 },
            new Product { Name = "Carrot", Category = "Vegetables", Quantity = 15 },
            new Product { Name = "Broccoli", Category = "Vegetables", Quantity = 8 },
            new Product { Name = "Chicken", Category = "Meat", Quantity = 5 },
            new Product { Name = "Beef", Category = "Meat", Quantity = 12 }
            };

            var groupedCatagory = products.GroupBy(product => product.Category).Select(group => new
            {
                catagory = group.Key,
                totalQuantity = group.Sum(product => product.Quantity)
            }
            ).ToList();

            Console.WriteLine("Total quantity of products per category:");
            foreach (var item in groupedCatagory)
            {
                Console.WriteLine($"Category: {item.catagory}\nTotal Quantity:- {item.totalQuantity}");
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
    }
}
