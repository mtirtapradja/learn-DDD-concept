using pertemuan_4.Models;
using pertemuan_4.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pertemuan_4.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User currentUser = UserHandler.Login(username, password);

            if (currentUser == null)
            {
                lblError.Text = "User not found!";
            }
            else
            {
                Session["user"] = currentUser;
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void linkRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}