namespace CIS135_Weeks_8_9
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCustomerNumber = new Label();
            txtCustomerNumber = new TextBox();
            lblPin = new Label();
            txtPin = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblCustomerNumber
            // 
            lblCustomerNumber.AutoSize = true;
            lblCustomerNumber.Location = new Point(40, 42);
            lblCustomerNumber.Margin = new Padding(4, 0, 4, 0);
            lblCustomerNumber.Name = "lblCustomerNumber";
            lblCustomerNumber.Size = new Size(106, 15);
            lblCustomerNumber.TabIndex = 0;
            lblCustomerNumber.Text = "Customer Number";
            lblCustomerNumber.Click += lblCustomerNumber_Click;
            // 
            // txtCustomerNumber
            // 
            txtCustomerNumber.Location = new Point(187, 38);
            txtCustomerNumber.Margin = new Padding(4, 3, 4, 3);
            txtCustomerNumber.Name = "txtCustomerNumber";
            txtCustomerNumber.Size = new Size(116, 23);
            txtCustomerNumber.TabIndex = 1;
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(40, 88);
            lblPin.Margin = new Padding(4, 0, 4, 0);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(26, 15);
            lblPin.TabIndex = 2;
            lblPin.Text = "PIN";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(187, 84);
            txtPin.Margin = new Padding(4, 3, 4, 3);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(116, 23);
            txtPin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(121, 140);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 219);
            Controls.Add(btnLogin);
            Controls.Add(txtPin);
            Controls.Add(lblPin);
            Controls.Add(txtCustomerNumber);
            Controls.Add(lblCustomerNumber);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "ATM Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnLogin;
    }
}