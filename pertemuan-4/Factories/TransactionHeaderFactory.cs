using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int userId)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.UserId = userId;
            transactionHeader.TransactionDate = DateTime.Now;
            return transactionHeader;
        }
    }
}