using pertemuan_4.Factories;
using pertemuan_4.Models;
using pertemuan_4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Handlers
{
    public class CartHandler
    {
        public static bool InsertCart(int userId, int productId, int quantity)
        {
            Cart newCart = CartFactory.Create(userId, productId, quantity);
            return CartRepository.InsertCart(newCart);
        }

        public static List<Cart> GetThisUserCart(int id)
        {
            return CartRepository.GetThisUserCart(id);
        }
    }
}