using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLiskovSubstitutionPrinciple.Model;

namespace TheLiskovSubstitutionPrinciple.TheGood
{
    public class PaymentFactory
    {
        public static PaymentBase GetPaymentService(PaymentServiceType serviceType)
        {
            switch (serviceType)
            {
                case PaymentServiceType.PayPal:
                    return new PayPalPayment("Andras", "Passw0rd");
                case PaymentServiceType.WorldPay:
                    return new WorldPayPayment("Andras", "Passw0rd", "ABC");
                default:
                    throw new NotImplementedException("No such service.");
            }
        }
    }
}
