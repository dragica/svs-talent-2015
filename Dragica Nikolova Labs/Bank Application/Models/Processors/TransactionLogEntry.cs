using Models.Accounts;
using Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Processors
{
    public class TransactionLogEntry
    {
        public TransactionType TransactionType { get; set; }
        public CurrencyAmount Amount { get; set; }
        public Account Accounts { get; set; }
        public TransactionStatus Status { get; set; }

        public TransactionLogEntry(TransactionType type, CurrencyAmount amount, Account accounts, TransactionStatus status)
        {
            this.TransactionType = type;
            this.Amount = amount;
            this.Accounts = accounts;
            this.Status = status;
        }

    }
}
