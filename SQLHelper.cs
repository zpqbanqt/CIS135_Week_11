using System;
using System.Data.SqlClient;

namespace CIS135_Weeks_8_9
{
    /* Handles all database operations */
    public class SQLHelper
    {
     /* Used to connect to the ATM database */
      private string connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;
         AttachDbFilename=C:\Users\qbanq\OneDrive\Desktop\CIS135\CIS135_Weeks_8_9\ATMDatabase.mdf;
         Integrated Security=True;
         Connect Timeout=30";

        /* Validates customer login information */

        public BankCustomer Login(BankCustomer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                /* Search for a customer with the entered customer number and PIN */

                string query =
                    "SELECT * FROM [dbo].[BankCustomer] " +
                    "WHERE Customer_Number = @CustomerNumber " +
                    "AND PIN = @PIN";

                SqlCommand command = new SqlCommand(query, connection);

                /* Pass login values securely through parameters */

                command.Parameters.AddWithValue("@CustomerNumber", customer.CustomerNumber);
                command.Parameters.AddWithValue("@PIN", customer.Pin);

                using (SqlDataReader reader = command.ExecuteReader())

                {
                    /* If a matching customer is found, load account information */

                    if (reader.Read())
                    {
                        int checkingNumber =
                            Convert.ToInt32(reader["Checking_Account_Number"]);

                        int savingsNumber =
                            Convert.ToInt32(reader["Savings_Account_Number"]);

                        reader.Close();

                        /* Retrieve account details from the Account table */

                        CheckingAccount checking =
                            GetCheckingAccount(checkingNumber);

                        SavingsAccount savings =
                            GetSavingsAccount(savingsNumber);

                        return new BankCustomer(
                            customer.CustomerNumber,
                            customer.Pin,
                            checking,
                            savings);
                    }
                }
                /* Return null if login fails */

                return null;
            }
        }

        /* Retrieves checking account information from the database */

        public CheckingAccount GetCheckingAccount(
            int accountNumber)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                /* Find the matching account number */

                string query =
                    "SELECT * FROM [dbo].[Account] " +
                    "WHERE Account_Number = @AccountNumber";

                SqlCommand command =
                    new SqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@AccountNumber",
                    accountNumber);

                SqlDataReader reader =
                    command.ExecuteReader();

                if (reader.Read())
                {
                    decimal balance =
                        Convert.ToDecimal(
                            reader["Balance"]);

                    /* Create and return a CheckingAccount object */

                    return new CheckingAccount(
                        accountNumber,
                        balance);
                }

                return null;
            }
        }

        /* Retrieves savings account information from the database */

        public SavingsAccount GetSavingsAccount(
            int accountNumber)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                /* Find the matching account number */

                string query =
                    "SELECT * FROM [dbo].[Account] " +
                    "WHERE Account_Number = @AccountNumber";

                SqlCommand command =
                    new SqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@AccountNumber",
                    accountNumber);

                SqlDataReader reader =
                    command.ExecuteReader();

                if (reader.Read())
                {
                    decimal balance =
                        Convert.ToDecimal(
                            reader["Balance"]);

                    /* Create and return a SavingsAccount object */

                    return new SavingsAccount(
                        accountNumber,
                        balance);
                }

                return null;
            }

        }

        /* Updates the account balance in the database after deposits,
           withdrawals, or transfers */

        public void UpdateAccount(Account account)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query =
                        "UPDATE [dbo].[Account] " +
                        "SET Balance = @Balance " +
                        "WHERE Account_Number = @AccountNumber";

                    SqlCommand command =
                        new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Balance", account.Balance);
                    command.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Database update failed: " + ex.Message);
            }
        }
    }
}