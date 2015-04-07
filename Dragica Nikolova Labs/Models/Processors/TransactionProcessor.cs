using Models.Common;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Processors
{
    public class TransactionProcessor : ITransactionProcessor
    {
        public void ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount)
        {
            switch(type)
            {
                case TransactionType.Credit:
                    accountFrom.CreditAmount(amount);
                    break;
                case TransactionType.Debit:
                    accountFrom.DebitAmount(amount);
                    break;
                case TransactionType.Transfer:
                    accountFrom.DebitAmount(amount);
                    accountTo.CreditAmount(amount);
                    break;
            }
        }
    }
}
