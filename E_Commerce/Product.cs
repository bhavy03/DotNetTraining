using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual List<OrderProductMapping> OrderProductMappings { get; set; }
        public int CategoriesId { get; set; }
        public virtual Categories Categories { get; set; }
    }

}
