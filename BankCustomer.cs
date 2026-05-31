namespace CIS135_Weeks_8_9
{
    /* Represents a bank customer and their accounts */
    public class BankCustomer
    {

        /* Unique customer number used for login */
        public int CustomerNumber { get; set; }

        /* Customer PIN used for authentication */
        public int Pin { get; set; }

        /* Customer checking account information */
        public CheckingAccount Checking { get; set; }

        /* Customer savings account information */
        public SavingsAccount Savings { get; set; }

        /* Constructor used when creating a customer object for login */
        public BankCustomer(int customerNumber, int pin)
        {
            CustomerNumber = customerNumber;
            Pin = pin;
        }

        /* Constructor used after a successful login when account
           information has been retrieved from the database */
        public BankCustomer(
            int customerNumber,
            int pin,
            CheckingAccount checking,
            SavingsAccount savings)
        {
            CustomerNumber = customerNumber;
            Pin = pin;
            Checking = checking;
            Savings = savings;
        }
    }
}