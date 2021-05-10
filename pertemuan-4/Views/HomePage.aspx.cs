using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pertemuan_4.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            } 
            else
            {
                User currentUser = (User)Session["user"];
                lblWelcome.Text = "Welcome, " + currentUser.Username;

                if (currentUser.Role != "Admin")
                {
                    btnManageProduct.Visible = false;
                }
                else
                {
                    btnManageProduct.Visible = true;
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnManageProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageProductPage.aspx");
        }

        protected void btnOrderProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderProductPage.aspx");
        }
    }
}