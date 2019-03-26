namespace ATMProject
{
    partial class MainScreenLogin
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
            this.pinNumberLbl = new System.Windows.Forms.Label();
            this.accountNumberLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.pinNumberTxtbox = new System.Windows.Forms.TextBox();
            this.accountNumberTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.mainLbl.Location = new System.Drawing.Point(224, 85);
            this.mainLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(477, 58);
            this.mainLbl.TabIndex = 12;
            this.mainLbl.Text = "ATM System - Login";
            // 
            // pinNumberLbl
            // 
            this.pinNumberLbl.AutoSize = true;
            this.pinNumberLbl.Location = new System.Drawing.Point(359, 300);
            this.pinNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pinNumberLbl.Name = "pinNumberLbl";
            this.pinNumberLbl.Size = new System.Drawing.Size(88, 17);
            this.pinNumberLbl.TabIndex = 23;
            this.pinNumberLbl.Text = "PIN Number:";
            // 
            // accountNumberLbl
            // 
            this.accountNumberLbl.AutoSize = true;
            this.accountNumberLbl.Location = new System.Drawing.Point(359, 241);
            this.accountNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNumberLbl.Name = "accountNumberLbl";
            this.accountNumberLbl.Size = new System.Drawing.Size(117, 17);
            this.accountNumberLbl.TabIndex = 22;
            this.accountNumberLbl.Text = "Account Number:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(467, 373);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(100, 28);
            this.submitBtn.TabIndex = 21;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // pinNumberTxtbox
            // 
            this.pinNumberTxtbox.Location = new System.Drawing.Point(496, 297);
            this.pinNumberTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pinNumberTxtbox.Name = "pinNumberTxtbox";
            this.pinNumberTxtbox.PasswordChar = '*';
            this.pinNumberTxtbox.Size = new System.Drawing.Size(203, 22);
            this.pinNumberTxtbox.TabIndex = 20;
            // 
            // accountNumberTxtbox
            // 
            this.accountNumberTxtbox.Location = new System.Drawing.Point(496, 238);
            this.accountNumberTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountNumberTxtbox.Name = "accountNumberTxtbox";
            this.accountNumberTxtbox.Size = new System.Drawing.Size(203, 22);
            this.accountNumberTxtbox.TabIndex = 19;
            // 
            // MainScreenLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pinNumberLbl);
            this.Controls.Add(this.accountNumberLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.pinNumberTxtbox);
            this.Controls.Add(this.accountNumberTxtbox);
            this.Controls.Add(this.mainLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainScreenLogin";
            this.Text = "ATM Main Screen";
            this.Load += new System.EventHandler(this.MainScreenLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.Label pinNumberLbl;
        private System.Windows.Forms.Label accountNumberLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox pinNumberTxtbox;
        private System.Windows.Forms.TextBox accountNumberTxtbox;
    }
}