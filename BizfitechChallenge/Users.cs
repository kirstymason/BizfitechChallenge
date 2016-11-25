using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BizfitechChallenge
{
    public class Users
    {
        int _iId;
        string _strFirstName;
        string _strSurname;
        string _strEmail;
        string _strBio;
        string _strTwitterRef;
        //  List<int> _listLanguages = new List<int>();

        public Users() { }

        public Users(DataRow drUsers)
        {
            this._iId = Convert.ToInt32(drUsers["ID"]);
            this._strFirstName = drUsers["FirstName"].ToString();
            this._strSurname = drUsers["Surname"].ToString();
            this._strEmail = drUsers["Email"].ToString();
            this._strBio = drUsers["Bio"].ToString();
            this._strTwitterRef = drUsers["TwitterRef"].ToString();
          //  this._listLanguages = CMInternal.BLL.BLLManageUsers.GetUserRole(Convert.ToInt32(drUsers["ID"]));
        }

        public int GetID()
        {
            return _iId;
        }

        public string GetFirstName()
        {
            return _strFirstName;
        }

        public string GetSurname()
        {
            return _strSurname;
        }

        public string GetEmail()
        {
            return _strEmail;
        }

        public string GetBio()
        {
            return _strBio;
        }

        public string GetTwitterRef()
        {
            return _strTwitterRef;
        }
    }
}