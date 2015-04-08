using Models.Common;
using Models.Helpers;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Accounts
{
    /// <summary>
    /// Models.Accounts.Account class.
    /// Defines attributes and actions associated with accounts in the bank system.
    /// </summary>
    public abstract class Account : IAccount
    {
        /// <summary>
        /// Stores the account id.
        /// </summary>
        private long id;
        public long Id
        {
            get { return id; }
            private set { id = value; }
        }

        /// <summary>
        /// Stores the account number.
        /// </summary>
        private string number;
        public string Number
        {
            get { return number; }
            private set { number = value; }
        }

        /// <summary>
        /// Stores a specific currency type of a particular account.
        /// </summary>
        public string Currency { get; private set; }

        /// <summary>
        /// Stores the current balance of a particular account.
        /// </summary>
        private CurrencyAmount balance;
        public CurrencyAmount Balance
        {
            get { return balance; }
            protected set
            {
                balance = value;
            }
        }

        /// <summary>
        /// A parameterized constructor that initializes id, number, currency and sets balance to zero.
        /// </summary>
        /// <param name="id">An account id</param>
        /// <param name="number">An account number</param>
        /// <param name="currency">An account currency type</param>
        public Account(long id, string number, string currency)
        {
            this.Id = id;
            this.Number = number;
            this.Currency = currency;
            CurrencyAmount b = new CurrencyAmount() {Amount = 0, Currency = currency };
            this.Balance = b;            
        }

        /// <summary>
        /// A parameterized constructor that initializes currency and sets balance to zero.
        /// </summary>
        /// <param name="number">An account number</param>
        /// <param name="currency">An account currency type</param>
        public Account(string number, string currency)
        {            
            this.Number = number;
            this.Currency = currency;
            CurrencyAmount b = new CurrencyAmount() { Amount = 0, Currency = currency };
            this.Balance = b;
        }
        
        /// <summary>
        ///A constructor with one parameter that invokes the constructor with three parameters, giving default values for id and number.
        /// </summary>
        /// <param name="currency">An account currency type</param>
        public Account(string currency) //: this(currency) 
        {
            this.Id = AccountHelper.GenerateAccountId();
            this.Currency = currency;
            CurrencyAmount b = new CurrencyAmount() { Amount = 0, Currency = currency };
            this.Balance = b;
            this.Number = this.GenerateAccountNumber();           
        }
        
        #region Public Methods
        /// <summary>
        /// Decreases the balance only if the currency of the specified amount and the account currency are the same.
        /// </summary>
        /// <param name="amount">The amount that is substracted from the account balance</param>
        /// <returns>Information whether the transaction failed or it was completed</returns>
        public virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (CheckCurrency(amount))
            {
                this.balance.Amount -= amount.Amount;
                return TransactionStatus.Completed;
            }
            return TransactionStatus.Failed;
        }
        /// <summary>
        /// Increases the balance only if the currency of the specified amount and the account currency are the same.
        /// </summary>
        /// <param name="amount">The amount that is added to the account balance</param>
        /// <returns>Information whether the transaction failed or it was completed</returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (CheckCurrency(amount))
            {
                this.balance.Amount += amount.Amount;
                return TransactionStatus.Completed;
            }
            return TransactionStatus.Failed;
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Checks if the account currency and the currency of the provided amount are of the same type.
        /// </summary>
        /// <param name="amount">The ammount that is going to affect the account balance</param>
        /// <returns>Whether or not the two currencies are of the same type</returns>
        protected bool CheckCurrency(CurrencyAmount amount)
        {
            if (this.balance.Currency == amount.Currency) return true;
            return false;
        }

        protected abstract string GenerateAccountNumber();
                  
        #endregion



    }
}
