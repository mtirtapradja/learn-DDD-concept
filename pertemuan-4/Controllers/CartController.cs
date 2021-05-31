using pertemuan_4.Handlers;
using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Controllers
{
    public class CartController
    {
        public static string CheckInsert(int userId, string str_productId, string str_quantity)
        {
            string response = "";

            if (str_productId == "")
            {
                response = "Product ID must be filled";
            }
            else if (str_quantity == "")
            {
                response = "Quantity must be filled";
            }
            else
            {
                int productId = int.Parse(str_productId);
                int quantity = int.Parse(str_quantity);

                if (!CartHandler.InsertCart(userId, productId, quantity))
                {
                    response = "Failed to order product";
                }
            }

            return response;
        }

        public static List<Cart> GetThisUserCart(int id)
        {
            return CartHandler.GetThisUserCart(id);
        }

        public static string Checkout(int userId)
        {
            string response = "";

            if (CartHandler.Checkout(userId))
            {
                response = "";
            } 
            else
            {
                response = "You haven't ordered anything";
            }

            return response;
        }
    }
}