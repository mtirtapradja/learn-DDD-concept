using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Repository
{
    public class TransactionHeaderRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static bool InsertTransactionHeader(TransactionHeader transactionHeader)
        {
            if (transactionHeader != null)
            {
                db.TransactionHeaders.Add(transactionHeader);
                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}