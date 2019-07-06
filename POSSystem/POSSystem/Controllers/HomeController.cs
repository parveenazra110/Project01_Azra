using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSSystem.BusinessLayer;
using POSSystem.ServiceLayer;

namespace POSSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        } 

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        } 

        public ActionResult ValidateUser(FormCollection frm)
        {
            UserBL userbl = new UserBL(); 
            
            string emailid = frm["EmailId"];
            string password = frm["Password"];
            int result = userbl.ValidateUser(emailid, password); 
            if(result==1 || result == 2)
            {
                return RedirectToAction("GetAllProducts","Product");
            }
            else
            {
                return View("Error");
            }
        }
    }
}