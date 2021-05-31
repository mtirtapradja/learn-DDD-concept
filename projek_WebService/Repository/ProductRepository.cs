using projek_WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Repository
{
    public class ProductRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static Product FindByProductId(int productId)
        {
            db.Configuration.ProxyCreationEnabled = false;

            return (from x in db.Products where x.Id == productId select x).FirstOrDefault();
        }
    }
}