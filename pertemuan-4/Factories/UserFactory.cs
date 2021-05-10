using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Factories
{
    public class UserFactory
    {
        public static User Create(string username, string password, DateTime DOB)
        {
            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;
            newUser.DOB = DOB;
            newUser.Role = "User";

            return newUser;
        } 
    }
}