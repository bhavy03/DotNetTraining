using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class ProductManager
    {
        ECommerceContext context = new ECommerceContext();
        public Product AddProductInfo()
        {
            try
            {

                Console.WriteLine("Enter information about Product:");
                Console.WriteLine("Enter Product name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Product Price");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Category");
                string category = Console.ReadLine();
                category = category.Trim().ToUpper();

                var fetchedCategory = context.Categories.FirstOrDefault(c => c.CategoryName == category);
                if (fetchedCategory == null)
                {
                    fetchedCategory = new Categories()
                    {
                        CategoryName = category,
                    };
                    context.Categories.Add(fetchedCategory);
                    context.SaveChanges();
                }
                var product = new Product
                {
                    Name = name,
                    Price = price,
                    CategoriesId = fetchedCategory.CategoriesId
                };
                context.Products.Add(product);
                context.SaveChanges();
                return product;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string MostPopularProduct()
        {
            var mostPopular = context.OrderProductMappings.GroupBy(gp => gp.ProductId).Select(g => new
            {
                productId = g.Key,
                TotalOrdered = g.Sum(x => x.Quantity),
                productName = g.FirstOrDefault().Product.Name,
            }).OrderByDescending(x => x.TotalOrdered).FirstOrDefault();

            return mostPopular.productName;
        }

        //public void UpdateProductPrice()
        //{
        //    Console.WriteLine("Enter the Product ID to update the price:");
        //    int prodId = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter the new price:");
        //    decimal newPrice = decimal.Parse(Console.ReadLine());

        //    using (var transaction = context.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            var productToUpdate = context.Products.FirstOrDefault(p => p.ProductId == prodId1);
        //            if (productToUpdate == null)
        //            {
        //                Console.WriteLine("Product not found.");
        //                return;
        //            }

        //            productToUpdate.Price = newPrice;
        //            context.SaveChanges();
        //            transaction.Commit();
        //            Console.WriteLine("Product price updated successfully.");
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            Console.WriteLine($"Error: {ex.Message}");
        //        }
        //    }
        //}
    }
}
