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
    public class DepositAccount : Account, IDepositAccount
    {
        public TimePeriod Period { get; private set; }
        public InterestRate Interest { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public ITransactionAccount TransactionAccount { get; private set; }

        public DepositAccount(TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount, string currency)
            : base(currency)
        {
            this.Period = depositPeriod;
            this.Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = transactionAccount;
        }

        protected override string GenerateAccountNumber()
        {
            string accountNumber = AccountHelper.GenerateAccountNumber(typeof(DepositAccount), this.Id);
            return accountNumber;
        }
        
    }
}
