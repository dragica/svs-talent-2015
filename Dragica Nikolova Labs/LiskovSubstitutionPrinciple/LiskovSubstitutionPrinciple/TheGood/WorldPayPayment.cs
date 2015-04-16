using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLiskovSubstitutionPrinciple.Model;

namespace TheLiskovSubstitutionPrinciple.TheGood
{
    public class WorldPayPayment : PaymentBase
    {
        /*We provide constructor in each Payment class that forces clients to provide 
        all the necessary parameters. Now we are rid of the downcasting issue. */
        public WorldPayPayment(string accountId, string password, string productId)
        {
            AccountName = accountId;
            Password = password;
            ProductId = productId;
        }

        public string AccountName { get; set; }
        public string Password { get; set; }
        public string ProductId { get; set; }

        //Now the string returned from the payment service is evaluated within the concrete payment class itself. 
        public override bool Refund(decimal amount, string transactionId)
        {
            WorldPayWebService worldPayWebService = new WorldPayWebService();
            string response = worldPayWebService.MakeRefund(amount, transactionId, AccountName, Password, ProductId);
            if (response.Contains("Success"))
                return true;
            return false;
        }
    }
}
