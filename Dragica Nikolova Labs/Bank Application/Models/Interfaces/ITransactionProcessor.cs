using Models.Common;
using Models.Processors;
using System.Collections.Generic;

namespace Models.Interfaces
{
    public interface ITransactionProcessor
    {
        TransactionLogEntry LastTransaction { get; }
        TransactionLogEntry this[int index] { get; }
        int TransactionCount { get; }
        TransactionLogger ExternalLogger { get; set; }

        TransactionStatus ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount);
        TransactionStatus ProcessGroupTransactions(TransactionType transactionType, CurrencyAmount amount, IAccount[] accountArray);
        TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts);        
    }
}
  