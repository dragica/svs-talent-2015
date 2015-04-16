using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLiskovSubstitutionPrinciple.Model;

namespace TheLiskovSubstitutionPrinciple.TheGood
{
    public class RefundService
    {
        //Now here’s no need to downcast anything or to extend this method if a new service is introduced.
        public bool Refund(PaymentServiceType paymentServiceType, decimal amount, string transactionId)
        {
            PaymentBase payment = PaymentFactory.GetPaymentService(paymentServiceType);
            return payment.Refund(amount, transactionId);
        }
    }
}
