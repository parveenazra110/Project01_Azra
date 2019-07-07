using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using POSSystem.BusinessLayer;
using POSSystem.ServiceLayer.Models;
using POSSystem.Common;

namespace POSServices.ServiceLayer.Controllers
{
    public class ProductController : ApiController
    {
        ProductBL prodbl = new ProductBL();
        [HttpGet]
        public List<Products> GetAllProducts()
        {
            List<Product> commonprod = new List<Product>();
            List<Products> serviceprodlist = new List<Products>();
            commonprod = prodbl.GetAllProducts(); 

            foreach(Product prod in commonprod)
            {
                Products serviceprod = new Products
                {
                    ProductId = prod.ProductId,
                    ProductName = prod.ProductName,
                    CategoryId = prod.CategoryId,
                    Price = prod.Price
                };
                serviceprodlist.Add(serviceprod);

            }

            return serviceprodlist;
        } 

        [HttpPost] 
        public int InsertSaleDetails(double? totalSaleAmount, string emailId, out int saleid)
        {
            int retvalue = 0;

            try
            {
                retvalue = prodbl.InsertSaleDetails(totalSaleAmount, emailId, out saleid);
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
