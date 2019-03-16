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
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.mainLbl.Location = new System.Drawing.Point(109, 69);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(589, 46);
            this.mainLbl.TabIndex = 12;
            this.mainLbl.Text = "ATM System - Choose option(s)";
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
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(90, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 43);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}