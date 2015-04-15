using Models.Processors;
using Models.Accounts;
using Models.Common;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Models.Extensions;
using Models.Party;

namespace BankSystemExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            cbPeriodUnitOfTime.SelectedIndex = 0;
            cbInterestUnitOfTime.SelectedIndex = 0;
        }
        static int count = 0;

        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            //Create new TransactionAccount instance.
            TransactionAccount transactionAccount = this.CreateTransactionAccount();

            //Display all TransactionAccount details.
            this.ShowAccountDetails(transactionAccount);
        }

        private TransactionAccount CreateTransactionAccount()
        {
            //Parse values for Limit and Currency from TextBoxes.
            decimal limitAmount = Decimal.Parse(txtLimit.Text);
            string currency = txtCurrency.Text;

            //And create new TransactionAccount instance.
            TransactionAccount transactionAccount = new TransactionAccount(limitAmount, currency);

            return transactionAccount;

        }

        private void ShowAccountDetails(IAccount account)
        {
            //Display Account details.
            lblId.Text = Convert.ToString(account.Id);
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            CurrencyAmount amount = account.Balance;
            string balance = Convert.ToString(amount.Amount) + " " + amount.Currency;
            lblBalance.Text = balance;

            //Check if this is a TransactionAccount and if this is true populate the TransactionAccount specific labels.
            if (account is TransactionAccount) ShowTransactionAccountDetails((ITransactionAccount)account);

            //Check if this is a DepositAccount and if this is true populate the DepositAccount specific labels.
            if (account is DepositAccount) ShowDepositAccountDetails((IDepositAccount)account);
        }

        private void ShowTransactionAccountDetails(ITransactionAccount account)
        {
            lblLimitCurrency.Text = Convert.ToString(account.Limit.Amount) + " " + account.Limit.Currency;

            //Don't display details for DepositAccount(if a deposit account is created previosly).
            lblPeriodUnitOfTime.Text = String.Empty;
            lblPercentUnitOfTime.Text = String.Empty;
            lblStartDate.Text = String.Empty;
            lblEndDate.Text = String.Empty;
        }

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            DepositAccount depositAccount = CreateDepositAccount();
            
            this.ShowAccountDetails(depositAccount);
        }

        private void ShowDepositAccountDetails(IDepositAccount account)
        {
            lblPeriodUnitOfTime.Text = Convert.ToString(account.Period.Period) + " " + 
                account.Period.Unit.ToString();
            lblPercentUnitOfTime.Text = Convert.ToString(account.Interest.Percent) + " " + 
                Convert.ToString(account.Interest.Unit);
            lblStartDate.Text = account.StartDate.ToString();
            lblEndDate.Text = account.EndDate.ToString();
            lblLimitCurrency.Text = Convert.ToString(account.TransactionAccount.Limit.Amount) + " " + 
                account.TransactionAccount.Limit.Currency;
        }

        private DepositAccount CreateDepositAccount()
        {
            //Create neccessary members for DepositAccount constructor.
            int period = Int32.Parse(txtPeriod.Text);
            UnitOfTime periodUnitOfTime = (UnitOfTime)Enum.Parse(typeof(UnitOfTime), cbPeriodUnitOfTime.Text);
            TimePeriod depositPeriod = new TimePeriod() { Period = period, Unit = periodUnitOfTime };
            decimal percent = Convert.ToDecimal(txtInterest.Text);
            UnitOfTime percentUnitOfTime = (UnitOfTime)Enum.Parse(typeof(UnitOfTime), cbInterestUnitOfTime.Text);
            InterestRate interestRate = new InterestRate() { Percent = percent, Unit = percentUnitOfTime };
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string currency = txtCurrency.Text;
            TransactionAccount transactionAccount = this.CreateTransactionAccount();

            //And create new instance.
            DepositAccount depositAccount = new DepositAccount(depositPeriod, interestRate, startDate, endDate, transactionAccount, currency);
            depositAccount.OnBalanceChanged += this.OnBalanceChangedHandler;
            return depositAccount;
        }
        
        private LoanAccount CreateLoanAccount()
        {
            //Create neccessary members for LoanAccount constructor.
            int period = Int32.Parse(txtPeriod.Text);
            UnitOfTime periodUnitOfTime = (UnitOfTime)Enum.Parse(typeof(UnitOfTime), cbPeriodUnitOfTime.Text);
            TimePeriod depositPeriod = new TimePeriod() { Period = period, Unit = periodUnitOfTime };
            decimal percent = Convert.ToDecimal(txtInterest.Text);
            UnitOfTime percentUnitOfTime = (UnitOfTime)Enum.Parse(typeof(UnitOfTime), cbInterestUnitOfTime.Text);
            InterestRate interestRate = new InterestRate() { Percent = percent, Unit = percentUnitOfTime };
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string currency = txtCurrency.Text;
            TransactionAccount transactionAccount = this.CreateTransactionAccount();

            //And create new instance.
            LoanAccount loanAccount = new LoanAccount(depositPeriod, interestRate, startDate, endDate, transactionAccount, currency);
            EventHandler<BalanceChangedEventArguments> DisplayMessage = delegate(object sender, BalanceChangedEventArguments e)
            {
                count++;
                Debug.WriteLine("The balance of the loan account was changed.");
                Debug.WriteLine("Number of calls: "+ count);
            };

            loanAccount.OnBalanceChanged += this.OnBalanceChangedHandler;
            loanAccount.OnBalanceChanged += DisplayMessage;

            return loanAccount;
        }

        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            bool _errorOccurred = false;
            string _errorMsg = String.Empty;
            CurrencyAmount amount = new CurrencyAmount() 
            { 
                Amount = Convert.ToDecimal(txtTransactionAmount.Text), 
                Currency = Convert.ToString(txtTransactionCurrency.Text)
            };
            ILoanAccount loanAccount = this.CreateLoanAccount();
            IDepositAccount depositAccount = this.CreateDepositAccount();
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            try
            {
                transactionProcessor.ProcessTransaction(TransactionType.Transfer, loanAccount, depositAccount, amount); 
                this.DisplayLastTransactionDetails();
            }
            catch(CurrencyMismatchException)
            {
                _errorOccurred = true;
                _errorMsg = "Different currency from the account currency.";
                txtTransactionCurrency.Text = String.Empty;
            }
            catch (ApplicationException)
            {
               throw;
            }
            var transactionDetails = new { FromAccount = loanAccount, 
                ToAccount = depositAccount,
                Amount = amount,
                HasError = _errorOccurred,
                ErrorMessage = _errorMsg
            };
            if (transactionDetails.HasError) MessageBox.Show(transactionDetails.ErrorMessage, "Error Detected in Input");
            else MessageBox.Show("From: " + transactionDetails.FromAccount.Number + 
                "\nTo: " + transactionDetails.ToAccount.Number + 
                "\nAmount: " + Convert.ToString(transactionDetails.Amount.Amount) + " " + transactionDetails.Amount.Currency, 
                "Transaction Details" );
        }

        private void ShowAccountDetails_To(IAccount account)
        {
            //Fill in Account common labels.
            lbl_ToId.Text = Convert.ToString(account.Id);
            lbl_ToNumber.Text = account.Number;
            lbl_ToCurrency.Text = account.Currency;
            CurrencyAmount amount = account.Balance;            
            lbl_ToBalance.Text = Convert.ToString(amount.Amount) + " " + amount.Currency; ;

            //Fill in DepositAccount common labels.
            DepositAccount depositAccount = (DepositAccount)account;
            lbl_ToLimit.Text = Convert.ToString(depositAccount.TransactionAccount.Limit.Amount) + " " + 
                depositAccount.TransactionAccount.Limit.Currency;           
            lbl_ToPeriod.Text = Convert.ToString(depositAccount.Period.Period) + " " +
                depositAccount.Period.Unit.ToString();
            lbl_ToInterest.Text = Convert.ToString(depositAccount.Interest.Percent) + " " + 
                Convert.ToString(depositAccount.Interest.Unit);
            lbl_ToStartDate.Text = depositAccount.StartDate.ToString();
            lbl_ToEndDate.Text = depositAccount.EndDate.ToString();
        }

        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            CurrencyAmount amount = new CurrencyAmount() { Amount = 500000, Currency = "MKD" };
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            Dictionary<CreateAccountType, IAccount> accounts = this.CreateAccounts(CreateAccountType.LoanAccount | CreateAccountType.DepositAccount);
            foreach(var account in accounts)
            {
                account.Value.Status = AccountStatus.Active;
            }

            try
            {
                transactionProcessor.ProcessGroupTransactions(TransactionType.Debit, amount, accounts.Values.ToArray());
            }
            catch(AccountStatusInvalidException exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }

            DisplayLastTransactionDetails();
        }

        private void DisplayLastTransactionDetails()
        {
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            TransactionLogEntry lastLogEntry = transactionProcessor[transactionProcessor.TransactionCount - 1];

            if (transactionProcessor.TransactionCount > 0)
            {
                lblTotalTransactionCount.Text = "Total transactions: " + Convert.ToString(transactionProcessor.TransactionCount);
                lblTransactionType.Text = "Type: " + lastLogEntry.TransactionType.ToString();
                lblAmount.Text = "Amount: " + lastLogEntry.Amount.Amount.ToString() + " " + lastLogEntry.Amount.Currency;
                lblStatus.Text = "Status: " + lastLogEntry.Status.ToString();

                ShowAccountDetails(lastLogEntry.Accounts[0]);
                ShowAccountDetails_To(lastLogEntry.Accounts[1]);
            }            
        }

        private void OnBalanceChangedHandler(object sender, BalanceChangedEventArguments e)
        {
            Debug.WriteLine(e.Account.Number + " " + e.Change.Amount + " " + e.Change.Currency);
        }

        private Dictionary<CreateAccountType, IAccount> CreateAccounts(CreateAccountType accountTypesToCreate)
        {
            Dictionary<CreateAccountType, IAccount> accounts = new Dictionary<CreateAccountType, IAccount>();

            if ((accountTypesToCreate & CreateAccountType.TransactionAccount) == CreateAccountType.TransactionAccount)
                accounts[CreateAccountType.TransactionAccount] = this.CreateTransactionAccount();

            if ((accountTypesToCreate & CreateAccountType.DepositAccount) == CreateAccountType.DepositAccount)
                accounts[CreateAccountType.DepositAccount] = this.CreateDepositAccount();

            if ((accountTypesToCreate & CreateAccountType.LoanAccount) == CreateAccountType.LoanAccount)
                accounts[CreateAccountType.LoanAccount] = this.CreateLoanAccount();

            return accounts;
        }

        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            CurrencyAmount amount = new CurrencyAmount() {Amount = 15, Currency = "MKD" };
            IEnumerable<IAccount> accounts = new IAccount[] { this.CreateDepositAccount(), this.CreateLoanAccount() };

            foreach (var account in accounts)
                account.Status = AccountStatus.Active;
            ProcessorExtensions.ChargeProcessingFee(TransactionProcessor.GetTransactionProcessor(), amount, accounts);

            this.DisplayLastTransactionDetails();
        }
        
        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            Person person = this.CreatePerson();
            lblFirstName.Text = person.FirstName;
            lblLastName.Text = person.LastName;
            lblBirthDate.Text = person.BirthDate;
        }

        private Person CreatePerson() 
        {
            var transactionAccount = this.CreateTransactionAccount();
            var depositAccount = this.CreateDepositAccount();
            var loanAccount = this.CreateLoanAccount();
            var accounts = new List<Account> { depositAccount, loanAccount };
            Person person = new Person
            {
                FirstName = "Dragica",
                LastName = "Nikolova",
                BirthDate = "18.07.1992",
                TransactionAccount = transactionAccount,
                Accounts = accounts.ToArray(),
            };
            return person;
        }
    }
}
