using pertemuan_4.Models;
using pertemuan_4.Factories;
using pertemuan_4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Handlers
{
    public class ProductHandler
    {
        public static List<Product> GetProductList()
        {
            // Ngebalikin semua data di db dari repo
            return ProductRepository.GetAllProducts();
        }

        public static bool InsertNewProduct(string name, int price, int quantity)
        {
            // Bikin object pake Factory
            Product newProduct = ProductFactory.Create(name, price, quantity);
            
            // Masukin object nya ke db lewat repo
            return ProductRepository.InsertProduct(newProduct);
        }

        public static bool InsertNewProductWithDefaultQuantity(string name, int price)
        {
            // Bikin object pake Factory
            Product newProduct = ProductFactory.Create(name, price);

            // Masukin object nya ke db lewat repo
            return ProductRepository.InsertProduct(newProduct);
        }

        public static bool UpdateProduct(int id, string name, int price, int quantity)
        {
            // Cari produk yang mau di update lewat repo, karena cuma repo yang bisa
            // berhubungan sama db
            Product currentProduct = ProductRepository.GetProductById(id);

            if (currentProduct != null)
            {
                currentProduct.Name = name;
                currentProduct.Price = price;
                currentProduct.Quantity = quantity;

                return ProductRepository.UpdateProduct(currentProduct);
            }

            return false;
        }
        
        public static bool UpdateProductWithDefaultQuantity(int id, string name, int price)
        {
            // Cari produk yang mau di update lewat repo, karena cuma repo yang bisa
            // berhubungan sama db
            Product currentProduct = ProductRepository.GetProductById(id);

            if (currentProduct != null)
            {
                currentProduct.Name = name;
                currentProduct.Price = price;

                return ProductRepository.UpdateProduct(currentProduct);
            }

            return false;
        }

        public static bool DeleteProductById(int id)
        {
            // Cari produk yang mau di delete lewat repo, karena cuma repo yang bisa
            // berhubungan sama db
            Product currentProduct = ProductRepository.GetProductById(id);

            return ProductRepository.DeleteProduct(currentProduct);
        }
    }
}