using pertemuan_4.Factories;
using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Repository
{
    public class UserRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static bool InsertUser(User currentUser)
        {
            if (currentUser != null)
            {
                db.Users.Add(currentUser);
                db.SaveChanges();

                return true;
            }

            return false;
        }


        public static User GetUser(string username, string password)
        {
            User currentUser = (from x in db.Users where x.Username.Equals(username) && 
                                x.Password.Equals(password) select x)
                                .FirstOrDefault();

            return currentUser;
        }
    }
}