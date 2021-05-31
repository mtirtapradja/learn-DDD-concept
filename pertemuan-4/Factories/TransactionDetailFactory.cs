using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int headerId, int productId, int quantity)
        {
            TransactionDetail transactionDetial = new TransactionDetail();
            transactionDetial.TransactionId = headerId;
            transactionDetial.ProductId = productId;
            transactionDetial.Quantity = quantity;
            return transactionDetial;
        }
    }
}