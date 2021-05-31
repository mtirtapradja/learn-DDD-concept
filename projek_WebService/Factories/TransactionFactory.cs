using projek_WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Factories
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateHeader(int headerId, int userId, DateTime date, List<TransactionDetail> details)
        {
            return new TransactionHeader()
            {
                Id = headerId,
                UserId = userId,
                TransactionDate = date,
                TransactionDetails = details
            };
        }
        
        public static TransactionDetail CreateDetail(int headerId, Product product, int quantity)
        {
            return new TransactionDetail()
            {
                TransactionId = headerId,
                ProductId = product.Id,
                Quantity = quantity,
            };
        }
    }
}