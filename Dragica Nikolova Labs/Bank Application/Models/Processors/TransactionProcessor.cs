using Models.Accounts;
using Models.Common;
using Models.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Processors
{
    public class TransactionProcessor : ITransactionProcessor
    {
        private static ITransactionProcessor instance;
        static int count = 0;
        IList _transactionLog;
        public TransactionLogEntry LastTransaction
        {
            get
            {
                if (_transactionLog.Count == 0 | _transactionLog == null) return null;
                else return (TransactionLogEntry)_transactionLog[_transactionLog.Count - 1];
            }
        }
        public int TransactionCount
        {
            get
            {
                return count;
            }
        }
        public TransactionLogEntry this[int index]
        {
            get
            {
                if (index >= _transactionLog.Count | index < 0 | _transactionLog == null) return null;
                return (TransactionLogEntry)_transactionLog[index];
            }
        }
        private TransactionProcessor()
        {
            _transactionLog = new ArrayList();
        }

        public TransactionStatus ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount)
        {
            TransactionStatus status = TransactionStatus.InProccess;
            TransactionStatus s1;
            TransactionStatus s2;
            switch (type)
            {
                case TransactionType.Credit:
                    status = accountFrom.CreditAmount(amount);
                    break;
                case TransactionType.Debit:
                    status = accountFrom.DebitAmount(amount);
                    break;
                case TransactionType.Transfer:
                    s1 = accountFrom.DebitAmount(amount);
                    s2 = accountTo.CreditAmount(amount);
                    if (s1 != TransactionStatus.Completed || s2 != TransactionStatus.Completed) status = TransactionStatus.Failed;
                    status = TransactionStatus.Completed;
                    break;
            }
            IAccount[] accountArray = new IAccount[2];
            accountArray[0] = accountFrom;
            accountArray[1] = accountTo;
            count++;
            this.LogTransaction(type, amount, accountArray, status);
            return status;

        }

        public TransactionStatus ProcessGroupTransactions(TransactionType transactionType, CurrencyAmount amount, IAccount[] accountArray)
        {
            TransactionStatus status = TransactionStatus.InProccess;
            switch (transactionType)
            {
                case TransactionType.Credit:
                    if (accountArray == null)
                        status = TransactionStatus.Failed;
                    foreach (var account in accountArray)
                    {
                        if (account != null)
                            status = account.CreditAmount(amount);
                    }
                    break;
                case TransactionType.Debit:
                    if (accountArray == null)
                        status = TransactionStatus.Failed;
                    foreach (var account in accountArray)
                    {
                        if (account != null)
                            status = account.DebitAmount(amount);
                    }
                    break;
                default:
                    status = TransactionStatus.Failed;
                    break;
            }
            this.LogTransaction(transactionType, amount, accountArray, status);
            count++;
            return status;

        }

        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accountArray, TransactionStatus transactionStatus)
        {
            TransactionLogEntry logEntry1 = new TransactionLogEntry(transactionType, amount, (Account)accountArray[0], transactionStatus);
            //TransactionLogEntry logEntry2 = new TransactionLogEntry(transactionType, amount, (Account)accountArray[1], transactionStatus);
            _transactionLog.Add(logEntry1);
            //_transactionLog.Add(logEntry2);


        }

        public static ITransactionProcessor GetTransactionProcessor()
        {
            if (instance == null)
            {
                instance = new TransactionProcessor();
            }
            return instance;
        }
    }
}
