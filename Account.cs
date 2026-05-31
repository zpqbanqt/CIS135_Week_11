namespace CIS135_Weeks_8_9
{
    /* Base account class used by checking and savings accounts
       to store common account information and behaviors */
    public class Account
    {
        /* Unique account number used to identify the account */
        public int AccountNumber { get; set; }

        /* Current account balance */
        public decimal Balance { get; set; }

        /* Constructor used to create an account with an account number and balance */
        public Account(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        /* Adds money to the account balance */
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        /* Removes money from the account if sufficient funds exist */
        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }

            /* Withdrawal fails if the account does not have enough funds */
            return false;
        }
    }
}