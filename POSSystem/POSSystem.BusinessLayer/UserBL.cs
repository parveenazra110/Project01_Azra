using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSSystem.DataAccessLayer;

namespace POSSystem.BusinessLayer
{
    public class UserBL
    {
        UserRepository userrepo = new UserRepository(); 
        public int ValidateUser(string emailid,string password)
        {
            int retvalue;
            try
            {
                retvalue = userrepo.ValidateUser(emailid,password);
            }
            catch
            {
                retvalue = -1;
            }
            return retvalue;
        }
    }
}
