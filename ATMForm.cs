using System;
using System.Windows.Forms;

namespace CIS135_Weeks_8_9
{
    /* Main ATM form that allows the logged-in customer to
       view balances, deposit, withdraw, transfer, and refresh balances */

    public partial class ATMForm : Form
    {
        /* Stores the customer who successfully logged in */

        private BankCustomer currentCustomer;

        /* Allows this form to update account balances in the database */

        private SQLHelper sqlHelper = new SQLHelper();

        public ATMForm()
        {
            InitializeComponent();
        }

        /* Constructor receives the logged-in customer from the login form */
        public ATMForm(BankCustomer customer)
        {
            InitializeComponent();

            currentCustomer = customer;

            /* Display current account balances when the ATM form opens */

            lblCheckingBalance.Text =
                "Checking Balance: $" + currentCustomer.Checking.Balance;

            lblSavingsBalance.Text =
                "Savings Balance: $" + currentCustomer.Savings.Balance;
        }

        /* Deposits money into the customer's checking account */
        private void btnDepositChecking_Click(object sender, EventArgs e)
        {
            decimal amount;

            /* Validate that the user entered a valid decimal amount */

            if (decimal.TryParse(txtAmount.Text, out amount))
            {

                currentCustomer.Checking.Balance += amount;

                /* Saves the updated checking balance to the database */

                sqlHelper.UpdateAccount(currentCustomer.Checking);

                lblCheckingBalance.Text =
                    "Checking Balance: $" + currentCustomer.Checking.Balance;

                MessageBox.Show("Deposit successful!");
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        /* Deposits money into the customer's savings account */
        private void btnDepositSavings_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtAmount.Text, out amount))
            {
                currentCustomer.Savings.Balance += amount;

                sqlHelper.UpdateAccount(currentCustomer.Savings);

                lblSavingsBalance.Text =
                    "Savings Balance: $" + currentCustomer.Savings.Balance;

                MessageBox.Show("Savings deposit successful!");
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        /* Withdraws money from the checking account if enough funds exist */
        private void btnWithdrawChecking_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtAmount.Text, out amount))
            {
                if (currentCustomer.Checking.Balance >= amount)
                {
                    currentCustomer.Checking.Balance -= amount;

                    sqlHelper.UpdateAccount(currentCustomer.Checking);

                    lblCheckingBalance.Text =
                        "Checking Balance: $" + currentCustomer.Checking.Balance;

                    MessageBox.Show("Withdrawal successful!");
                }
                else
                {
                    MessageBox.Show("Insufficient funds.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        /* Withdraws money from the savings account if enough funds exist */
        private void btnWithdrawSavings_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtAmount.Text, out amount))
            {
                if (currentCustomer.Savings.Balance >= amount)
                {
                    currentCustomer.Savings.Balance -= amount;

                    sqlHelper.UpdateAccount(currentCustomer.Savings);

                    lblSavingsBalance.Text =
                        "Savings Balance: $" + currentCustomer.Savings.Balance;

                    MessageBox.Show("Savings withdrawal successful!");
                }
                else
                {
                    MessageBox.Show("Insufficient savings funds.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        /* Transfers money from savings into checking */
        private void btnTransferToChecking_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtAmount.Text, out amount))
            {
                if (currentCustomer.Savings.Balance >= amount)
                {
                    currentCustomer.Savings.Balance -= amount;
                    currentCustomer.Checking.Balance += amount;

                    /* Save both updated balances to the database */

                    sqlHelper.UpdateAccount(currentCustomer.Savings);
                    sqlHelper.UpdateAccount(currentCustomer.Checking);

                    lblSavingsBalance.Text =
                        "Savings Balance: $" + currentCustomer.Savings.Balance;

                    lblCheckingBalance.Text =
                        "Checking Balance: $" + currentCustomer.Checking.Balance;

                    MessageBox.Show("Transfer successful!");
                }
                else
                {
                    MessageBox.Show("Insufficient savings funds.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        /* Transfers money from checking into savings */
        private void btnTransferToSavings_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtAmount.Text, out amount))
            {
                if (currentCustomer.Checking.Balance >= amount)
                {
                    currentCustomer.Checking.Balance -= amount;
                    currentCustomer.Savings.Balance += amount;

                    /* Save both updated balances to the database */

                    sqlHelper.UpdateAccount(currentCustomer.Checking);
                    sqlHelper.UpdateAccount(currentCustomer.Savings);

                    lblCheckingBalance.Text =
                        "Checking Balance: $" + currentCustomer.Checking.Balance;

                    lblSavingsBalance.Text =
                        "Savings Balance: $" + currentCustomer.Savings.Balance;

                    MessageBox.Show("Transfer successful!");
                }
                else
                {
                    MessageBox.Show("Insufficient checking funds.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        /* Refreshes the balance labels using the current customer information */
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblCheckingBalance.Text =
                "Checking Balance: $" + currentCustomer.Checking.Balance;

            lblSavingsBalance.Text =
                "Savings Balance: $" + currentCustomer.Savings.Balance;

            MessageBox.Show("Balances refreshed!");
        }
    }
}