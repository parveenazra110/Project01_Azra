using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSSystem.DataAccessLayer;
using POSSystem.Common;


namespace POSSyetem.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userrepo = new UserRepository();
            ProductRepository prodrepo = new ProductRepository();

            //int result = userrepo.ValidateUser("Albert@gl.com", "Albert@1234");
            //Console.WriteLine(result);
            //if(result==1 || result == 2)
            //{
            //    Console.WriteLine("Login Sucessful");
            //}
            //else
            //{
            //    Console.WriteLine("Login Failed");
            //}

            //List<Product> prodlist = new List<Product>();
            //prodlist = prodrepo.GetAllProducts();

            //foreach(Product row in prodlist)
            //{
            //    Console.WriteLine("ProductId :"+row.ProductId);
            //    Console.WriteLine("ProductName :"+row.ProductName);
            //    Console.WriteLine("CategoryId :"+row.CategoryId);
            //    Console.WriteLine("Price :"+row.Price);
            //    Console.WriteLine();
            //}

            int saleid;
            int retval=prodrepo.InsertSaleDetails(857, "Diego@gml.com", out saleid);
            Console.WriteLine(saleid);

        }
    }
}
