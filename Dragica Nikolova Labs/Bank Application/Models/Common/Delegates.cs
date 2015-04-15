using Models.Common;
using Models.Interfaces;
using System;

public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);
public delegate void EventHandler(Object sender, BalanceChangedEventArguments eventArgs);

public class BalanceChangedEventArguments: EventArgs
{
    public IAccount Account {get; private set;}
    public CurrencyAmount Change { get; private set; }

    public BalanceChangedEventArguments(IAccount account, CurrencyAmount change)
    {
        this.Account = account;
        this.Change = change;
    }
}