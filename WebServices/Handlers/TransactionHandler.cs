using WebServices.;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServices.Factories;
using WebServices.Repository;
using WebServices.Utils;

namespace WebServices.Handlers
{
    public class TransactionHandler
    {
        public static string FindByUserId(int userId)
        {
            List<TransactionHeader> result = new List<TransactionHeader>();

            var headers = TransactionRepository.FindByUserId(userId);

            if (headers.Count < 1)
            {
                return "";
            }
            else
            {
                foreach(var header in headers)
                {
                    List<TransactionDetail> finalDetail = new List<TransactionDetail>();

                    List<TransactionDetail> transactionDetails = TransactionRepository.FindDetailByHeaderId(header.Id);

                    foreach(var detail in transactionDetails)
                    {
                        Product product = ProductRepository.FindByProductId(detail.ProductId);

                        finalDetail.Add(TransactionFactory.CreateDetail(header.Id, product, detail.Quantity))
                    }

                    TransactionHeader finalHeader = TransactionFactory.CreateHeader(header.Id, header.UserId, header.TransactionDate, finalDetail);

                    result.Add(finalHeader);
                }

                return jsonHandler.Encode(result);
            }

        }
    }
}