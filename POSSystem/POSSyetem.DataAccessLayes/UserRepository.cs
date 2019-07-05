using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace POSSystem.DataAccessLayer
{
    public class UserRepository
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        
        public int ValidateUser(string emailid,string password)
        {
            int retvalue;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CodinovaDBContext"].ToString());
            cmd = new SqlCommand(@"Select [dbo].ufn_ValidateUser(@EmailId,@Password)", con);
            cmd.Parameters.AddWithValue("@EmailId", emailid);
            cmd.Parameters.AddWithValue("@Password", password);
            try
            {
                con.Open();
                retvalue = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                retvalue = -1;
            }
            finally
            {
                con.Close();
            }
            return retvalue;

        } 


    }
}
