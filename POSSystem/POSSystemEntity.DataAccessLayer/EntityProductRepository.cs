using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSSystem;

namespace POSSystemEntity.DataAccessLayer
{
    public class EntityProductRepository
    {
        CodinovaDBContext context; 

        public List<POSSystem.Common.Product> GetAllProducts()
        {
            context = new CodinovaDBContext();
            List<POSSystem.Common.Product> commonprodlist = new List<POSSystem.Common.Product>();
            
            List<Product> prodlist;
            prodlist = (from p in context.Products select p).ToList<Product>();
            foreach (Product prod in prodlist)
            {
                POSSystem.Common.Product p1 = new POSSystem.Common.Product()
                {
                    ProductId = prod.ProductId,
                    ProductName = prod.ProductName,
                    Price = prod.Price,
                    CategoryId = prod.CategoryId
                };
                commonprodlist.Add(p1);
            }

            return commonprodlist;
        }
    }
}
