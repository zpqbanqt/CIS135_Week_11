namespace CIS135_Weeks_8_9
{
    partial class ATMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAmount = new TextBox();
            btnDepositChecking = new Button();
            btnWithdrawChecking = new Button();
            btnDepositSavings = new Button();
            btnWithdrawSavings = new Button();
            btnTransferToChecking = new Button();
            btnTransferToSavings = new Button();
            btnRefresh = new Button();
            lblAmount = new Label();
            lblCheckingBalance = new Label();
            lblSavingsBalance = new Label();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(178, 59);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(108, 23);
            txtAmount.TabIndex = 1;
            // 
            // btnDepositChecking
            // 
            btnDepositChecking.Location = new Point(24, 166);
            btnDepositChecking.Name = "btnDepositChecking";
            btnDepositChecking.Size = new Size(132, 23);
            btnDepositChecking.TabIndex = 2;
            btnDepositChecking.Text = "Deposit Checking";
            btnDepositChecking.UseVisualStyleBackColor = true;
            btnDepositChecking.Click += btnDepositChecking_Click;
            // 
            // btnWithdrawChecking
            // 
            btnWithdrawChecking.Location = new Point(24, 127);
            btnWithdrawChecking.Name = "btnWithdrawChecking";
            btnWithdrawChecking.Size = new Size(132, 23);
            btnWithdrawChecking.TabIndex = 4;
            btnWithdrawChecking.Text = "Withdraw Checking";
            btnWithdrawChecking.UseVisualStyleBackColor = true;
            btnWithdrawChecking.Click += btnWithdrawChecking_Click;
            // 
            // btnDepositSavings
            // 
            btnDepositSavings.Location = new Point(178, 166);
            btnDepositSavings.Name = "btnDepositSavings";
            btnDepositSavings.Size = new Size(125, 23);
            btnDepositSavings.TabIndex = 5;
            btnDepositSavings.Text = "Deposit Savings";
            btnDepositSavings.UseVisualStyleBackColor = true;
            btnDepositSavings.Click += btnDepositSavings_Click;
            // 
            // btnWithdrawSavings
            // 
            btnWithdrawSavings.Location = new Point(179, 127);
            btnWithdrawSavings.Name = "btnWithdrawSavings";
            btnWithdrawSavings.Size = new Size(125, 23);
            btnWithdrawSavings.TabIndex = 6;
            btnWithdrawSavings.Text = "Withdraw Savings";
            btnWithdrawSavings.UseVisualStyleBackColor = true;
            btnWithdrawSavings.Click += btnWithdrawSavings_Click;
            // 
            // btnTransferToChecking
            // 
            btnTransferToChecking.Location = new Point(24, 207);
            btnTransferToChecking.Name = "btnTransferToChecking";
            btnTransferToChecking.Size = new Size(132, 23);
            btnTransferToChecking.TabIndex = 7;
            btnTransferToChecking.Text = "Transfer to Checking";
            btnTransferToChecking.UseVisualStyleBackColor = true;
            btnTransferToChecking.Click += btnTransferToChecking_Click;
            // 
            // btnTransferToSavings
            // 
            btnTransferToSavings.Location = new Point(178, 207);
            btnTransferToSavings.Name = "btnTransferToSavings";
            btnTransferToSavings.Size = new Size(125, 23);
            btnTransferToSavings.TabIndex = 8;
            btnTransferToSavings.Text = "Transfer to Savings";
            btnTransferToSavings.UseVisualStyleBackColor = true;
            btnTransferToSavings.Click += btnTransferToSavings_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(108, 249);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 23);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh Balances";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(75, 62);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(81, 15);
            lblAmount.TabIndex = 10;
            lblAmount.Text = "Enter Amount";
            // 
            // lblCheckingBalance
            // 
            lblCheckingBalance.AutoSize = true;
            lblCheckingBalance.Location = new Point(24, 99);
            lblCheckingBalance.Name = "lblCheckingBalance";
            lblCheckingBalance.Size = new Size(134, 15);
            lblCheckingBalance.TabIndex = 11;
            lblCheckingBalance.Text = "Checking Balance: $0.00";
            // 
            // lblSavingsBalance
            // 
            lblSavingsBalance.AutoSize = true;
            lblSavingsBalance.Location = new Point(180, 99);
            lblSavingsBalance.Name = "lblSavingsBalance";
            lblSavingsBalance.Size = new Size(124, 15);
            lblSavingsBalance.TabIndex = 12;
            lblSavingsBalance.Text = "Savings Balance: $0.00";
            // 
            // ATMForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 543);
            Controls.Add(lblSavingsBalance);
            Controls.Add(lblCheckingBalance);
            Controls.Add(lblAmount);
            Controls.Add(btnRefresh);
            Controls.Add(btnTransferToSavings);
            Controls.Add(btnTransferToChecking);
            Controls.Add(btnWithdrawSavings);
            Controls.Add(btnDepositSavings);
            Controls.Add(btnWithdrawChecking);
            Controls.Add(btnDepositChecking);
            Controls.Add(txtAmount);
            Name = "ATMForm";
            Text = "ATM Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCheckingBalance;
        private Label lblSavingsBalance;
        private Button btnDepositChecking;
        private Button btnWithdrawChecking;
        private Button btnDepositSavings;
        private Button btnWithdrawSavings;
        private Button btnTransferToChecking;
        private Button btnTransferToSavings;
        private Button btnRefresh;
        private Label lblAmount;
       private TextBox txtAmount;
    }
}