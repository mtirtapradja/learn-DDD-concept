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

        public static bool Checkout(int userId)
        {
            List<Cart> carts = GetThisUserCart(userId);

            if (carts.Count == 0)
            {
                return false;
            }
            else
            {
                TransactionHeader transactionHeader = TransactionHeaderFactory.Create(userId);

                if (TransactionHeaderRepository.InsertTransactionHeader(transactionHeader))
                {
                    int headerId = transactionHeader.Id;

                    for (int i = 0; i < carts.Count(); i++)
                    {
                        TransactionDetail transactionDetail = TransactionDetailFactory.Create(headerId, carts[i].ProductId, carts[i].Quantity);
                        TransactionDetailRepository.InsertTransactionDetail(transactionDetail);
                    }
                    
                    for (int i = 0; i < carts.Count(); i++)
                    {
                        CartRepository.RemoveCart(carts[i]);
                    }

                    return true;
                }

                return false;
            }
        }
    }
}