using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSSystem.DataAccessLayer;
using POSSystem;
using POSSystem.BusinessLayer;
using POSSystemEntity.DataAccessLayer;




namespace POSSyetem.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userrepo = new UserRepository();
            ProductRepository prodrepo = new ProductRepository();
            ProductBL prodbl = new ProductBL();
            UserBL userbl = new UserBL();

            EntityUserRepository entityuserrepo = new EntityUserRepository();
            EntityProductRepository entityprodrepo = new EntityProductRepository();




            //int result = userbl.ValidateUser("Ann@gmail.com","Ann@1234");
            //Console.WriteLine(result);
            //if (result == 1 || result == 2)
            //{
            //    Console.WriteLine("Login Sucessful");
            //}
            //else
            //{
            //    Console.WriteLine("Login Failed");
            //}

            //List<Product> prodlist = new List<Product>();
            //prodlist = prodbl.GetAllProducts();

            //foreach (Product row in prodlist)
            //{
            //    Console.WriteLine("ProductId :" + row.ProductId);
            //    Console.WriteLine("ProductName :" + row.ProductName);
            //    Console.WriteLine("CategoryId :" + row.CategoryId);
            //    Console.WriteLine("Price :" + row.Price);
            //    Console.WriteLine();
            //}

            //int saleid;
            //int retval=prodrepo.InsertSaleDetails(857, "Diego@gml.com", out saleid);
            //Console.WriteLine(saleid); 


            //------------------------Entity -------------------------------------- 

            List<POSSystem.Common.Product> prodlist = new List<POSSystem.Common.Product>();
            prodlist = prodrepo.GetAllProducts();

            foreach (POSSystem.Common.Product row in prodlist)
            {
                Console.WriteLine("ProductId :" + row.ProductId);
                Console.WriteLine("ProductName :" + row.ProductName);
                Console.WriteLine("CategoryId :" + row.CategoryId);
                Console.WriteLine("Price :" + row.Price);
                Console.WriteLine();
            }

            //int result = entityuserrepo.ValidateUser("Annette@gmail.com","Annette@1234");
            //Console.WriteLine(result);
            //if (result == 1 || result == 2)
            //{
            //    Console.WriteLine("Login Sucessful");
            //}
            //else
            //{
            //    Console.WriteLine("Login Failed");
            //}

        }
    }
}
