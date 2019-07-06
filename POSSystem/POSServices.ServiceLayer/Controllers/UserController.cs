using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using POSSystem.Common;
using POSSystem.ServiceLayer.Models;
using POSSystem.BusinessLayer;




namespace POSSystem.ServiceLayer.Controllers
{
    public class UserController : ApiController
    {
        UserBL userbl = new UserBL();

        [HttpGet]
        public string ValidateUser(string emailid,string password)
        {
            int retvalue;
            string result = "";
            try
            {
                retvalue = userbl.ValidateUser(emailid, password);
                if (retvalue > 0)
                {
                    result = "Login Successful";
                }
                else
                {
                    result = "Login Failed";
                }

            }
            catch
            {
                result = "Login Failed";
            }
            return result;
        }
   
    
    }
}
