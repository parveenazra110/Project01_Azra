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
        //ProductRepository prodrepo = new ProductRepository(); -- uncomment this line to create object of Project repository
        

        EntityProductRepository entityprodrepo = new EntityProductRepository();
        public List<POSSystem.Common.Product> GetAllProducts()
        {
            List<POSSystem.Common.Product> prodlist = new List<POSSystem.Common.Product>();
            try
            { 
                //prodlist= prodrepo.GetAllProducts(); ---uncomment this line to call GetAllProducs Method of Product Repository in POSSystem.DataAccessLayer.
                prodlist = entityprodrepo.GetAllProducts();
            }
            catch
            {
                prodlist = null;
            }
            return prodlist;
        }

        public int InsertSaleDetails(double? totalSaleAmount, string emailId, out int saleid)
        {

            int retvalue = 0;

            try
            {
                retvalue=entityprodrepo.InsertSaleDetails(totalSaleAmount, emailId, out saleid);
            }
            catch (Exception ex)
            {
                retvalue = -99;
                saleid = 0;
            }
            return retvalue;


        }
    }
}
