using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;
using Antlr.Runtime.Misc;

namespace BizfitechChallenge
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Users userToView = BizfitechChallenge.BLL.ViewProfileBLL.ViewUser(Convert.ToInt32(Request.QueryString["ID"]));

            lblTitle.Text = "Welcome To " + userToView.GetFirstName() + " " + userToView.GetSurname() + "'s profile!";

            lblFirstName.Text = userToView.GetFirstName();
            lblSurname.Text = userToView.GetSurname();
            lblEmail.Text = userToView.GetEmail();
            lblBio.Text = userToView.GetBio();
            lblTwitterRef.Text = userToView.GetTwitterRef();

            if (userToView.GetTwitterRef() != "")
            {
                javascriptBlock.Text = @"
            <script type='text/javascript'>
    
                $(document).ready(function() {
          
                            var initialQuery = '" + userToView.GetTwitterRef() + @"'
                            initialQuery = initialQuery.replace(' ', '');
                            var queryTags = initialQuery.split(',');
           
 
 
                    $('.social-feed-container').socialfeed({
                                // Twitter
                                twitter:
                                {
                                    accounts: queryTags,
                            limit: 5,
                            consumer_key: 'qzRXgkI7enflNJH1lWFvujT2P', // make sure to have your app read-only
                            consumer_secret: '8e7E7gHuTwyDHw9lGQFO73FcUwz9YozT37lEvZulMq8FXaPl8O', // make sure to have your app read-only
                        },            // GENERAL SETTINGS
                        length: 200,
                        show_media: true,
                        // Moderation function - if returns false, template will have class hidden
                        moderation: function(content) {
                                    return (content.text) ? content.text.indexOf('fuck') == -1 : true;
                                },
                        //update_period: 5000,
                        // When all the posts are collected and displayed - this function is evoked
                        callback: function() {
                                    $('#placeholder').hide();
                                }
                            });
                        });

            </script>";
            }
            else
            {
                panelForJS.Visible = false;
            }
        }

       
    }
}