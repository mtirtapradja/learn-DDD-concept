using pertemuan_4.Models;
using pertemuan_4.Repository;
using pertemuan_4.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Handlers
{
    public class UserHandler
    {
        public static User Login(string username, string password)
        {
            return UserRepository.GetUser(username, password);
        }

        public static bool InsertNewUser(string username, string password, DateTime DOB)
        {
            User currentUser = UserFactory.Create(username, password, DOB);

            return UserRepository.InsertUser(currentUser);
        }
    }
}