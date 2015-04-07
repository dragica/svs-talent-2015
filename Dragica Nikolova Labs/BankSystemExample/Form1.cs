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
            cbStartDate.SelectedIndex = 0;
            cbEndDate.SelectedIndex = 0;

        }

        TransactionAccount transactionAccount;
        DepositAccount depositAccount;
                
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {            
            //Parse values for Limit and Currency from TextBoxes.
            decimal limitAmount = Decimal.Parse(txtLimit.Text);
            string currency = txtCurrency.Text;

            //And create new TransactionAccount instance.
            transactionAccount = new TransactionAccount(limitAmount, currency);

            //Display all TransactionAccount details.
            ShowAccountDetails(transactionAccount);
                        
        }  
    
        private void ShowAccountDetails(IAccount acc)
        {
            Account account = (Account)acc;
            //Fill in labels common for account.
            lblId.Text = Convert.ToString(account.Id);
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            CurrencyAmount b = account.Balance;
            string balance = Convert.ToString(b.Amount) + " " + b.Currency;
            lblBalance.Text = balance;            

            //And check if account is of type TransactionAccount. If it is display TransactionAccount details.
            if(account is TransactionAccount) ShowTransactionAccountDetails((ITransactionAccount)account);

            //Otherwise display DepositAccount details.
            else  ShowDepositAccountDetails((IDepositAccount)account);            
        }

        private void ShowTransactionAccountDetails(ITransactionAccount account)
        {
            //Convert account back to TransactionAccount.
            TransactionAccount transactAccount = (TransactionAccount)account;
            CurrencyAmount currencyAmount = transactAccount.Limit;

            //And fill in labels with details for TransacionAccount.
            lblLimitCurrency.Text = Convert.ToString(currencyAmount.Amount) + " " + currencyAmount.Currency;
        }

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            //Create neccessary members for DepositAccount constructor and create new instance
            int period = Int32.Parse(txtPeriod.Text);
            UnitOfTime periodUnitOfTime = (UnitOfTime)Enum.Parse(typeof(UnitOfTime), cbStartDate.Text);
            TimePeriod depositPeriod = new TimePeriod(){Period = period, Unit = periodUnitOfTime};
            decimal percent = Convert.ToDecimal(txtPercent.Text);
            UnitOfTime percentUnitOfTime = (UnitOfTime)Enum.Parse(typeof(UnitOfTime), cbEndDate.Text);
            InterestRate interestRate = new InterestRate() {Percent = percent, Unit = percentUnitOfTime};
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            if (transactionAccount != null)
            {
                depositAccount = new DepositAccount(depositPeriod, interestRate, startDate, endDate, transactionAccount, transactionAccount.Currency);
            }            

            //Display DepositAccount specific attributes.
            ShowAccountDetails(depositAccount);
        }

        private void ShowDepositAccountDetails(IDepositAccount account)
        {
            //Convert account back to DepositAccount and extract DepositAccount specific attributes.
            DepositAccount depositAccount = (DepositAccount)account;
            TimePeriod timePeriod = depositAccount.Period;
            int period = timePeriod.Period;
            UnitOfTime periodUnitOfTime = timePeriod.Unit;
            InterestRate interestRate = depositAccount.Interest;
            decimal percent = interestRate.Percent;
            UnitOfTime percentUnitOfTime = interestRate.Unit;
            string startDate = depositAccount.StartDate.ToString();
            string endDate = depositAccount.EndDate.ToString();

            //Fill in labels with details for DepositAccount.
            lblPeriodUnitOfTime.Text = Convert.ToString(period) + " " + periodUnitOfTime.ToString();
            lblPercentUnitOfTime.Text = Convert.ToString(percent) + " " + Convert.ToString(percentUnitOfTime);
            lblStart.Text = startDate;
            lblEnd.Text = endDate;

            //Display descriptive labels
            lblDisplayPeriod.Visible = true;
            lblDisplayInterest.Visible = true;
            lblDisplayStart.Visible = true;
            lblDisplayEnd.Visible = true;
        }

        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            CurrencyAmount amount = new CurrencyAmount() { Amount = 20000, Currency = "MKD"};
            ITransactionAccount transactAccount = transactionAccount;
            IDepositAccount depAccount = depositAccount;
            ILoanAccount loanAccount = new LoanAccount(depositAccount.Period, depositAccount.Interest, depositAccount.StartDate, depositAccount.EndDate, depositAccount.TransactionAccount, depositAccount.Currency);

            //Create a transactionProcessor and transfer a transaction
            ITransactionProcessor transactionProcessor = new TransactionProcessor();
            transactionProcessor.ProcessTransaction(TransactionType.Transfer, loanAccount, depAccount, amount);

            //Fill in Account common labels
            lbl_ToId.Text = Convert.ToString(depAccount.Id);
            lbl_ToNumber.Text = depAccount.Number;
            lbl_ToCurrency.Text = depAccount.Currency;
            CurrencyAmount b = depAccount.Balance;
            string balance = Convert.ToString(b.Amount) + " " + b.Currency;
            lbl_ToBalance.Text = balance;            

            //Fill in TransactionAccount common labels
            CurrencyAmount currencyAmount = depAccount.TransactionAccount.Limit;
            lbl_ToLimit.Text = Convert.ToString(currencyAmount.Amount) + " " + currencyAmount.Currency;

            //Fill in DepositAccount common labels
            TimePeriod timePeriod = depAccount.Period;
            int period = timePeriod.Period;
            UnitOfTime periodUnitOfTime = timePeriod.Unit;
            InterestRate interestRate = depAccount.Interest;
            decimal percent = interestRate.Percent;
            UnitOfTime percentUnitOfTime = interestRate.Unit;
            string startDate = depAccount.StartDate.ToString();
            string endDate = depAccount.EndDate.ToString();
            
            lbl_ToPeriod.Text = Convert.ToString(period) + " " + periodUnitOfTime.ToString();
            lbl_ToInterest.Text = Convert.ToString(percent) + " " + Convert.ToString(percentUnitOfTime);
            lbl_ToStartDate.Text = startDate;
            lbl_ToEndDate.Text = endDate;

            //Display descriptive labels
            lbl_DisplayToId.Visible = true;
            lbl_DisplayToNumber.Visible = true;
            lbl_DisplayToCurrency.Visible = true;
            lbl_DisplayToBalance.Visible = true;
            lbl_DisplayToLimit.Visible = true;
            lbl_DisplayToPeriod.Visible = true;
            lbl_DisplayToInterest.Visible = true;
            lbl_DisplayToStartDate.Visible = true;
            lbl_DisplayToEndDate.Visible = true;

        }
    }
}
