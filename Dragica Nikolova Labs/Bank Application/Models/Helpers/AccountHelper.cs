using Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
