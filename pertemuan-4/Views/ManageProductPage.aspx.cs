using pertemuan_4.Models;
using pertemuan_4.Repository;
using pertemuan_4.Handlers;
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
            gvProduct.DataSource = ProductHandler.GetProductList();
            gvProduct.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string str_price = txtPrice.Text;
            string str_quantity = txtQuantity.Text;

            if (name == "")
            {
                lblError.Text = "Name must be filled!";
            }
            else if (str_price == "")
            {
                lblError.Text = "Price must be filled!";
            }
            else
            {
                int price = int.Parse(str_price);
                int quantity;

                // TryParse bakal cobain parse argument pertama,
                // kalo berhasil dia bakal di masukin ke quarntyty
                if (int.TryParse(str_quantity, out quantity))
                {
                    ProductHandler.InsertNewProduct(name, price, quantity);
                }
                else
                {
                    ProductHandler.InsertNewProductWithDefaultQuantity(name, price);
                }

                FillGrid();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string str_price = txtPrice.Text;
            string str_quantity = txtQuantity.Text;

            if (name == "")
            {
                lblError.Text = "Name must be filled!";
            }
            else if (str_price == "")
            {
                lblError.Text = "Price must be filled!";
            }
            else
            {
                int price = int.Parse(str_price);
                int quantity;

                // TryParse bakal cobain parse argument pertama,
                // kalo berhasil dia bakal di masukin ke quarntyty
                if (int.TryParse(str_quantity, out quantity))
                {
                    if (!ProductHandler.UpdateProduct(id, name, price, quantity))
                    {
                        lblError.Text = "Product not found!";
                    }
                    else
                    {
                        lblError.Text = "Update Succesful";
                    }
                }
                else
                {
                    if (!ProductHandler.UpdateProductWithDefaultQuantity(id, name, price))
                    {
                        lblError.Text = "Product not found!";
                    }
                    else
                    {
                        lblError.Text = "Update Succesful";
                    }
                }

                FillGrid();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            if (!ProductHandler.DeleteProductById(id))
            {
                lblError.Text = "Product not found!";
            }
            else
            {
                lblError.Text = "Delete Succesful";
            }

            FillGrid();
        }

        protected void linkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}