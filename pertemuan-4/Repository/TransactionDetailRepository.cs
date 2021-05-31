using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Repository
{
    public class TransactionDetailRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static bool InsertTransactionDetail(TransactionDetail transactionDetail)
        {
            if (transactionDetail != null)
            {
                db.TransactionDetails.Add(transactionDetail);
                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}