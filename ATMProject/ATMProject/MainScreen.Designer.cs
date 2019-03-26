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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
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
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.customBtn = new System.Windows.Forms.Button();
            this.customBtn_2 = new System.Windows.Forms.Button();
            this.btn500_2 = new System.Windows.Forms.Button();
            this.btn100_2 = new System.Windows.Forms.Button();
            this.btn40_2 = new System.Windows.Forms.Button();
            this.btn20_2 = new System.Windows.Forms.Button();
            this.btn10_2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBack_2 = new System.Windows.Forms.Button();
            this.gifRenderer = new System.Windows.Forms.PictureBox();
            this.InsertCardBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gifRenderer)).BeginInit();
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
            this.accountBalanceBtn.Click += new System.EventHandler(this.accountBalanceBtn_Click);
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
            this.pinNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.accountBalanceBtn2.Click += new System.EventHandler(this.accountBalanceBtn2_Click);
            // 
            // withdrawATMBtn2
            // 
            this.withdrawATMBtn2.Location = new System.Drawing.Point(588, 176);
            this.withdrawATMBtn2.Name = "withdrawATMBtn2";
            this.withdrawATMBtn2.Size = new System.Drawing.Size(143, 52);
            this.withdrawATMBtn2.TabIndex = 24;
            this.withdrawATMBtn2.Text = "Withdraw from ATM";
            this.withdrawATMBtn2.UseVisualStyleBackColor = true;
            this.withdrawATMBtn2.Click += new System.EventHandler(this.withdrawATMBtn2_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(36, 176);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(72, 52);
            this.btn10.TabIndex = 27;
            this.btn10.Text = "£10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(126, 176);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(72, 52);
            this.btn20.TabIndex = 28;
            this.btn20.Text = "£20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn40
            // 
            this.btn40.Location = new System.Drawing.Point(36, 241);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(72, 52);
            this.btn40.TabIndex = 29;
            this.btn40.Text = "£40";
            this.btn40.UseVisualStyleBackColor = true;
            this.btn40.Click += new System.EventHandler(this.btn40_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(126, 244);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(72, 52);
            this.btn100.TabIndex = 30;
            this.btn100.Text = "£100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(36, 310);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(72, 52);
            this.btn500.TabIndex = 31;
            this.btn500.Text = "£500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // customBtn
            // 
            this.customBtn.Location = new System.Drawing.Point(126, 310);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(72, 52);
            this.customBtn.TabIndex = 32;
            this.customBtn.Text = "Custom amount";
            this.customBtn.UseVisualStyleBackColor = true;
            // 
            // customBtn_2
            // 
            this.customBtn_2.Location = new System.Drawing.Point(691, 310);
            this.customBtn_2.Name = "customBtn_2";
            this.customBtn_2.Size = new System.Drawing.Size(72, 52);
            this.customBtn_2.TabIndex = 38;
            this.customBtn_2.Text = "Custom amount";
            this.customBtn_2.UseVisualStyleBackColor = true;
            // 
            // btn500_2
            // 
            this.btn500_2.Location = new System.Drawing.Point(601, 310);
            this.btn500_2.Name = "btn500_2";
            this.btn500_2.Size = new System.Drawing.Size(72, 52);
            this.btn500_2.TabIndex = 37;
            this.btn500_2.Text = "£500";
            this.btn500_2.UseVisualStyleBackColor = true;
            this.btn500_2.Click += new System.EventHandler(this.btn500_2_Click);
            // 
            // btn100_2
            // 
            this.btn100_2.Location = new System.Drawing.Point(691, 244);
            this.btn100_2.Name = "btn100_2";
            this.btn100_2.Size = new System.Drawing.Size(72, 52);
            this.btn100_2.TabIndex = 36;
            this.btn100_2.Text = "£100";
            this.btn100_2.UseVisualStyleBackColor = true;
            this.btn100_2.Click += new System.EventHandler(this.btn100_2_Click);
            // 
            // btn40_2
            // 
            this.btn40_2.Location = new System.Drawing.Point(601, 241);
            this.btn40_2.Name = "btn40_2";
            this.btn40_2.Size = new System.Drawing.Size(72, 52);
            this.btn40_2.TabIndex = 35;
            this.btn40_2.Text = "£40";
            this.btn40_2.UseVisualStyleBackColor = true;
            this.btn40_2.Click += new System.EventHandler(this.btn40_2_Click);
            // 
            // btn20_2
            // 
            this.btn20_2.Location = new System.Drawing.Point(691, 176);
            this.btn20_2.Name = "btn20_2";
            this.btn20_2.Size = new System.Drawing.Size(72, 52);
            this.btn20_2.TabIndex = 34;
            this.btn20_2.Text = "£20";
            this.btn20_2.UseVisualStyleBackColor = true;
            this.btn20_2.Click += new System.EventHandler(this.btn20_2_Click);
            // 
            // btn10_2
            // 
            this.btn10_2.Location = new System.Drawing.Point(601, 176);
            this.btn10_2.Name = "btn10_2";
            this.btn10_2.Size = new System.Drawing.Size(72, 52);
            this.btn10_2.TabIndex = 33;
            this.btn10_2.Text = "£10";
            this.btn10_2.UseVisualStyleBackColor = true;
            this.btn10_2.Click += new System.EventHandler(this.btn10_2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(80, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBack_2
            // 
            this.btnBack_2.Location = new System.Drawing.Point(646, 397);
            this.btnBack_2.Name = "btnBack_2";
            this.btnBack_2.Size = new System.Drawing.Size(75, 23);
            this.btnBack_2.TabIndex = 40;
            this.btnBack_2.Text = "Back";
            this.btnBack_2.UseVisualStyleBackColor = true;
            this.btnBack_2.Click += new System.EventHandler(this.btnBack_2_Click);
            // 
            // gifRenderer
            // 
            this.gifRenderer.Image = ((System.Drawing.Image)(resources.GetObject("gifRenderer.Image")));
            this.gifRenderer.Location = new System.Drawing.Point(-1, 1);
            this.gifRenderer.Name = "gifRenderer";
            this.gifRenderer.Size = new System.Drawing.Size(800, 447);
            this.gifRenderer.TabIndex = 41;
            this.gifRenderer.TabStop = false;
            this.gifRenderer.Click += new System.EventHandler(this.gifRenderer_Click);
            // 
            // InsertCardBtn
            // 
            this.InsertCardBtn.Location = new System.Drawing.Point(294, 278);
            this.InsertCardBtn.Name = "InsertCardBtn";
            this.InsertCardBtn.Size = new System.Drawing.Size(184, 73);
            this.InsertCardBtn.TabIndex = 42;
            this.InsertCardBtn.Text = "Insert Card";
            this.InsertCardBtn.UseVisualStyleBackColor = true;
            this.InsertCardBtn.Click += new System.EventHandler(this.InsertCardBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertCardBtn);
            this.Controls.Add(this.gifRenderer);
            this.Controls.Add(this.btnBack_2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.customBtn_2);
            this.Controls.Add(this.btn500_2);
            this.Controls.Add(this.btn100_2);
            this.Controls.Add(this.btn40_2);
            this.Controls.Add(this.btn20_2);
            this.Controls.Add(this.btn10_2);
            this.Controls.Add(this.customBtn);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
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
            ((System.ComponentModel.ISupportInitialize)(this.gifRenderer)).EndInit();
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
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button customBtn;
        private System.Windows.Forms.Button customBtn_2;
        private System.Windows.Forms.Button btn500_2;
        private System.Windows.Forms.Button btn100_2;
        private System.Windows.Forms.Button btn40_2;
        private System.Windows.Forms.Button btn20_2;
        private System.Windows.Forms.Button btn10_2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBack_2;
        private System.Windows.Forms.PictureBox gifRenderer;
        private System.Windows.Forms.Button InsertCardBtn;
        private System.Windows.Forms.ImageList imageList1;
    }
}