using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLiskovSubstitutionPrinciple.Model;

namespace TheLiskovSubstitutionPrinciple.TheGood
{
    public class PayPalPayment : PaymentBase
    {
        /*We provide constructor in each Payment class that forces clients to provide 
        all the necessary parameters. Now we are rid of the downcasting issue. */
        public PayPalPayment(string accountName, string password)
        {
            AccountName = accountName;
            Password = password;
        }

        public string AccountName { get; set; }
        public string Password { get; set; }

        //Now the string returned from the payment service is evaluated within the concrete payment class itself. 
        public override bool Refund(decimal amount, string transactionId)
        {
            PayPalWebService payPalWebService = new PayPalWebService();
            string token = payPalWebService.GetTransactionToken(AccountName, Password);
            string response = payPalWebService.MakeRefund(amount, transactionId, token);
            if (response.Contains("Auth"))
                return true;
            return false;
        }
    }
}
