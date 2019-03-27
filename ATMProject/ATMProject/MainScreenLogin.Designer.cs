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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenLogin));
            this.mainLbl = new System.Windows.Forms.Label();
            this.pinNumberLbl = new System.Windows.Forms.Label();
            this.accountNumberLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.pinNumberTxtbox = new System.Windows.Forms.TextBox();
            this.accountNumberTxtbox = new System.Windows.Forms.TextBox();
            this.InsertCardBtn = new System.Windows.Forms.Button();
            this.gifRenderer = new System.Windows.Forms.PictureBox();
            this.submitLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gifRenderer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.BackColor = System.Drawing.Color.Transparent;
            this.mainLbl.Font = new System.Drawing.Font("Sitka Heading", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLbl.Location = new System.Drawing.Point(215, 63);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(376, 58);
            this.mainLbl.TabIndex = 12;
            this.mainLbl.Text = "ATM System - Login";
            // 
            // pinNumberLbl
            // 
            this.pinNumberLbl.AutoSize = true;
            this.pinNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.pinNumberLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinNumberLbl.Location = new System.Drawing.Point(269, 244);
            this.pinNumberLbl.Name = "pinNumberLbl";
            this.pinNumberLbl.Size = new System.Drawing.Size(81, 13);
            this.pinNumberLbl.TabIndex = 23;
            this.pinNumberLbl.Text = "PIN Number:";
            // 
            // accountNumberLbl
            // 
            this.accountNumberLbl.AutoSize = true;
            this.accountNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.accountNumberLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLbl.Location = new System.Drawing.Point(260, 196);
            this.accountNumberLbl.Name = "accountNumberLbl";
            this.accountNumberLbl.Size = new System.Drawing.Size(106, 13);
            this.accountNumberLbl.TabIndex = 22;
            this.accountNumberLbl.Text = "Account Number:";
            // 
            // submitBtn
            // 
            this.submitBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitBtn.Image")));
            this.submitBtn.Location = new System.Drawing.Point(714, 396);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(62, 42);
            this.submitBtn.TabIndex = 21;
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
            // InsertCardBtn
            // 
            this.InsertCardBtn.Location = new System.Drawing.Point(316, 200);
            this.InsertCardBtn.Name = "InsertCardBtn";
            this.InsertCardBtn.Size = new System.Drawing.Size(164, 61);
            this.InsertCardBtn.TabIndex = 25;
            this.InsertCardBtn.Text = "Insert Card";
            this.InsertCardBtn.UseVisualStyleBackColor = true;
            this.InsertCardBtn.Click += new System.EventHandler(this.InsertCardBtn_Click);
            // 
            // gifRenderer
            // 
            this.gifRenderer.Image = global::ATMProject.Properties.Resources.ATM;
            this.gifRenderer.Location = new System.Drawing.Point(0, 0);
            this.gifRenderer.Name = "gifRenderer";
            this.gifRenderer.Size = new System.Drawing.Size(802, 451);
            this.gifRenderer.TabIndex = 26;
            this.gifRenderer.TabStop = false;
            // 
            // submitLbl
            // 
            this.submitLbl.AutoSize = true;
            this.submitLbl.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitLbl.Location = new System.Drawing.Point(573, 402);
            this.submitLbl.Name = "submitLbl";
            this.submitLbl.Size = new System.Drawing.Size(108, 30);
            this.submitLbl.TabIndex = 27;
            this.submitLbl.Text = "Submit -->";
            // 
            // MainScreenLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.accountNumberLbl);
            this.Controls.Add(this.pinNumberLbl);
            this.Controls.Add(this.pinNumberTxtbox);
            this.Controls.Add(this.accountNumberTxtbox);
            this.Controls.Add(this.mainLbl);
            this.Controls.Add(this.InsertCardBtn);
            this.Controls.Add(this.gifRenderer);
            this.Name = "MainScreenLogin";
            this.Text = "ATM Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.gifRenderer)).EndInit();
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
        private System.Windows.Forms.Button InsertCardBtn;
        private System.Windows.Forms.PictureBox gifRenderer;
        private System.Windows.Forms.Label submitLbl;
    }
}