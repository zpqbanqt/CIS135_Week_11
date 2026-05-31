using System.Security.Principal;

namespace CIS135_Weeks_8_9
{
    /* Checking account inherits from Account */
    public class CheckingAccount : Account
    {
        /* Creates a checking account with an account number and balance */
        public CheckingAccount(int accountNumber, decimal balance)
            : base(accountNumber, balance)
        {
        }

        /* Attempts to withdraw money from the checking account.
           If the checking balance is insufficient, funds can be
           automatically taken from the savings account.*/
        public bool Withdraw(decimal amount, SavingsAccount savings)
        {
            /* Standard withdrawal when sufficient funds exist */

            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }

            /* Calculate additional funds needed from savings */

            decimal needed = amount - Balance;

            /* Use savings account to cover the remaining amount */

            if (savings.Balance >= needed)
            {
                savings.Balance -= needed;
                Balance = 0;
                return true;
            }

            /* Withdrawal fails when combined funds are insufficient */

            return false;
        }
    }
}