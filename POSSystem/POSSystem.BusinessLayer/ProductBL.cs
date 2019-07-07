using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSSystem.DataAccessLayer;
using POSSystem.Common;
using POSSystemEntity.DataAccessLayer;

namespace POSSystem.BusinessLayer
{
    public class ProductBL
    {
        ProductRepository prodrepo = new ProductRepository();

        EntityProductRepository entityprodrepo = new EntityProductRepository();
        public List<POSSystem.Common.Product> GetAllProducts()
        {
            List<POSSystem.Common.Product> prodlist = new List<POSSystem.Common.Product>();
            try
            {
                prodlist = entityprodrepo.GetAllProducts();
            }
            catch
            {
                prodlist = null;
            }
            return prodlist;
        }
    }
}
