using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiskovSubstitutionPrinciple.TheBad
{
    public abstract class PaymentBase
    {
        public abstract string Refund(decimal amount, string transactionId);
    }
}
