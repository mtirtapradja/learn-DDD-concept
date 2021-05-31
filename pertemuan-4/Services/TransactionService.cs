using pertemuan_4.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Services
{
    public class TransactionService
    {
        private static MainService service = null;

        // Constructor
        private TransactionService() { }

        public static MainService GetInstance()
        {
            if (service == null)
            {
                service = new MainService();
            }

            return service;
        }
    }
}