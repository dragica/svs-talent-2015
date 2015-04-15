using Models.Common;
using Models.Helpers;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Accounts
{
    [AccountMetadata("Specifies a Transaction Account", "Some Transaction Limits")]
    public class TransactionAccount : Account, ITransactionAccount
    {
        public CurrencyAmount Limit { get; private set; }

        public TransactionAccount(decimal limitAmount, string currency) : base(currency)
        {
            CurrencyAmount limit = new CurrencyAmount() { Amount = limitAmount, Currency = currency};            
            this.Limit = limit;
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<TransactionAccount>(this.Id);
        }

        public void CheckLimit(CurrencyAmount amount)
        {
            if (amount.Amount > Limit.Amount) throw new LimitOverflowException();
        }
    }
}
