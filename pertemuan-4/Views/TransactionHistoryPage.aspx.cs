using pertemuan_4.Models;
using pertemuan_4.Utils;
using pertemuan_4.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pertemuan_4.Views
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        private MainService service = new MainService();
        protected static List<TransactionHeader> transactionHeaders = new List<TransactionHeader>();

        protected void FillGrid()
        {
            gvTransactionHistory.DataSource = transactionHeaders;
            gvTransactionHistory.DataBind();

            List<TransactionDetail> transactionDetails = new List<TransactionDetail>();

            foreach(var header in transactionHeaders)
            {
                foreach(var detail in header.TransactionDetails)
                {
                    transactionDetails.Add(detail);
                }
            }

            gvDetail.DataSource = transactionDetails;
            gvDetail.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                User currentUser = (User)Session["user"];
                string json = service.GetTransaction(currentUser.Id);

                transactionHeaders = JsonHandler.Decode<List<TransactionHeader>>(json);

                FillGrid();
            }
        }

        protected void linkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}