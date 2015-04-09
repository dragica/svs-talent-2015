using Models.Common;
using Models.Processors;

namespace Models.Interfaces
{
    public interface ITransactionProcessor
    {
        TransactionLogEntry LastTransaction { get; }
        int TransactionCount { get; }
        TransactionStatus ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount);
        TransactionStatus ProcessGroupTransactions(TransactionType transactionType, CurrencyAmount amount, IAccount[] accountArray);
        TransactionLogEntry this[int index]
        {
            get;
        }        
    }
}
  