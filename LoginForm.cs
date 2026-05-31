using System;
using System.Windows.Forms;

namespace CIS135_Weeks_8_9
{
    /* Login form used to verify customer credentials before opening the ATM form */
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /* Runs when the customer clicks the Login button */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                /* Create SQLHelper object to communicate with the database */

                var sql = new SQLHelper();

                /* Create a customer object using the entered customer number and PIN */

                var customer = new BankCustomer(
                    Convert.ToInt32(txtCustomerNumber.Text),
                    Convert.ToInt32(txtPin.Text));

                /* Check the entered login information against the database */

                BankCustomer loggedInCustomer =
                    sql.Login(customer);

                /* If login is successful, open the ATM form */

                if (loggedInCustomer != null)
                {
                    MessageBox.Show("Login Successful!");

                var atmForm = new ATMForm(loggedInCustomer);
                    atmForm.Show();

                    /* Hide the login form after successful login */

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
            catch (Exception ex)
            {

                /* Displays an error message if the login input or database query fails */

                MessageBox.Show(ex.Message);
            }
        }

        private void lblCustomerNumber_Click(object sender, EventArgs e)
        {

        }
    }
}