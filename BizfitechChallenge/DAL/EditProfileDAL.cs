using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CMInternal;

namespace BizfitechChallenge.DAL
{
    public class EditProfileDAL
    {
        public static string MyConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public static Users GetFullUserDetails(int ID)
        {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", ID);

            Users userForEdit = new Users();

            DataSet results = SqlHelper.ExecuteDataset(MyConnectionString, "sp_GetUser", param);

            if (results.Tables.Count > 0 && results.Tables[0].Rows.Count > 0)
            {
                userForEdit = new Users(results.Tables[0].Rows[0]);
            }
            return userForEdit;
        }


        public static int EditUser(int ID, string FirstName, string Surname, string Email, string Bio, string TwitterRef)
        {
            using (SqlConnection conn = new SqlConnection(MyConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_EditUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
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