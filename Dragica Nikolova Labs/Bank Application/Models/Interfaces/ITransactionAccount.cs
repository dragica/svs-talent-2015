using Models.Common;

namespace Models.Interfaces
{
    public interface ITransactionAccount : IAccount
    {
        CurrencyAmount Limit { get; }
    }
}
