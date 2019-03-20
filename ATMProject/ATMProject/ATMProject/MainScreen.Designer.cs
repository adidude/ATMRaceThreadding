namespace ATMProject
{
    partial class MainScreen
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
            this.mainLbl = new System.Windows.Forms.Label();
            this.accountBalanceBtn = new System.Windows.Forms.Button();
            this.withdrawATMBtn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pinNumberLbl = new System.Windows.Forms.Label();
            this.accountNumberLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.pinNumberTxtbox = new System.Windows.Forms.TextBox();
            this.accountNumberTxtbox = new System.Windows.Forms.TextBox();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.accountBalanceBtn2 = new System.Windows.Forms.Button();
            this.withdrawATMBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.mainLbl.Location = new System.Drawing.Point(168, 69);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(381, 46);
            this.mainLbl.TabIndex = 12;
            this.mainLbl.Text = "ATM System - Login";
            // 
            // accountBalanceBtn
            // 
            this.accountBalanceBtn.Location = new System.Drawing.Point(90, 264);
            this.accountBalanceBtn.Name = "accountBalanceBtn";
            this.accountBalanceBtn.Size = new System.Drawing.Size(143, 51);
            this.accountBalanceBtn.TabIndex = 11;
            this.accountBalanceBtn.Text = "Check Account Balance ATM";
            this.accountBalanceBtn.UseVisualStyleBackColor = true;
            // 
            // withdrawATMBtn
            // 
            this.withdrawATMBtn.Location = new System.Drawing.Point(90, 176);
            this.withdrawATMBtn.Name = "withdrawATMBtn";
            this.withdrawATMBtn.Size = new System.Drawing.Size(143, 52);
            this.withdrawATMBtn.TabIndex = 10;
            this.withdrawATMBtn.Text = "Withdraw from ATM";
            this.withdrawATMBtn.UseVisualStyleBackColor = true;
            this.withdrawATMBtn.Click += new System.EventHandler(this.withdrawATMBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(90, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 43);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pinNumberLbl
            // 
            this.pinNumberLbl.AutoSize = true;
            this.pinNumberLbl.Location = new System.Drawing.Point(269, 244);
            this.pinNumberLbl.Name = "pinNumberLbl";
            this.pinNumberLbl.Size = new System.Drawing.Size(68, 13);
            this.pinNumberLbl.TabIndex = 23;
            this.pinNumberLbl.Text = "PIN Number:";
            // 
            // accountNumberLbl
            // 
            this.accountNumberLbl.AutoSize = true;
            this.accountNumberLbl.Location = new System.Drawing.Point(269, 196);
            this.accountNumberLbl.Name = "accountNumberLbl";
            this.accountNumberLbl.Size = new System.Drawing.Size(90, 13);
            this.accountNumberLbl.TabIndex = 22;
            this.accountNumberLbl.Text = "Account Number:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(350, 303);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 21;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // pinNumberTxtbox
            // 
            this.pinNumberTxtbox.Location = new System.Drawing.Point(372, 241);
            this.pinNumberTxtbox.Name = "pinNumberTxtbox";
            this.pinNumberTxtbox.PasswordChar = '*';
            this.pinNumberTxtbox.Size = new System.Drawing.Size(153, 20);
            this.pinNumberTxtbox.TabIndex = 20;
            this.pinNumberTxtbox.TextChanged += new System.EventHandler(this.pinNumberTxtbox_TextChanged);
            // 
            // accountNumberTxtbox
            // 
            this.accountNumberTxtbox.Location = new System.Drawing.Point(372, 193);
            this.accountNumberTxtbox.Name = "accountNumberTxtbox";
            this.accountNumberTxtbox.Size = new System.Drawing.Size(153, 20);
            this.accountNumberTxtbox.TabIndex = 19;
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(588, 348);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(143, 43);
            this.btnExit2.TabIndex = 26;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // accountBalanceBtn2
            // 
            this.accountBalanceBtn2.Location = new System.Drawing.Point(588, 264);
            this.accountBalanceBtn2.Name = "accountBalanceBtn2";
            this.accountBalanceBtn2.Size = new System.Drawing.Size(143, 51);
            this.accountBalanceBtn2.TabIndex = 25;
            this.accountBalanceBtn2.Text = "Check Account Balance ATM";
            this.accountBalanceBtn2.UseVisualStyleBackColor = true;
            // 
            // withdrawATMBtn2
            // 
            this.withdrawATMBtn2.Location = new System.Drawing.Point(588, 176);
            this.withdrawATMBtn2.Name = "withdrawATMBtn2";
            this.withdrawATMBtn2.Size = new System.Drawing.Size(143, 52);
            this.withdrawATMBtn2.TabIndex = 24;
            this.withdrawATMBtn2.Text = "Withdraw from ATM";
            this.withdrawATMBtn2.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.accountBalanceBtn2);
            this.Controls.Add(this.withdrawATMBtn2);
            this.Controls.Add(this.pinNumberLbl);
            this.Controls.Add(this.accountNumberLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.pinNumberTxtbox);
            this.Controls.Add(this.accountNumberTxtbox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.mainLbl);
            this.Controls.Add(this.accountBalanceBtn);
            this.Controls.Add(this.withdrawATMBtn);
            this.Name = "MainScreen";
            this.Text = "ATM Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.Button accountBalanceBtn;
        private System.Windows.Forms.Button withdrawATMBtn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label pinNumberLbl;
        private System.Windows.Forms.Label accountNumberLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox pinNumberTxtbox;
        private System.Windows.Forms.TextBox accountNumberTxtbox;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button accountBalanceBtn2;
        private System.Windows.Forms.Button withdrawATMBtn2;
    }
}