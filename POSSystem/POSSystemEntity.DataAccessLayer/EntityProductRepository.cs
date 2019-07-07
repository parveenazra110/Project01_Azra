using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
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

        public int InsertSaleDetails(double? totalSaleAmount, string emailId, out int saleid)
        {
            
            int retvalue=0;
            
            try
            {
                context = new CodinovaDBContext();
                var saleidparam = new ObjectParameter("SaleId", typeof(int));
                retvalue = context.usp_InsertSaleDetails(emailId, totalSaleAmount,saleidparam);
                saleid = Convert.ToInt32(saleidparam.Value);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                saleid = 0;
            }
            return retvalue;

          
        }
    }
}
