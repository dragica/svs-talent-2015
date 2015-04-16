using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLiskovSubstitutionPrinciple.Model;

namespace TheLiskovSubstitutionPrinciple.TheBad
{
    /// <summary>
    /// The factory selects the concrete Payment class using the incoming enumeration.
    /// </summary>
    public class PaymentFactory
    {
        public static PaymentBase GetPaymentService(PaymentServiceType serviceType)
        {
            switch (serviceType)
            {
                case PaymentServiceType.PayPal:
                    return new PayPalPayment();
                case PaymentServiceType.WorldPay:
                    return new WorldPayPayment();
                default:
                    throw new NotImplementedException("No such service.");
            }
        }
    }
}
