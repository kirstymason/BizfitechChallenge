using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BizfitechChallenge.DAL
{
    public class CreateProfileDAL
    {
        public static string MyConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public static int CreateNewUser(string FirstName, string Surname, string Email, string Bio, string TwitterRef)
        {
            using (SqlConnection conn = new SqlConnection(MyConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CreateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = FirstName;
                    cmd.Parameters.Add("@Surname", SqlDbType.VarChar, 100).Value = Surname;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = Email;
                    cmd.Parameters.Add("@Bio", SqlDbType.NVarChar, 500).Value = Bio;
                    cmd.Parameters.Add("@TwitterRef", SqlDbType.NVarChar, 100).Value = TwitterRef;

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();

                    conn.Close();

                    return result;

                }
            }

        }

    }
}