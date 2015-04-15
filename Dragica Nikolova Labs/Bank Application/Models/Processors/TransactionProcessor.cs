using Models.Accounts;
using Models.Common;
using Models.Helpers;
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
        TransactionLogger externalLogger;
        static int count = 0;
        IList<TransactionLogEntry> _transactionLog;

        public TransactionLogEntry LastTransaction
        {
            get
            {
                if (_transactionLog.Count == 0 | _transactionLog == null) return null;
                else return _transactionLog[_transactionLog.Count - 1];
            }
        }

        public int TransactionCount
        {
            get
            {
                return count;
            }
        }

        public TransactionLogger ExternalLogger
        {
            get
            {
                return externalLogger;
            }
            set
            {
                externalLogger = value;
            }
        }

        public TransactionLogEntry this[int index]
        {
            get
            {
                if (index >= _transactionLog.Count | index < 0 | _transactionLog == null) return null;
                return _transactionLog[index];
            }
        }

        private TransactionProcessor()
        {
            _transactionLog = new List<TransactionLogEntry>();
        }

        public static ITransactionProcessor GetTransactionProcessor()
        {
            if (instance == null)
            {
                instance = new TransactionProcessor();
                instance.ExternalLogger = AccountHelper.LogTransaction;
                instance.ExternalLogger += AccountHelper.NotifyNationalBank;
            }
            return instance;
        }

        public TransactionStatus ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount)
        {
            TransactionStatus status2, status = TransactionStatus.InProccess; 
            switch (type)
            {
                case TransactionType.Credit:
                    status = accountFrom.CreditAmount(amount);
                    CallExternalLogger(accountFrom,type,amount);
                    break;
                case TransactionType.Debit:
                    status = accountFrom.DebitAmount(amount);
                    CallExternalLogger(accountFrom, type, amount);
                    break;
                case TransactionType.Transfer:
                    status = accountFrom.DebitAmount(amount);
                    status2 = accountTo.CreditAmount(amount);
                    CallExternalLogger(accountFrom, type, amount);
                    CallExternalLogger(accountTo, type, amount);
                    if (status != TransactionStatus.Completed || status2 != TransactionStatus.Completed) status = TransactionStatus.Failed;
                    break;
            }
            IAccount[] accounts = new IAccount[2];
            accounts[0] = accountFrom;
            accounts[1] = accountTo;
            count++;
            this.LogTransaction(type, amount, accounts, status);
            return status;
        }

        public TransactionStatus ProcessGroupTransactions(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            if (accounts.Any(account => account.Status == AccountStatus.Inactive)) 
                throw new AccountStatusInvalidException("Accounts provided in the transaction are Inactive.");

            TransactionStatus[] statuses = new TransactionStatus[2];
            TransactionStatus status = TransactionStatus.InProccess; ;
            int i = 0 ;

            switch (transactionType)
            {
                case TransactionType.Credit:
                    if (accounts == null)
                        status = TransactionStatus.Failed;                    
                    foreach (var account in accounts)
                    {
                        if (account != null)
                        {
                            statuses[i] = account.CreditAmount(amount);
                            CallExternalLogger(account, transactionType, amount);
                        }
                        i++;
                    }
                    if (statuses[0] != TransactionStatus.Completed || statuses[1] != TransactionStatus.Completed) status = TransactionStatus.Failed;
                    break;
                case TransactionType.Debit:
                    if (accounts == null)
                        status = TransactionStatus.Failed;                    
                    foreach (var account in accounts)
                    {
                        if (account != null)
                        {
                            statuses[i] = account.DebitAmount(amount);
                            CallExternalLogger(account, transactionType, amount);
                        }
                        i++;
                    }
                    if (statuses[0] != TransactionStatus.Completed || statuses[1] != TransactionStatus.Completed) status = TransactionStatus.Failed;
                    else status = TransactionStatus.Completed;
                    break;
                default:
                    status = TransactionStatus.Failed;
                    break;
            }
            this.LogTransaction(transactionType, amount, accounts, status);
            count++;
            return status;
        }

        public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            throw new NotImplementedException();
        }

        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus transactionStatus)
        {
            Account[] accountArray = {(Account)accounts[0], (Account)accounts[1]};
            TransactionLogEntry logEntry = new TransactionLogEntry(transactionType, amount, accountArray, transactionStatus);
            _transactionLog.Add(logEntry);
        }        

        private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            ExternalLogger(account, transactionType, amount);
        }        
    }
}
