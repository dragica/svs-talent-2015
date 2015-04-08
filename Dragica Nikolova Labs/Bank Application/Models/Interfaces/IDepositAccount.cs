using Models.Accounts;
using Models.Common;
using System;

namespace Models.Interfaces
{
    public interface IDepositAccount : IAccount
    {
        TimePeriod Period { get; }
        InterestRate Interest { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        ITransactionAccount TransactionAccount { get; }
    }
}
