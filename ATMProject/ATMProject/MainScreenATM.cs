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
    public partial class MainScreenATM : Form
    {
        Account currentAccount;
        public MainScreenATM(Account current)
        {
            InitializeComponent();

            currentAccount = current;

            btn10.Visible = false;
            btn20.Visible = false;
            btn40.Visible = false;
            btn100.Visible = false;
            btn500.Visible = false;
            customBtn.Visible = false;
            btnBack.Visible = false;
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
        private void withdrawButtonOperation(int amount)
        {
            Account tempAccount = currentAccount;
            bool success = tempAccount.decrementBalance(amount);
            withdrawValidation(success);
        }
        private void withdrawValidation(bool success)
        {
            if (success)
            {
                MessageBox.Show("You successfully withdrew money from the ATM", "Success");
            }
            else
            {
                MessageBox.Show("Withdraw not successful, there is not enough money in your account", "Failure");
            }
        }
        private void accountBalanceBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your balance is £" + currentAccount.getBalance(), "Account Balance");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            int amount = 10;
            withdrawButtonOperation(amount);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            int amount = 20;
            withdrawButtonOperation(amount);
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            int amount = 40;
            withdrawButtonOperation(amount);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            int amount = 100;
            withdrawButtonOperation(amount);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            int amount = 500;
            withdrawButtonOperation(amount);
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            Prompt thisPrompt = new Prompt();
            int amount = Int32.Parse(thisPrompt.ShowDialog("How much?", "Custom Amount"));
            withdrawButtonOperation(amount);
            
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
    }
    //Prompt via https://stackoverflow.com/questions/5427020/prompt-dialog-in-windows-forms
    public class Prompt
    {
        public string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}

