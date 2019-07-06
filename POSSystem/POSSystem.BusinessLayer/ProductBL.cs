using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSSystem.DataAccessLayer;
using POSSystem.Common;

namespace POSSystem.BusinessLayer
{
    public class ProductBL
    {
        ProductRepository prodrepo = new ProductRepository(); 
        public List<Product> GetAllProducts()
        {
            List<Product> prodlist = new List<Product>();
            try
            {
                prodlist = prodrepo.GetAllProducts();
            }
            catch
            {
                prodlist = null;
            }
            return prodlist;
        }
    }
}
