using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Factories
{
    public class ProductFactory
    {
        public static Product Create(String name, int price, int quantity)
        {
            Product product = new Product();
            product.Name = name;
            product.Price = price;
            product.Quantity = quantity;

            return product;
        }

        public static Product Create(String name, int price)
        {
            Product product = new Product();
            product.Name = name;
            product.Price = price;
            product.Quantity = 100;

            return product;
        }
    }
}