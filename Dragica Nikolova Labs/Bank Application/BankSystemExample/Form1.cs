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

        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            //Parse values for Limit and Currency from TextBoxes.
            decimal limitAmount = Decimal.Parse(txtLimit.Text);
            string currency = txtCurrency.Text;

            //And create new TransactionAccount instance.
            TransactionAccount transactionAccount = new TransactionAccount(limitAmount, currency);

            //Display all TransactionAccount details.
            this.ShowAccountDetails(transactionAccount);
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
            lblDetails.Visible = true;

            //Check if this is a TransactionAccount and if this is true populate the TransactionAccount specific label.
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
            decimal limitAmount = Decimal.Parse(txtLimit.Text);
            string currency = txtCurrency.Text;
            TransactionAccount transactionAccount = new TransactionAccount(limitAmount, currency);

            //And create new instance.
            DepositAccount depositAccount = new DepositAccount(depositPeriod, interestRate, startDate, endDate, transactionAccount, currency);
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
            decimal limitAmount = Decimal.Parse(txtLimit.Text);
            string currency = txtCurrency.Text;
            TransactionAccount transactionAccount = new TransactionAccount(limitAmount, currency);

            //And create new instance.
            LoanAccount loanAccount = new LoanAccount(depositPeriod, interestRate, startDate, endDate, transactionAccount, currency);
            return loanAccount;
        }

        private void ShowDepositAccountDetails(IDepositAccount account)
        {
            lblPeriodUnitOfTime.Text = Convert.ToString(account.Period.Period) + " " + account.Period.Unit.ToString();
            lblPercentUnitOfTime.Text = Convert.ToString(account.Interest.Percent) + " " + Convert.ToString(account.Interest.Unit);
            lblStartDate.Text = account.StartDate.ToString();
            lblEndDate.Text = account.EndDate.ToString();
            lblLimitCurrency.Text = Convert.ToString(account.TransactionAccount.Limit.Amount) + " " + account.TransactionAccount.Limit.Currency;

        }

        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            CurrencyAmount amount = new CurrencyAmount() { Amount = 20000, Currency = "MKD" };
            IDepositAccount depositAccount = CreateDepositAccount();
            ILoanAccount loanAccount = CreateLoanAccount();

            //Create a transactionProcessor and make a transfer.
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            transactionProcessor.ProcessTransaction(TransactionType.Transfer, loanAccount, depositAccount, amount);

            this.ShowAccountDetails(depositAccount);
            //this.ShowAccountDetails_To(loanAccount);   
            this.DisplayLastTransactionDetails();
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
            lbl_ToLimit.Text = Convert.ToString(depositAccount.TransactionAccount.Limit.Amount) + " " + depositAccount.TransactionAccount.Limit.Currency;           
            lbl_ToPeriod.Text = Convert.ToString(depositAccount.Period.Period) + " " + depositAccount.Period.Unit.ToString();
            lbl_ToInterest.Text = Convert.ToString(depositAccount.Interest.Percent) + " " + Convert.ToString(depositAccount.Interest.Unit);
            lbl_ToStartDate.Text = depositAccount.StartDate.ToString();
            lbl_ToEndDate.Text = depositAccount.EndDate.ToString();
        }

        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            CurrencyAmount amount = new CurrencyAmount() { Amount = 2000, Currency = "MKD" };
            IAccount[] accountArray = new IAccount[2];
            IDepositAccount depositAccount = this.CreateDepositAccount();
            ILoanAccount loanAccount = this.CreateLoanAccount();
            accountArray[0] = depositAccount;
            accountArray[1] = loanAccount;
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor(); ;
            transactionProcessor.ProcessGroupTransactions(TransactionType.Debit, amount, accountArray);

            ShowAccountDetails(loanAccount);
            //ShowAccountDetails_To(loanAccount);
            DisplayLastTransactionDetails();
        }

        private void DisplayLastTransactionDetails()
        {
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            //TransactionLogEntry lastLogEntry = transactionProcessor.LastTransaction;
            TransactionLogEntry lastLogEntry = transactionProcessor[transactionProcessor.TransactionCount - 1];
            int totalTransactions = transactionProcessor.TransactionCount;
            lblTotalTransactionCount.Text = Convert.ToString(totalTransactions);
            lblTransactionType.Text = lastLogEntry.TransactionType.ToString();
            lblAmount.Text = lastLogEntry.Amount.Amount.ToString() + " " + lastLogEntry.Amount.Currency;
            lblStatus.Text = lastLogEntry.Status.ToString();
            ShowAccountDetails_To(lastLogEntry.Accounts);


        }
    }
}
