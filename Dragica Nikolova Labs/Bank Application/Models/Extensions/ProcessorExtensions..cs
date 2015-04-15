using Models.Common;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Extensions
{
    public static class ProcessorExtensions
    {
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts) 
        {
            return processor.ProcessGroupTransactions(TransactionType.Debit, amount, accounts.ToArray<IAccount>());
        }
    }
}
