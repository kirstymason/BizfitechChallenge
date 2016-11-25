using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BizfitechChallenge.BLL
{
    public class CreateProfileBLL
    {
        public static string CreateNewUser(string FirstName, string Surname, string Email, string Bio, string TwitterRef)
        {

            int result = BizfitechChallenge.DAL.CreateProfileDAL.CreateNewUser(FirstName, Surname, Email, Bio, TwitterRef);

            if (result == 0)
                //Not created.
                return "There was an unknown error; the user account was NOT created.";
            else
            //Created.
                return "The user account was successfully created!";

        }
    }
}