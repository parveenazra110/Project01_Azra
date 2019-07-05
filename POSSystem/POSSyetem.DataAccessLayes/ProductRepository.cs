using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSSystem.Common;
using System.Data;

namespace POSSystem.DataAccessLayer
{
    public class ProductRepository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;


        public List<Product> GetAllProducts()
        {
            List<Product> prodlist = new List<Product>();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CodinovaDBContext"].ToString());
            cmd = new SqlCommand(@"Select *from [dbo].ufn_GetAllProducts()", con);
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);

            try
            {
                sda.Fill(dt);
                if (dt != null) {
                    foreach (DataRow row in dt.Rows)
                    {
                        Product prod = new Product
                        {
                            ProductId = Convert.ToString(row[0]),
                            ProductName = Convert.ToString(row[1]),
                            CategoryId =Convert.ToInt32(row[2]), 
                            Price=Convert.ToDecimal(row[3])
                        };
                        prodlist.Add(prod);
                    }
                }
            }
            catch
            {
                prodlist = null;
            }
            return prodlist;
        } 

        public int InsertSaleDetails(decimal totalSaleAmount,string emailId,out string saleid)
        {
            
            int retval;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CodinovaDBContext"].ToString());
            cmd = new SqlCommand("usp_InsertSaleDetails", con);
            cmd.Parameters.AddWithValue("@EmailId", emailId);
            cmd.Parameters.AddWithValue("@TotalSaleAmount", totalSaleAmount);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prmretval = new SqlParameter();
            prmretval.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(prmretval);

            SqlParameter prmsaleid = new SqlParameter("@saleid",SqlDbType.VarChar);
            prmsaleid.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmsaleid);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                retval = Convert.ToInt32(prmretval.Value);
                saleid = Convert.ToString(prmsaleid.Value);

            }
            catch
            {
                retval = -99;
                saleid = "empty";
            }
            return retval;
        }
    }
}
