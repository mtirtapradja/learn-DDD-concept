using pertemuan_4.Handlers;
using pertemuan_4.Controllers;
using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pertemuan_4.Views
{
    public partial class ManageProductPage : System.Web.UI.Page
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
                if (currentUser.Role != "Admin")
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    FillGrid();
                }
            }
        }

        protected void FillGrid()
        {
            gvProduct.DataSource = ProductController.GetProductList();
            gvProduct.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string str_price = txtPrice.Text;
            string str_quantity = txtQuantity.Text;

            string response = ProductController.CheckInsert(name, str_price, str_quantity);

            if (response == "")
            {
                lblError.Text = "";
                FillGrid();
            }
            else
            {
                lblError.Text = response;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string str_price = txtPrice.Text;
            string str_quantity = txtQuantity.Text;

            string response = ProductController.CheckUpdate(id, name, str_price, str_quantity);

            if (response == "")
            {
                lblError.Text = "";
                FillGrid();
            }
            else
            {
                lblError.Text = response;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            string response = ProductController.CheckDelete(id);

            if (response == "")
            {
                lblError.Text = "";
                FillGrid();
            }
            else
            {
                lblError.Text = response;
            }
        }

        protected void linkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}