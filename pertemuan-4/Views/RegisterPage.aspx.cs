using pertemuan_4.Controllers;
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

            string response = UserController.CheckRegister(username, password, confirmPassword, dob);

            if (response == "")
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                lblError.Text = response;
            }
        }

        protected void linkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}