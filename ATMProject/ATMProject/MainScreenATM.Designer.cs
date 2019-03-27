namespace ATMProject
{
    partial class MainScreenATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenATM));
            this.mainLbl = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.customBtn = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.accountBalanceBtn = new System.Windows.Forms.Button();
            this.withdrawATMBtn = new System.Windows.Forms.Button();
            this.gifRenderer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gifRenderer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.mainLbl.Location = new System.Drawing.Point(115, 63);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(597, 46);
            this.mainLbl.TabIndex = 50;
            this.mainLbl.Text = "ATM System - Choose Option(s)";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(346, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // customBtn
            // 
            this.customBtn.Location = new System.Drawing.Point(391, 289);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(72, 52);
            this.customBtn.TabIndex = 68;
            this.customBtn.Text = "Custom amount";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(303, 289);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(72, 52);
            this.btn500.TabIndex = 67;
            this.btn500.Text = "£500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(391, 223);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(72, 52);
            this.btn100.TabIndex = 66;
            this.btn100.Text = "£100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn40
            // 
            this.btn40.Location = new System.Drawing.Point(303, 223);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(72, 52);
            this.btn40.TabIndex = 65;
            this.btn40.Text = "£40";
            this.btn40.UseVisualStyleBackColor = true;
            this.btn40.Click += new System.EventHandler(this.btn40_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(391, 155);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(72, 52);
            this.btn20.TabIndex = 64;
            this.btn20.Text = "£20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(303, 155);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(72, 52);
            this.btn10.TabIndex = 63;
            this.btn10.Text = "£10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 43);
            this.btnExit.TabIndex = 62;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // accountBalanceBtn
            // 
            this.accountBalanceBtn.Location = new System.Drawing.Point(336, 243);
            this.accountBalanceBtn.Name = "accountBalanceBtn";
            this.accountBalanceBtn.Size = new System.Drawing.Size(143, 51);
            this.accountBalanceBtn.TabIndex = 61;
            this.accountBalanceBtn.Text = "Check Account Balance ATM";
            this.accountBalanceBtn.UseVisualStyleBackColor = true;
            this.accountBalanceBtn.Click += new System.EventHandler(this.accountBalanceBtn_Click);
            // 
            // withdrawATMBtn
            // 
            this.withdrawATMBtn.Location = new System.Drawing.Point(336, 155);
            this.withdrawATMBtn.Name = "withdrawATMBtn";
            this.withdrawATMBtn.Size = new System.Drawing.Size(143, 52);
            this.withdrawATMBtn.TabIndex = 60;
            this.withdrawATMBtn.Text = "Withdraw from ATM";
            this.withdrawATMBtn.UseVisualStyleBackColor = true;
            this.withdrawATMBtn.Click += new System.EventHandler(this.withdrawATMBtn_Click);
            // 
            // gifRenderer
            // 
            this.gifRenderer.Image = ((System.Drawing.Image)(resources.GetObject("gifRenderer.Image")));
            this.gifRenderer.Location = new System.Drawing.Point(1, 1);
            this.gifRenderer.Name = "gifRenderer";
            this.gifRenderer.Size = new System.Drawing.Size(799, 450);
            this.gifRenderer.TabIndex = 70;
            this.gifRenderer.TabStop = false;
            this.gifRenderer.Visible = false;
            // 
            // MainScreenATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gifRenderer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.customBtn);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.accountBalanceBtn);
            this.Controls.Add(this.withdrawATMBtn);
            this.Controls.Add(this.mainLbl);
            this.Name = "MainScreenATM";
            this.Text = "MainScreenATM";
            ((System.ComponentModel.ISupportInitialize)(this.gifRenderer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button customBtn;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button accountBalanceBtn;
        private System.Windows.Forms.Button withdrawATMBtn;
        private System.Windows.Forms.PictureBox gifRenderer;
    }
}