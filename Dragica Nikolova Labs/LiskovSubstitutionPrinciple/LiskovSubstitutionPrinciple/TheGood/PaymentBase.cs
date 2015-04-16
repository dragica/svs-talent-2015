using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiskovSubstitutionPrinciple.TheGood
{
    public abstract class PaymentBase
    {
        public abstract bool Refund(decimal amount, string transactionId);
    }
}
