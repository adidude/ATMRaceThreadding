namespace ATMProject
{
    partial class LoginScreen
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
            this.loginLbl = new System.Windows.Forms.Label();
            this.accountNumberTxtbox = new System.Windows.Forms.TextBox();
            this.pinNumberTxtbox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.accountNumberLbl = new System.Windows.Forms.Label();
            this.pinNumberLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.loginLbl.Location = new System.Drawing.Point(190, 82);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(381, 46);
            this.loginLbl.TabIndex = 13;
            this.loginLbl.Text = "ATM System - Login";
            // 
            // accountNumberTxtbox
            // 
            this.accountNumberTxtbox.Location = new System.Drawing.Point(363, 198);
            this.accountNumberTxtbox.Name = "accountNumberTxtbox";
            this.accountNumberTxtbox.Size = new System.Drawing.Size(153, 20);
            this.accountNumberTxtbox.TabIndex = 14;
            // 
            // pinNumberTxtbox
            // 
            this.pinNumberTxtbox.Location = new System.Drawing.Point(363, 246);
            this.pinNumberTxtbox.Name = "pinNumberTxtbox";
            this.pinNumberTxtbox.PasswordChar = '*';
            this.pinNumberTxtbox.Size = new System.Drawing.Size(153, 20);
            this.pinNumberTxtbox.TabIndex = 15;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(341, 308);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // accountNumberLbl
            // 
            this.accountNumberLbl.AutoSize = true;
            this.accountNumberLbl.Location = new System.Drawing.Point(260, 201);
            this.accountNumberLbl.Name = "accountNumberLbl";
            this.accountNumberLbl.Size = new System.Drawing.Size(90, 13);
            this.accountNumberLbl.TabIndex = 17;
            this.accountNumberLbl.Text = "Account Number:";
            // 
            // pinNumberLbl
            // 
            this.pinNumberLbl.AutoSize = true;
            this.pinNumberLbl.Location = new System.Drawing.Point(260, 249);
            this.pinNumberLbl.Name = "pinNumberLbl";
            this.pinNumberLbl.Size = new System.Drawing.Size(68, 13);
            this.pinNumberLbl.TabIndex = 18;
            this.pinNumberLbl.Text = "PIN Number:";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pinNumberLbl);
            this.Controls.Add(this.accountNumberLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.pinNumberTxtbox);
            this.Controls.Add(this.accountNumberTxtbox);
            this.Controls.Add(this.loginLbl);
            this.Name = "LoginScreen";
            this.Text = "ATM Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox accountNumberTxtbox;
        private System.Windows.Forms.TextBox pinNumberTxtbox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label accountNumberLbl;
        private System.Windows.Forms.Label pinNumberLbl;
    }
}

