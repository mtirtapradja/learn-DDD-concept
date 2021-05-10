using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Repository
{
    public class CartRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static bool InsertCart(Cart newCart)
        {
            if (newCart != null)
            {
                db.Carts.Add(newCart);
                db.SaveChanges();

                return true;
            }

            return false;
        }

        public static List<Cart> GetThisUserCart(int id)
        {
            return (from x in db.Carts where x.UserId == id select x).ToList();
        }
    }
}