using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BizfitechChallenge
{
    public partial class CreateNewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateAccountButton_Click(object sender, EventArgs e)
        {

            bool canProceed = true;

            if (tbFirstName.Text != "")
            {
                lblFirstName.Text = "";
            }
            else
            {
                canProceed = false;
                lblFirstName.Text = "Please enter a First Name!";
            }

            if (tbSurname.Text != "")
            {
                lblSurname.Text = "";
            }
            else
            {
                canProceed = false;
                lblSurname.Text = "Please enter a Surname!";
            }

            if (tbEmail.Text != "")
            {
                lblEmail.Text = "";
            }
            else
            {
                canProceed = false;
                lblEmail.Text = "Please enter an Email!";
            }

            if (tbBio.Text != "")
            {
                lblBio.Text = "";
            }
            else
            {
                canProceed = false;
                lblBio.Text = "Please enter a brief Bio!";
            }

            if (tbTwitterRef.Text != "")
            {
                lblTwitterRef.Text = "";
            }
            else
            {
                canProceed = false;
                lblTwitterRef.Text = "Please enter a brief Twitter Ref!";
            }

            if (canProceed)
            {
                CreateAccountResults.Text = BizfitechChallenge.BLL.CreateProfileBLL.CreateNewUser(tbFirstName.Text,
                    tbSurname.Text, tbEmail.Text, tbBio.Text, tbTwitterRef.Text);
            }

        }
    }
}