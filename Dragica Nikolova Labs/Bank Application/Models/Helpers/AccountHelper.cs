using Models.Accounts;
using Models.Common;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Models.Helpers
{
    public static class AccountHelper
    {
        private static int s_AccountId;

        static AccountHelper()
        {
            s_AccountId = 0;
        }

        public static int GenerateAccountId()
        {
            s_AccountId++;
            return s_AccountId;
        }

        public static string GenerateAccountNumber(Type accountType, long accountId)
        {
            string accountNumber;
            if (accountType == typeof(TransactionAccount))
                accountNumber = "TR0000" + Convert.ToString(s_AccountId);
            else if (accountType == typeof(DepositAccount))
                accountNumber = "DP0000" + Convert.ToString(s_AccountId);
            else accountNumber = "LN0000" + Convert.ToString(s_AccountId);
            return accountNumber;
        }

        public static string GenerateAccountNumber<T>(long accountId) where T:IAccount
        {
            string accountNumber;
            if (typeof(T) == typeof(TransactionAccount))
                accountNumber = GenerateAccountNumber(typeof(TransactionAccount), accountId);
            else if (typeof(T) == typeof(DepositAccount))
                accountNumber = GenerateAccountNumber(typeof(DepositAccount), accountId);
            else accountNumber = GenerateAccountNumber(typeof(LoanAccount), accountId);
            return accountNumber;
        }

        public static void LogTransaction(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if (amount.Amount > 20000 & amount.Currency == "MKD")
                Debug.WriteLine(transactionType.ToString() + " " + account.Number + " " + amount.Amount.ToString() + " " + amount.Currency );
        }

        public static void NotifyNationalBank(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if (amount.Amount > 25000 & amount.Currency == "MKD")
                Debug.WriteLine("The National bank is notified for this transaction: " + transactionType.ToString() + " " + account.Number + " " + amount.Amount.ToString() + " " + amount.Currency);
        }
    }
}
