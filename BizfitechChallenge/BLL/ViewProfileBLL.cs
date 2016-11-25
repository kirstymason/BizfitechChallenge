using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace BizfitechChallenge.BLL
{
    public class ViewProfileBLL
    {
        public static DataTable SearchUser(string FirstName, string Surname)
        {

            DataTable resultsToLoopThrough = BizfitechChallenge.DAL.ViewProfileDAL.SearchUser(FirstName, Surname);
            DataTable resultsToReturn = new DataTable();
            resultsToReturn.Columns.Add("ID");
            resultsToReturn.Columns.Add("FirstName");
            resultsToReturn.Columns.Add("Surname");
            resultsToReturn.Columns.Add("Email");

            foreach (DataRow row in resultsToLoopThrough.Rows)
            {
                DataRow newRow = resultsToReturn.NewRow();
                newRow["ID"] = row["ID"];
                newRow["FirstName"] = row["FirstName"];
                newRow["Surname"] = row["Surname"];
                newRow["Email"] = row["Email"];
                resultsToReturn.Rows.Add(newRow);
            }

            return resultsToReturn;
        }

        public static Users ViewUser(int ID)
        {

            DataTable resultsToLoopThrough = BizfitechChallenge.DAL.ViewProfileDAL.ViewUser(ID);
            DataTable resultsToReturn = new DataTable();
            resultsToReturn.Columns.Add("ID");
            resultsToReturn.Columns.Add("FirstName");
            resultsToReturn.Columns.Add("Surname");
            resultsToReturn.Columns.Add("Email");
            resultsToReturn.Columns.Add("Bio");
            resultsToReturn.Columns.Add("TwitterRef");

            foreach (DataRow row in resultsToLoopThrough.Rows)
            {
                DataRow newRow = resultsToReturn.NewRow();
                newRow["ID"] = row["ID"];
                newRow["FirstName"] = row["FirstName"];
                newRow["Surname"] = row["Surname"];
                newRow["Email"] = row["Email"];
                newRow["Bio"] = row["Bio"];
                newRow["TwitterRef"] = row["TwitterRef"];
                resultsToReturn.Rows.Add(newRow);
            }

            Users userToView = new Users();

            if (resultsToReturn.Rows.Count > 0)
            {
                userToView = new Users(resultsToReturn.Rows[0]);
            }

            return userToView;
        }

    }
}