using pertemuan_4.Handlers;
using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Controllers
{
    public class UserController
    {
        public static string CheckUsername(string username)
        {
            string response = "";

            if (username == "")
            {
                response = "Username must be filled";
            }
            else if (username.Length < 5)
            {
                response = "Username must be at least 5 characters";
            }

            return response;
        }


        public static string CheckRegister(string username, string password, string confirmPassword, DateTime dob)
        {
            string response = CheckUsername(username);

            if (response == "")
            {
                if (password.Equals(""))
                {
                    response = "Password must be filled";
                }
                else if (!confirmPassword.Equals(password))
                {
                    response = "Confirm password must be the same as password";
                }
                else if (dob.Date == DateTime.MinValue)
                {
                    response = "DOB must be chosen";
                }
                else
                {
                    if (UserHandler.InsertNewUser(username, password, dob))
                    {
                        response = "";
                    }
                    else
                    {
                       response = "Failed to register!";
                    }

                }
            }

            return response;
        }

        public static string CheckLogin(string username, string password)
        {
            string response = "";

            User currentUser = UserHandler.Login(username, password);

            if (currentUser == null)
            {
                response = "User not found!";
            }

            return response;
        }

        public static User GetUser(string username, string password)
        {
            return UserHandler.GetUser(username, password);
        }
    }
}