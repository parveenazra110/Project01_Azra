using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystemEntity.DataAccessLayer
{
    public class EntityUserRepository
    {
        CodinovaDBContext context; 
        public int ValidateUser(string emailid,string password)
        {
            context = new CodinovaDBContext();
            int result = context.Database.SqlQuery<int>("Select [dbo].ufn_ValidateUser(@EmailId,@Password)", new SqlParameter("@EmailId", emailid), new SqlParameter("@Password", password)).First();
            return result;
        }

    }
}
