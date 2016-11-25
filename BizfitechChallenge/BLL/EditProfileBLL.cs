using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BizfitechChallenge.BLL
{
    public class EditProfileBLL
    {

        public static Users GetFullUserDetails(int ID)
        {
            return BizfitechChallenge.DAL.EditProfileDAL.GetFullUserDetails(ID);
        }

        public static string EditUser(int ID, string FirstName, string Surname, string Email, string Bio, string TwitterRef)
        {

            int result = BizfitechChallenge.DAL.EditProfileDAL.EditUser(ID, FirstName, Surname, Email, Bio, TwitterRef);

            if (result == 0)
                //Not created.
                return "There was an unknown error; the user account was NOT edited.";
            else
                //Created.
                return "The user account was successfully edited!";

        }
    }
}