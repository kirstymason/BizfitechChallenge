using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BizfitechChallenge
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Users userToEdit =
                    BizfitechChallenge.BLL.EditProfileBLL.GetFullUserDetails(Convert.ToInt32(Request.QueryString["ID"]));

                tbFirstName.Text = userToEdit.GetFirstName();
                tbSurname.Text = userToEdit.GetSurname();
                tbEmail.Text = userToEdit.GetEmail();
                tbBio.Text = userToEdit.GetBio();
                tbTwitterRef.Text = userToEdit.GetTwitterRef();
            }
        }

        protected void EditAccountButton_Click(object sender, EventArgs e)
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
                EditAccountResults.Text =
                    BizfitechChallenge.BLL.EditProfileBLL.EditUser(Convert.ToInt32(Request.QueryString["ID"]),
                        tbFirstName.Text, tbSurname.Text, tbEmail.Text, tbBio.Text, tbTwitterRef.Text);
            }
        }
    }
}