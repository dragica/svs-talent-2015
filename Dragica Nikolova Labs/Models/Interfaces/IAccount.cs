using Models.Common;

namespace Models.Interfaces
{
    public interface IAccount
    {
        long Id { get; }
        string Number { get; }
        string Currency { get; }
        CurrencyAmount Balance { get; }

        TransactionStatus DebitAmount(CurrencyAmount amount);
        TransactionStatus CreditAmount(CurrencyAmount amount);
    }
}
