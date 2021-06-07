using pertemuan_4.Datasets;
using pertemuan_4.Models;
using pertemuan_4.Reports;
using pertemuan_4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace pertemuan_4.Views
{
    public partial class ReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GroupingReport transactionReport = new GroupingReport();
            transactionReport.SetDataSource(GetData());
            crvTransaction.ReportSource = transactionReport;
        }

        protected DataSet GetData()
        {
            List<TransactionHeader> headers = TransactionHeaderRepository.GetAllTransactions();
            DataSet ds = new DataSet();
            var ds_header = ds.TransactionHeader;
            var ds_detail = ds.TransactionDetail;

            foreach (var header in headers)
            {
                var newRow = ds_header.NewRow();
                newRow["Id"] = header.Id;
                newRow["UserId"] = header.UserId;
                newRow["Date"] = header.TransactionDate;
                ds_header.Rows.Add(newRow);

                List<TransactionDetail> details = TransactionDetailRepository.GetTransactionDetails(header.Id);

                foreach (var detail in details)
                {
                    var newRowDetail = ds_detail.NewRow();
                    newRowDetail["TransactionId"] = detail.TransactionId;
                    newRowDetail["ProductId"] = detail.ProductId;
                    newRowDetail["ProductName"] = ProductRepository.GetProductById(detail.ProductId).Name;
                    newRowDetail["Price"] = ProductRepository.GetProductById(detail.ProductId).Price;
                    newRowDetail["Quantity"] = ProductRepository.GetProductById(detail.ProductId).Quantity;
                    ds_detail.Rows.Add(newRowDetail);
                }
            }

            return ds;
        }

        protected void linkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}