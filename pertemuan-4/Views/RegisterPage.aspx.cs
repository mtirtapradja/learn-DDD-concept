using pertemuan_4.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pertemuan_4.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirm.Text;
            DateTime dob = calendarDOB.SelectedDate;

            if (username.Equals(""))
            {
                lblError.Text = "Username must be filled";
            }
            else if (password.Equals(""))
            {
                lblError.Text = "Password must be filled";
            }
            else if (!confirmPassword.Equals(password))
            {
                lblError.Text = "Confirm password must be the same as password";
            }
            else if (dob.Date == DateTime.MinValue)
            {
                lblError.Text = "DOB must be chosen";
            }
            else
            {
                if (UserHandler.InsertNewUser(username, password, dob))
                {
                    Response.Redirect("LoginPage.aspx");
                }
                else
                {
                    lblError.Text = "Failed to register!";
                }

            }
        }

        protected void linkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}