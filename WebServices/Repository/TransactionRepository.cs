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
            db.configuration.ProxyCreationEnabled = false;

            return (from x in db.TransactionHeaders where x.UserId == userId select x).toList();
        }
        
        public static List<TransactionDetail> FindDetailByHeaderId(int headerId)
        {
            db.configuration.ProxyCreationEnabled = false;

            return (from x in db.TransactionDetails where x.TransactionId == headerId select x).toList();
        }


    }
}