using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BizfitechChallenge
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoadData()
        {
            ViewResults.DataSource = BizfitechChallenge.BLL.ViewProfileBLL.SearchUser(tbSearchFirstName.Text, tbSearchSurname.Text);
            ViewResults.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}