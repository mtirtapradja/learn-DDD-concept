using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Factories
{
    public class CartFactory
    {
        public static Cart Create(int userId, int productId, int quantity)
        {
            Cart c = new Cart();
            c.UserId = userId;
            c.ProductId = productId;
            c.Quantity = quantity;

            return c;
        }
    }
}