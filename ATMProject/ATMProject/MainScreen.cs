using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class MainScreen : Form
    {
        Program thisProgram = new Program();
        public MainScreen()
        {
            InitializeComponent();

            withdrawATMBtn.Visible = false;
            withdrawATMBtn2.Visible = false;
            accountBalanceBtn.Visible = false;
            accountBalanceBtn2.Visible = false;
            btnExit.Visible = false;
            btnExit2.Visible = false;
            btn10.Visible = false;
            btn10_2.Visible = false;
            btn20.Visible = false;
            btn20_2.Visible = false;
            btn40.Visible = false;
            btn40_2.Visible = false;
            btn100.Visible = false;
            btn100_2.Visible = false;
            btn500.Visible = false;
            btn500_2.Visible = false;
            customBtn.Visible = false;
            customBtn_2.Visible = false;
            btnBack.Visible = false;
            btnBack_2.Visible = false;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (thisProgram.isLoginSuccessful(Int32.Parse(accountNumberTxtbox.Text), Int32.Parse(pinNumberTxtbox.Text)))
            {
                //TODO:Implement Success Condition
                updateForm();
            }
            else
            {
                //TODO:Implement Failure Condition
                MessageBox.Show("Please enter the correct account number or PIN", "Login Failed!", MessageBoxButtons.OK);

            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void updateForm()
        {
            mainLbl.Text = "ATM Systems -Choose Option(s)";
            submitBtn.Visible = false;
            accountNumberTxtbox.Visible = false;
            pinNumberTxtbox.Visible = false;
            withdrawATMBtn.Visible = true;
            withdrawATMBtn2.Visible = true;
            accountBalanceBtn.Visible = true;
            accountBalanceBtn2.Visible = true;
            btnExit.Visible = true;
            btnExit2.Visible = true;
            accountNumberLbl.Visible = false;
            pinNumberLbl.Visible = false;
        }

        private void withdrawATMBtn_Click(object sender, EventArgs e)
        {
            btn10.Visible = true;
            btn20.Visible = true;
            btn40.Visible = true;
            btn100.Visible = true;
            btn500.Visible = true;
            customBtn.Visible = true;
            btnBack.Visible = true;

            withdrawATMBtn.Visible = false;
            accountBalanceBtn.Visible = false;
            btnExit.Visible = false;
        }

        private void withdrawATMBtn2_Click(object sender, EventArgs e)
        {
            btn10_2.Visible = true;
            btn20_2.Visible = true;
            btn40_2.Visible = true;
            btn100_2.Visible = true;
            btn500_2.Visible = true;
            customBtn_2.Visible = true;
            btnBack_2.Visible = true;

            withdrawATMBtn2.Visible = false;
            accountBalanceBtn2.Visible = false;
            btnExit2.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            withdrawATMBtn.Visible = true;
            accountBalanceBtn.Visible = true;
            btnExit.Visible = true;

            btn10.Visible = false;
            btn20.Visible = false;
            btn40.Visible = false;
            btn100.Visible = false;
            btn500.Visible = false;
            customBtn.Visible = false;
            btnBack.Visible = false;
        }

        private void btnBack_2_Click(object sender, EventArgs e)
        {
            withdrawATMBtn2.Visible = true;
            accountBalanceBtn2.Visible = true;
            btnExit2.Visible = true;

            btn10_2.Visible = false;
            btn20_2.Visible = false;
            btn40_2.Visible = false;
            btn100_2.Visible = false;
            btn500_2.Visible = false;
            customBtn_2.Visible = false;
            btnBack_2.Visible = false;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(10);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(20);
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(40);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(100);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(500);
        }

        private void accountBalanceBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your balance is £" + thisProgram.GetATM().getActiveAccount().getBalance(), "Account Balance");
        }

        private void btn10_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(10);
        }

        private void btn20_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(20);
        }

        private void btn40_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(40);
        }

        private void btn100_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(100);
        }

        private void btn500_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(500);
        }

        private void accountBalanceBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your balance is £" + thisProgram.GetATM().getActiveAccount().getBalance(), "Account Balance");
        }

        
    }
        

        
    }

