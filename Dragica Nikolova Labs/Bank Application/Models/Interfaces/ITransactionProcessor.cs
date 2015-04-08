using Models.Common;

namespace Models.Interfaces
{
    public interface ITransactionProcessor
    {
        void ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount);
    }
}
  