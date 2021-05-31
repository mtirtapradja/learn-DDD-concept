using projek_WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Repository
{
    public class TransactionRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static List<TransactionHeader> FindByUserId(int userId)
        {
            db.Configuration.ProxyCreationEnabled = false;

            return (from x in db.TransactionHeaders where x.UserId == userId select x).ToList();
        }
        
        public static List<TransactionDetail> FindDetailByHeaderId(int headerId)
        {
            db.Configuration.ProxyCreationEnabled = false;

            return (from x in db.TransactionDetails where x.TransactionId == headerId select x).ToList();
        }


    }
}