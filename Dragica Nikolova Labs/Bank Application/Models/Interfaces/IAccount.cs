using Models.Common;
using System;

namespace Models.Interfaces
{
    public interface IAccount
    {
        long Id { get; }
        string Number { get; }
        string Currency { get; }
        CurrencyAmount Balance { get; }
        AccountStatus Status { get; set; }
        event EventHandler<BalanceChangedEventArguments> OnBalanceChanged;

        TransactionStatus DebitAmount(CurrencyAmount amount);
        TransactionStatus CreditAmount(CurrencyAmount amount);
    }
}
