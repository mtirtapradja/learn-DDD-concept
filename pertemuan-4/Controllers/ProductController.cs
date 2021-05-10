using pertemuan_4.Handlers;
using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Controllers
{
    public class ProductController
    {
        public static List<Product> GetProductList()
        {
            return ProductHandler.GetProductList();
        }

        public static string CheckInsert(string name, string str_price, string str_quantity)
        {
            string response = "";

            if (name == "")
            {
                response = "Name must be filled!";
            }
            else if (str_price == "")
            {
                response = "Price must be filled!";
            }
            else
            {
                int price = int.Parse(str_price);
                int quantity;

                // TryParse bakal cobain parse argument pertama,
                // kalo berhasil dia bakal di masukin ke quarntyty
                if (int.TryParse(str_quantity, out quantity))
                {
                    ProductHandler.InsertNewProduct(name, price, quantity);
                }
                else
                {
                    ProductHandler.InsertNewProductWithDefaultQuantity(name, price);
                }
            }

            return response;
        }

        public static string CheckUpdate(int id, string name, string str_price, string str_quantity)
        {
            string response = "";

            if (name == "")
            {
                response = "Name must be filled!";
            }
            else if (str_price == "")
            {
                response = "Price must be filled!";
            }
            else
            {
                int price = int.Parse(str_price);
                int quantity;

                // TryParse bakal cobain parse argument pertama,
                // kalo berhasil dia bakal di masukin ke quarntyty
                if (int.TryParse(str_quantity, out quantity))
                {
                    if (!ProductHandler.UpdateProduct(id, name, price, quantity))
                    {
                        response = "Product not found!";
                    }
                }
                else
                {
                    if (!ProductHandler.UpdateProductWithDefaultQuantity(id, name, price))
                    {
                        response = "Product not found!";
                    }
                }
            }
            return response;
        }

        public static string CheckDelete(int id)
        {
            string response = "";

            if (!ProductHandler.DeleteProductById(id))
            {
                response = "Product not found!";
            }

            return response;
        }
    }
}