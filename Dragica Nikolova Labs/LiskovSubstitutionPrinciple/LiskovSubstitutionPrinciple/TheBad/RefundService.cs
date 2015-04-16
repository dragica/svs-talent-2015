using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLiskovSubstitutionPrinciple.Model;

namespace TheLiskovSubstitutionPrinciple.TheBad
{
    public class RefundService
    {
        public bool Refund(PaymentServiceType paymentServiceType, decimal amount, string transactionId)
        {
            bool refundSuccess = false;
            PaymentBase payment = PaymentFactory.GetPaymentService(paymentServiceType);

            /*We need to check the type of the payment object returned by the factory
            using if-else statements which is sign of LSP violation.
            We need to extend the if-else statements as soon as a new provider 
            is implemented, which also violates the OCP.*/
            if ((payment as PayPalPayment) != null)
            {
                ((PayPalPayment)payment).AccountName = "Dragica";
                ((PayPalPayment)payment).Password = "Passw0rd!";
            }
            else if ((payment as WorldPayPayment) != null)
            {
                ((WorldPayPayment)payment).AccountName = "Dragica";
                ((WorldPayPayment)payment).Password = "Passw0rd!";
                ((WorldPayPayment)payment).ProductId = "ABC";
            }

            string serviceResponse = payment.Refund(amount, transactionId);

            //We need to add new serviceResponse.Contains bit if a new payment provider returns a different response, such as "OK".
            if (serviceResponse.Contains("Auth") || serviceResponse.Contains("Success"))
            {
                refundSuccess = true;
            }

            return refundSuccess;
        }
    }
}
