using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BizfitechChallenge.DAL
{
    public class ViewProfileDAL
    {
        public static string MyConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public static DataTable SearchUser(string FirstName, string Surname)
        {
            using (SqlConnection conn = new SqlConnection(MyConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = FirstName;
                    cmd.Parameters.Add("@Surname", SqlDbType.VarChar, 100).Value = Surname;

                    conn.Open();
                    DataTable result = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(result);
                    conn.Close();
                    da.Dispose();

                    return result;
                }
            }
        }

        public static DataTable ViewUser(int ID)
        {
            using (SqlConnection conn = new SqlConnection(MyConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ViewUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = ID;

                    conn.Open();
                    DataTable result = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(result);
                    conn.Close();
                    da.Dispose();

                    return result;
                }
            }
        }
    }
}