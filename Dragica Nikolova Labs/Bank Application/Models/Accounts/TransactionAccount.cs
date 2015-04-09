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
            string accountNumber = AccountHelper.GenerateAccountNumber(typeof(TransactionAccount),this.Id);
            return accountNumber;
        }
    }
}
