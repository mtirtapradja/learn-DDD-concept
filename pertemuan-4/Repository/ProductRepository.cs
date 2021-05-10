using pertemuan_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pertemuan_4.Repository
{
    public class ProductRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static List<Product> GetAllProducts()
        {
            return (from x in db.Products select x).ToList();
        }

        public static bool InsertProduct(Product newProduct)
        {
            if (newProduct != null)
            {
                db.Products.Add(newProduct);
                db.SaveChanges();
                
                return true;
            }

            return false;
        }

        public static Product GetProductById(int id)
        {
            return (from x in db.Products where x.Id.Equals(id) select x)
                                            .FirstOrDefault();
        }

        public static bool UpdateProduct(Product currentProduct)
        {
            if (currentProduct != null)
            {
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public static bool DeleteProduct(Product currentProduct)
        {
            if (currentProduct != null)
            {
                db.Products.Remove(currentProduct);
                db.SaveChanges();

                return true;
            }

            return false;
        }
    }
}