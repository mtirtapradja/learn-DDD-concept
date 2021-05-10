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
    public partial class OrdcerProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        protected void FillGrid()
        {
            int userId = ((User)Session["user"]).Id;

            gvCart.DataSource = CartController.GetThisUserCart(userId);
            gvCart.DataBind();

            gvProducts.DataSource = ProductController.GetProductList();
            gvProducts.DataBind();
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string str_productId = txtProductID.Text;
            string str_quantity= txtQuantity.Text;

            // Dari session di cast ke User terus diambil Id nya
            int userId = ((User)Session["user"]).Id;

            string response = CartController.CheckInsert(userId, str_productId, str_quantity);

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
    }
}