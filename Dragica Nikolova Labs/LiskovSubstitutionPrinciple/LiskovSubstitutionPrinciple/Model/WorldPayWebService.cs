using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiskovSubstitutionPrinciple.Model
{
    public class WorldPayWebService
    {
        public string MakeRefund(decimal amount, string transactionId, string username,
            string password, string productId)
        {
            return "Success";
        }
    }
}
