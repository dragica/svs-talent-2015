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
    public sealed class LoanAccount : DepositAccount, ILoanAccount
    {
        public LoanAccount(TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount, string currency) 
            : base(depositPeriod, interestRate, startDate, endDate, transactionAccount, currency) {}

        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (CheckCurrency(amount))
            {
                CurrencyAmount amountCurrency = this.Balance;
                amountCurrency.Amount += amount.Amount;
                this.Balance = amountCurrency;
                return TransactionStatus.Completed;
            }
            return TransactionStatus.Failed;
        }

        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (CheckCurrency(amount))
            {
                CurrencyAmount amountCurrency = this.Balance;
                amountCurrency.Amount -= amount.Amount;
                this.Balance = amountCurrency;
                return TransactionStatus.Completed;
            }
            return TransactionStatus.Failed;
        }

        protected override string GenerateAccountNumber()
        {
            string accountNumber = AccountHelper.GenerateAccountNumber(typeof(LoanAccount), this.Id);
            return accountNumber;
        }
    }
}
